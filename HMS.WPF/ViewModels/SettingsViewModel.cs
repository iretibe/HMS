﻿using HMS.WPF.Models;
using HMS.WPF.Services;
using System;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        //Properties
        public double StandardPrice { get; set; }
        public double SemiPrice { get; set; }
        public double PrivatePrice { get; set; }
        public double AppointmentPrice { get; set; }
        public int StandardCapacity { get; set; }
        public int SemiCapacity { get; set; }
        public int PrivateCapacity { get; set; }

        //Command Property
        public ICommand SaveSettingsAction { get; set; }

        public SettingsViewModel()
        {
            SaveSettingsAction = new RelayCommand(saveSettings);
            ReloadData();
        }

        private void ReloadData()
        {
            StandardPrice = Hospital.Config.StandardWardPrice;
            StandardCapacity = Hospital.Config.StandardWardCapacity;
            SemiPrice = Hospital.Config.SemiPrivateRoomPrice;
            SemiCapacity = Hospital.Config.SemiPrivateRoomCapacity;
            PrivatePrice = Hospital.Config.PrivateRoomPrice;
            PrivateCapacity = Hospital.Config.PrivateRoomCapacity;
            AppointmentPrice = Hospital.Config.AppointmentHourPrice;
        }

        public void saveSettings()
        {
            Console.WriteLine("Saving Settings..");

            Config newConfig = new Config
            {
                StandardWardPrice = StandardPrice,
                StandardWardCapacity = StandardCapacity,
                SemiPrivateRoomPrice = SemiPrice,
                SemiPrivateRoomCapacity = SemiCapacity,
                PrivateRoomPrice = PrivatePrice,
                PrivateRoomCapacity = PrivateCapacity,
                AppointmentHourPrice = AppointmentPrice
            };

            HospitalDB.UpdateConfig(newConfig);
            Hospital.Config = newConfig;
        }
    }
}
