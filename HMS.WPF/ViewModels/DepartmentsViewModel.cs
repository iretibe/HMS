using HMS.WPF.Models;
using HMS.WPF.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class DepartmentsViewModel : BaseViewModel
    {
        //Items Properties
        public ObservableCollection<DepartmentCardViewModel> Departments { get; set; }
        public ObservableCollection<DepartmentCardViewModel> FilteredDepartments { get; set; }

        //Search Bar Properties
        public String SearchQuery { get; set; }
        public ICommand SearchAction { get; set; }

        //Add Dialog Properites
        public String DepartmentName { get; set; }
        public String textValidation { get; set; }
        public ICommand addNewDepartment { get; set; }
        
        public DepartmentsViewModel()
        {
            Departments = new ObservableCollection<DepartmentCardViewModel>();
            SearchAction = new RelayCommand(Search);
            addNewDepartment = new RelayCommand(addDepartment);
            
            //Adding All Departments Cards
            foreach (Department department in Hospital.Departments.Values)
            {
                Departments.Add(
                    new DepartmentCardViewModel
                    {
                        ID = department.ID,
                        Name = department.Name,
                        EmployeesNumber = department.Nurse.Count + department.Doctors.Count,
                        PatientsNumber = department.Patients.Count
                    }
                );
            }

            FilteredDepartments = new ObservableCollection<DepartmentCardViewModel>(Departments);
        }

        private void Search()
        {
            if (String.IsNullOrEmpty(SearchQuery))
            {
                FilteredDepartments = new ObservableCollection<DepartmentCardViewModel>(Departments); return;
            }

            FilteredDepartments = new ObservableCollection<DepartmentCardViewModel>(
                Departments.Where(department => department.Name.ToLower().Contains(SearchQuery))
            );
        }

        public void addDepartment()
        {
            if (ValidateDepartment())
            {

                //Add the new Department to the hospital & DB
                Department newDepartment = new Department
                {
                    Name = DepartmentName,
                };

                Hospital.Departments.Add(newDepartment.ID, newDepartment);
                HospitalDB.InsertDepartment(newDepartment);

                //Add card to the new department
                Departments.Add(
                    new DepartmentCardViewModel
                    {
                        ID = newDepartment.ID,
                        Name = newDepartment.Name,
                        PatientsNumber = newDepartment.Patients.Count,
                        EmployeesNumber = newDepartment.Nurse.Count + newDepartment.Doctors.Count
                    });

                FilteredDepartments.Add(
                   new DepartmentCardViewModel
                   {
                       ID = newDepartment.ID,
                       Name = newDepartment.Name,
                       PatientsNumber = newDepartment.Patients.Count,
                       EmployeesNumber = newDepartment.Nurse.Count + newDepartment.Doctors.Count
                   });

                //Home.ViewModel.CloseRootDialog();
            }
            else
                return;
        }

        public bool ValidateDepartment()
        {
            DepartmentName = (DepartmentName != null) ? DepartmentName.Trim() : "";
            if (DepartmentName == "")
            {
                textValidation = "Department Name is empty";
                return false;

            }
            return true;
        }
    }
}
