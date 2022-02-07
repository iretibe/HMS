﻿using HMS.WPF.Models;
using HMS.WPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class EmployeesViewModel : BaseViewModel
    {
        //Items Properties
        public ObservableCollection<EmployeeCardViewModel> Employees { get; set; }
        public ObservableCollection<EmployeeCardViewModel> FilteredEmployees { get; set; }

        //Search Bar Properties
        public String SearchQuery { get; set; }

        //Add Dialog Properites
        public String EmployeeNameTextBox { get; set; }
        public String EmployeeAddressTextBox { get; set; }
        public String EmployeeSalaryTextBox { get; set; }
        public ComboBoxPairs EmployeeDepartment { get; set; }
        public DateTime EmployeeDatePicker { get; set; }
        public String EmpoloyeeRoleComboBox { get; set; }
        public String doc;
        public String textValidation { get; set; }
        public bool isHeadCheck { get; set; }
        public String EmployeeRole
        {
            get => doc;
            set
            {
                if (value == "Doctor")
                    isHead = Visibility.Visible;
                else
                    isHead = Visibility.Collapsed;

                doc = value;
            }
        }

        public List<ComboBoxPairs> ComboBoxItems;
        public Visibility isHead { get; set; }

        public ICommand SearchAction { get; set; }

        public EmployeesViewModel()
        {
            EmployeeDatePicker = DateTime.Today;
            ComboBoxItems = new List<ComboBoxPairs>();
            SearchAction = new RelayCommand(Search);
            isHead = Visibility.Collapsed;

            foreach (Department department in Hospital.Departments.Values)
            {

                if (department != null)
                    ComboBoxItems.Add(new ComboBoxPairs(department.ID, department.Name));
            }

            Employees = new ObservableCollection<EmployeeCardViewModel>();
            
            foreach (Employee employee in Hospital.Employees.Values)
            {
                Employees.Add(
                    new EmployeeCardViewModel
                    {
                        ID = employee.ID,
                        Name = employee.Name,
                        Role = (employee.GetType() == typeof(Doctor)) ? "Doctor" : "Nurse",
                        Department = (employee.Department != null) ? employee.Department.Name : "N/A",
                        Salary = employee.Salary.ToString() + '$'
                    }
                );
            }

            FilteredEmployees = new ObservableCollection<EmployeeCardViewModel>(Employees);
        }

        private void Search()
        {
            if (String.IsNullOrEmpty(SearchQuery))
            {
                FilteredEmployees = new ObservableCollection<EmployeeCardViewModel>(Employees);
                return;
            }

            FilteredEmployees = new ObservableCollection<EmployeeCardViewModel>(
                Employees.Where(employee => employee.Name.ToLower().Contains(SearchQuery))
            );
        }

        public void addEmployee()
        {
            if (EmployeeRole == "Doctor")
            {
                if (isHeadCheck)
                {
                    string HeadID = Hospital.Departments[EmployeeDepartment.Key].HeadID;
                    
                    if (HeadID != "")
                        ((Doctor)Hospital.Employees[HeadID]).IsHead = false;
                }

                Doctor newDoctor = new Doctor
                {
                    Name = EmployeeNameTextBox,
                    Salary = Double.Parse(EmployeeSalaryTextBox),
                    Department = Hospital.Departments[EmployeeDepartment.Key],
                    Address = EmployeeAddressTextBox,
                    IsHead = isHeadCheck,
                    BirthDate = EmployeeDatePicker
                };

                Employees.Add(
                    new EmployeeCardViewModel
                    {
                        ID = newDoctor.ID,
                        Name = newDoctor.Name,
                        Salary = $"{newDoctor.Salary}$",
                        Department = newDoctor.Department.Name,
                        Role = "Doctor"
                    });

                FilteredEmployees.Add(
                   new EmployeeCardViewModel
                   {
                       ID = newDoctor.ID,
                       Name = newDoctor.Name,
                       Salary = $"{newDoctor.Salary}$",
                       Department = newDoctor.Department.Name,
                       Role = "Doctor"
                   });

                Hospital.Departments[newDoctor.Department.ID].addDoctor(newDoctor);
                Hospital.Departments[newDoctor.Department.ID].HeadID = newDoctor.ID;
                Hospital.Employees.Add(newDoctor.ID, newDoctor);
                HospitalDB.InsertDoctor(newDoctor);
            }
            else if (EmployeeRole == "Nurse")
            {
                Nurse newNurse = new Nurse
                {
                    Name = EmployeeNameTextBox,
                    Salary = Double.Parse(EmployeeSalaryTextBox),
                    Department = Hospital.Departments[EmployeeDepartment.Key],
                    Address = EmployeeAddressTextBox,
                    BirthDate = EmployeeDatePicker,
                };

                Employees.Add(
                    new EmployeeCardViewModel
                    {
                        ID = newNurse.ID,
                        Name = newNurse.Name,
                        Salary = $"{newNurse.Salary}$",
                        Department = newNurse.Department.Name,
                        Role = "Nurse"
                    });

                FilteredEmployees.Add(
                   new EmployeeCardViewModel
                   {
                       ID = newNurse.ID,
                       Name = newNurse.Name,
                       Salary = $"{newNurse.Salary}$",
                       Department = newNurse.Department.Name,
                       Role = "Nurse"
                   });

                Hospital.Departments[newNurse.Department.ID].addNurse(newNurse);
                Hospital.Employees.Add(newNurse.ID, newNurse);
                HospitalDB.InsertNurse(newNurse);
            }
        }

        public bool ValidateName()
        {
            EmployeeNameTextBox = (EmployeeNameTextBox != null) ? EmployeeNameTextBox.Trim() : "";
            EmployeeAddressTextBox = (EmployeeAddressTextBox != null) ? EmployeeAddressTextBox.Trim() : "";
            EmployeeSalaryTextBox = (EmployeeSalaryTextBox != null) ? EmployeeSalaryTextBox.Trim() : "";
            EmployeeRole = (EmployeeRole != null) ? EmployeeRole.Trim() : "";
            
            if (EmployeeNameTextBox == "")
            {
                textValidation = "Employee Name is Empty";
                return false;
            }

            if (EmployeeAddressTextBox == "")
            {
                textValidation = "Employee Address is Empty";
                return false;
            }

            if (EmployeeSalaryTextBox == "")
            {
                textValidation = "Employee Salary is Empty";
                return false;
            }

            if (EmployeeDepartment == null)
            {
                textValidation = "Employee Depratment is Empty";
                return false;
            }

            if (EmployeeRole == "")
            {
                textValidation = "Employee Role is Empty";
                return false;
            }

            return true;
        }
    }
}
