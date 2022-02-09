using HMS.WPF.Data;
using HMS.WPF.Models;
using HMS.WPF.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class RoomsViewModel : BaseViewModel
    {
        //Items Properties
        public ObservableCollection<RoomCardViewModel> Rooms { get; set; }
        public ObservableCollection<RoomCardViewModel> FilteredRooms { get; set; }

        //Search Bar Properties
        public String SearchQuery { get; set; }

        //Add Dialog Properites
        public String RoomNumber { get; set; }
        public String RoomType { get; set; }
        public String textValidation { get; set; }

        public ICommand SearchAction { get; set; }

        public RoomsViewModel()
        {
            Rooms = new ObservableCollection<RoomCardViewModel>();
            SearchAction = new RelayCommand(Search);

            foreach (Room room in Hospital.Rooms.Values)
            {
                String type;
                if (room.GetType() == typeof(PrivateRoom))
                    type = "Private Room";
                else if (room.GetType() == typeof(SemiPrivateRoom))
                    type = "Semi Private Room";
                else
                    type = "StandardWard Room";

                Rooms.Add(
                    new RoomCardViewModel
                    {
                        ID = room.RoomID,
                        RoomNumber = room.RoomNumber,
                        Type = type,
                        Capacity = room.Patients.Count.ToString() + "/" + room.Capacity
                    }
                );
            }
            FilteredRooms = new ObservableCollection<RoomCardViewModel>(Rooms);
        }


        private void Search()
        {
            if (String.IsNullOrEmpty(SearchQuery))
            {
                FilteredRooms = new ObservableCollection<RoomCardViewModel>(Rooms);
                return;
            }

            FilteredRooms = new ObservableCollection<RoomCardViewModel>(
                Rooms.Where(room => room.RoomNumber.ToString().Contains(SearchQuery))
            );
        }

        public void addRoom()
        {
            if (RoomType == "Private")
            {
                PrivateRoom newPrivateRoom = new PrivateRoom
                {
                    RoomNumber = int.Parse(RoomNumber),
                };
                Rooms.Add(
                    new RoomCardViewModel
                    {
                        ID = newPrivateRoom.RoomID,
                        RoomNumber = newPrivateRoom.RoomNumber,
                        Type = "Private Room",
                        Capacity = newPrivateRoom.Patients.Count.ToString() + '/' + newPrivateRoom.Capacity.ToString()
                    }
               );

                FilteredRooms.Add(
                    new RoomCardViewModel
                    {
                        ID = newPrivateRoom.RoomID,
                        RoomNumber = newPrivateRoom.RoomNumber,
                        Type = "Private Room",
                        Capacity = newPrivateRoom.Patients.Count.ToString() + '/' + newPrivateRoom.Capacity.ToString()
                    }
               );

                Hospital.Rooms.Add(newPrivateRoom.RoomID, newPrivateRoom);
                HospitalDB.InsertRoom(newPrivateRoom);
            }

            else if (RoomType == "Semi Private")
            {
                SemiPrivateRoom newSemiPrivateRoom = new SemiPrivateRoom
                {
                    RoomNumber = int.Parse(RoomNumber)
                };
                Rooms.Add(
                       new RoomCardViewModel
                       {
                           ID = newSemiPrivateRoom.RoomID,
                           RoomNumber = newSemiPrivateRoom.RoomNumber,
                           Type = "Semi Private Room",
                           Capacity = newSemiPrivateRoom.Patients.Count.ToString() + '/' + newSemiPrivateRoom.Capacity.ToString()
                       }
                  );

                FilteredRooms.Add(
                    new RoomCardViewModel
                    {
                        ID = newSemiPrivateRoom.RoomID,
                        RoomNumber = newSemiPrivateRoom.RoomNumber,
                        Type = "Semi Private Room",
                        Capacity = newSemiPrivateRoom.Patients.Count.ToString() + '/' + newSemiPrivateRoom.Capacity.ToString()
                    }
               );

                Hospital.Rooms.Add(newSemiPrivateRoom.RoomID, newSemiPrivateRoom);
                HospitalDB.InsertRoom(newSemiPrivateRoom);
            }

            else if (RoomType == "Standard Ward")
            {
                StandardWard newStandardWardRoom = new StandardWard
                {
                    RoomNumber = int.Parse(RoomNumber)
                };

                Rooms.Add(
                       new RoomCardViewModel
                       {
                           ID = newStandardWardRoom.RoomID,
                           RoomNumber = newStandardWardRoom.RoomNumber,
                           Type = "StandardWard Room",
                           Capacity = newStandardWardRoom.Patients.Count.ToString() + '/' + newStandardWardRoom.Capacity.ToString()
                       }
                  );

                FilteredRooms.Add(
                    new RoomCardViewModel
                    {
                        ID = newStandardWardRoom.RoomID,
                        RoomNumber = newStandardWardRoom.RoomNumber,
                        Type = "StandardWard Room",
                        Capacity = newStandardWardRoom.Patients.Count.ToString() + '/' + newStandardWardRoom.Capacity.ToString()
                    }
               );

                Hospital.Rooms.Add(newStandardWardRoom.RoomID, newStandardWardRoom);
                HospitalDB.InsertRoom(newStandardWardRoom);
            }
        }

        public bool ValidateRoom()
        {
            RoomNumber = (RoomNumber != null) ? RoomNumber.Trim() : "";

            if (RoomType == null)
            {
                textValidation = "Room type is empty";
                return false;
            }

            if (RoomNumber == "")
            {
                textValidation = "Room number is empty";
                return false;
            }

            //check room number duplication
            foreach (Room room in Hospital.Rooms.Values)
            {
                if (int.Parse(RoomNumber) == room.RoomNumber)
                    return false;
            }

            return true;
        }
    }
}
