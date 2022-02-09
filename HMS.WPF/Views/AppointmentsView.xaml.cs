﻿using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for AppointmentsView.xaml
    /// </summary>
    public partial class AppointmentsView : UserControl
    {
        public AppointmentsViewModel ViewModel { get; set; }

        public AppointmentsView()
        {
            ViewModel = new AppointmentsViewModel();
            DataContext = ViewModel;
            InitializeComponent();
            AppointmentDatePicker.BlackoutDates.AddDatesInPast();
            PatientNameComboBox.DisplayMemberPath = "Value";
            PatientNameComboBox.SelectedValuePath = "Key";
            PatientNameComboBox.ItemsSource = ViewModel.patientsComboBoxItems;

            DoctorNameComboBox.DisplayMemberPath = "Value";
            DoctorNameComboBox.SelectedValuePath = "Key";
            DoctorNameComboBox.ItemsSource = ViewModel.doctorsComboBoxItems;
        }

        public void addSubmit(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Validate())
            {
                ViewModel.addAppointment();
                AppointmentDuration.Clear();
                AppointmentTimePicker.SelectedTime = null;
                PatientNameComboBox.SelectedItem = null;
                DoctorNameComboBox.SelectedItem = null;
                AppointmentDatePicker.SelectedDate = DateTime.Today;

            }
        }
        private void ClearAddAppointment(object sender, DialogClosingEventArgs eventArgs)
        {
            AppointmentTimePicker.SelectedTime = null;
            PatientNameComboBox.SelectedItem = null;
            DoctorNameComboBox.SelectedItem = null;
            AppointmentDuration.Clear();
            AppointmentDatePicker.SelectedDate = DateTime.Today;
            validation.Text = "";
        }
    }
}
