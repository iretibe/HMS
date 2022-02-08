using HMS.WPF.Data;
using HMS.WPF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HMS.WPF.Services
{
    static class HospitalDB
    {
        public static SqlConnection InitConnection()
        {
            string connectionString = "SERVER=PSL-DBSERVER-VM3\\DEVELOPMENT2017;DATABASE=HMSDB;user id=sa;password=Persol@123;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True";
            
            return new SqlConnection(connectionString);
        }

        #region Fetching Operations
        public static Models.Config FetchConfig()
        {
            SqlConnection con = InitConnection();
            Models.Config Config = new Models.Config
            {
                StandardWardCapacity = 4,
                StandardWardPrice = 50,
                SemiPrivateRoomCapacity = 2,
                SemiPrivateRoomPrice = 90,
                PrivateRoomCapacity = 1,
                PrivateRoomPrice = 150,
                AppointmentHourPrice = 40
            };

            try
            {
                con.Open();
                String query = "SELECT * FROM config";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Config = new Models.Config
                    {
                        //StandardWardPrice = reader.GetFloat("standard_price"),
                        //SemiPrivateRoomPrice = reader.GetFloat("semi_price"),
                        //PrivateRoomPrice = reader.GetFloat("private_price"),
                        //AppointmentHourPrice = reader.GetFloat("appointment_price"),
                        //StandardWardCapacity = reader.GetInt32("standard_capacity"),
                        //SemiPrivateRoomCapacity = reader.GetInt32("semi_capacity"),
                        //PrivateRoomCapacity = reader.GetInt32("private_capacity")
                    };
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Config.");
            }
            finally
            {
                con.Close();
            }

            return Config;
        }

        public static List<Department> FetchDepartments()
        {
            SqlConnection con = InitConnection();
            List<Department> departments = new List<Department>();
            try
            {
                con.Open();
                string query = "SELECT * FROM department";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    departments.Add(
                        new Department
                        {
                            DepartmentId = Guid.NewGuid(),
                            Name = reader.GetString("name")
                        }
                    );
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Departments.");
            }
            finally
            {
                con.Close();
            }

            return departments;
        }

        public static List<Room> FetchRooms()
        {
            SqlConnection con = InitConnection();
            List<Room> rooms = new List<Room>();
            try
            {
                con.Open();
                String query = "SELECT * FROM room";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String room_id = reader.GetString("room_id");
                    int number = reader.GetInt32("room_number");
                    String type = reader.GetString("type");
                    Room newRoom = null;
                    if (type == typeof(PrivateRoom).ToString())
                        newRoom = new PrivateRoom { ID = room_id, RoomNumber = number };
                    else if (type == typeof(SemiPrivateRoom).ToString())
                        newRoom = new SemiPrivateRoom { ID = room_id, RoomNumber = number };
                    else if (type == typeof(StandardWard).ToString())
                        newRoom = new StandardWard { ID = room_id, RoomNumber = number };

                    rooms.Add(newRoom);
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Rooms.");
            }
            finally
            {
                con.Close();
            }

            return rooms;
        }

        public static List<Doctor> FetchDoctors()
        {
            SqlConnection con = InitConnection();
            List<Doctor> doctors = new List<Doctor>();
            try
            {
                con.Open();
                String query = "SELECT * FROM doctor";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    doctors.Add(new Doctor
                    {
                        ID = reader.GetString("doctor_id"),
                        Name = reader.GetString("name"),
                        BirthDate = reader.GetDateTime("birth_date"),
                        Address = reader.GetString("address"),
                        EmploymentDate = reader.GetDateTime("employment_date"),
                        Salary = reader.GetFloat("salary"),
                        IsHead = reader.GetBoolean("is_head")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Doctors.");
            }
            finally
            {
                con.Close();
            }

            return doctors;
        }

        public static List<Nurse> FetchNurses()
        {
            SqlConnection con = InitConnection();
            List<Nurse> nurses = new List<Nurse>();
            try
            {
                con.Open();
                String query = "SELECT * FROM nurse";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nurses.Add(new Nurse
                    {
                        ID = reader.GetString("nurse_id"),
                        Name = reader.GetString("name"),
                        BirthDate = reader.GetDateTime("birth_date"),
                        Address = reader.GetString("address"),
                        EmploymentDate = reader.GetDateTime("employment_date"),
                        Salary = reader.GetFloat("salary")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Nurses.");
            }
            finally
            {
                con.Close();
            }

            return nurses;
        }

        public static List<Employee> FetchEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(FetchDoctors());
            employees.AddRange(FetchNurses());

            return employees;
        }

        public static String FetchPersonDepartment(String personID)
        {
            SqlConnection con = InitConnection();
            String departmentID = "";

            try
            {
                con.Open();
                String query = $"SELECT department_id FROM person_department WHERE person_id = '{personID}'";
                SqlCommand command = new SqlCommand(query, con);
                object result = command.ExecuteScalar();
                if (result is String)
                    departmentID = (String)result;
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Department.");
            }
            finally
            {
                con.Close();
            }

            return departmentID;
        }

        public static List<String> FetchNurseRooms(String nurseID)
        {
            List<String> rooms = new List<String>();
            SqlConnection con = InitConnection();

            try
            {
                con.Open();
                String query = $"SELECT room_id FROM nurse_room WHERE nurse_id = '{nurseID}'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //rooms.Add(reader.GetString("room_id"));
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Nurse Room.");
            }
            finally
            {
                con.Close();
            }
            return rooms;
        }

        public static List<ResidentPatient> FetchResidentPatients()
        {
            List<ResidentPatient> patients = new List<ResidentPatient>();
            SqlConnection con = InitConnection();

            try
            {
                con.Open();
                String query = "SELECT * FROM residentPatients";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patients.Add(new ResidentPatient
                    {
                        ResidentPatientID = reader.GetString("patient_id"),
                        Name = reader.GetString("name"),
                        BirthDate = reader.GetDateTime("birth_date"),
                        Address = reader.GetString("address"),
                        Diagnosis = reader.GetString("diagnosis"),
                        EntryDate = reader.GetDateTime("entry_date")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Resident Patients.");
            }
            finally
            {
                con.Close();
            }

            return patients;
        }

        public static String FetchPatientRoom(String patientID)
        {
            SqlConnection con = InitConnection();
            String roomID = "";
            try
            {
                con.Open();
                String query = $"SELECT room_id from resident_patient WHERE patient_id = '{patientID}'";
                SqlCommand command = new SqlCommand(query, con);

                object result = command.ExecuteScalar();
                if (result is String)
                    roomID = (String)result;
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Patient Room.");
            }
            finally
            {
                con.Close();
            }

            return roomID;
        }

        public static List<AppointmentPatient> FetchAppointmentPatients()
        {
            List<AppointmentPatient> patients = new List<AppointmentPatient>();
            SqlConnection con = InitConnection();

            try
            {
                con.Open();
                String query = "SELECT patient.* FROM patient join appointment USING(patient_id) GROUP BY patient_id";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patients.Add(new AppointmentPatient
                    {
                        //ID = reader.GetString("patient_id"),
                        //Name = reader.GetString("name"),
                        //BirthDate = reader.GetDateTime("birth_date"),
                        //Address = reader.GetString("address"),
                        //Diagnosis = reader.GetString("diagnosis"),
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Appointment Patients.");
            }
            finally
            {
                con.Close();
            }

            return patients;
        }

        public static List<AppointmentPatient> FetchUncategorizedPatients()
        {
            List<AppointmentPatient> patients = new List<AppointmentPatient>();
            SqlConnection con = InitConnection();

            try
            {
                con.Open();
                String query = "SELECT * FROM uncategorized_patient";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patients.Add(new AppointmentPatient
                    {
                        //ID = reader.GetString("patient_id"),
                        //Name = reader.GetString("name"),
                        //BirthDate = reader.GetDateTime("birth_date"),
                        //Address = reader.GetString("address"),
                        //Diagnosis = reader.GetString("diagnosis"),
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Uncategorized Patients.");
            }
            finally
            {
                con.Close();
            }

            return patients;
        }

        public static List<Patient> FetchPatients()
        {
            List<Patient> patients = new List<Patient>();
            patients.AddRange(FetchResidentPatients());
            patients.AddRange(FetchAppointmentPatients());
            patients.AddRange(FetchUncategorizedPatients());

            return patients;
        }

        public static List<Medicine> FetchMedicine()
        {
            SqlConnection con = InitConnection();
            List<Medicine> medicine = new List<Medicine>();
            try
            {
                con.Open();
                String query = "SELECT * from medicine";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    medicine.Add(new Medicine
                    {
                        //ID = reader.GetString("medicine_id"),
                        //Name = reader.GetString("name"),
                        //StartingDate = reader.GetDateTime("starting_date"),
                        //EndingDate = reader.GetDateTime("ending_date")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Medicine.");
            }
            finally
            {
                con.Close();
            }

            return medicine;
        }

        public static List<Medicine> FetchMedicine(String patientID)
        {
            SqlConnection con = InitConnection();
            List<Medicine> medicine = new List<Medicine>();
            try
            {
                con.Open();
                String query = $"SELECT * from medicine WHERE patient_id = '{patientID}'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    medicine.Add(new Medicine
                    {
                        //ID = reader.GetString("medicine_id"),
                        //Name = reader.GetString("name"),
                        //StartingDate = reader.GetDateTime("starting_date"),
                        //EndingDate = reader.GetDateTime("ending_date")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Patient Medicine.");
            }
            finally
            {
                con.Close();
            }

            return medicine;
        }

        public static List<Appointment> FetchAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            SqlConnection con = InitConnection();

            try
            {
                con.Open();
                String query = "SELECT * FROM patient join appointment USING(patient_id)";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment
                    {
                        //ID = reader.GetString("appointment_id"),
                        //Date = reader.GetDateTime("date"),
                        //Duration = reader.GetInt32("duration")
                    });
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Appointments.");
            }
            finally
            {
                con.Close();
            }

            return appointments;
        }

        public static String FetchAppointmentDoctor(String appointmentID)
        {
            SqlConnection con = InitConnection();
            String doctorID = "";
            try
            {
                con.Open();
                String query = $"SELECT doctor_id from appointment WHERE appointment_id = '{appointmentID}'";
                SqlCommand command = new SqlCommand(query, con);
                doctorID = (String)command.ExecuteScalar();
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Appointment Doctor.");
            }
            finally
            {
                con.Close();
            }

            return doctorID;
        }

        public static String FetchAppointmentPatient(String appointmentID)
        {
            SqlConnection con = InitConnection();
            String patientID = "";
            try
            {
                con.Open();
                String query = $"SELECT patient_id from appointment WHERE appointment_id = '{appointmentID}'";
                SqlCommand command = new SqlCommand(query, con);
                patientID = (String)command.ExecuteScalar();
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Appointment Patient.");
            }
            finally
            {
                con.Close();
            }

            return patientID;
        }

        public static List<String> FetchPatientDoctors(String patientID)
        {
            SqlConnection con = InitConnection();
            List<String> doctorsID = new List<String>();

            try
            {
                con.Open();
                String query = $"SELECT doctor_id from doctor_patient WHERE patient_id = '{patientID}'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //doctorsID.Add(reader.GetString("doctor_id"));
                }
            }
            catch
            {
                Console.WriteLine("Error Occured Fetching Patient Doctors.");
            }
            finally
            {
                con.Close();
            }

            return doctorsID;
        }
        #endregion

        #region Inserting Operations
        public async static void InsertDepartment(Department department)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO department VALUES('{department.ID}', '{department.Name}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Department.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertDoctor(Doctor doctor)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO doctor VALUES('{doctor.ID}', '{doctor.Name}', " +
                    $"'{doctor.BirthDate.ToString("yyyy-MM-dd")}', '{doctor.Address}', '{doctor.EmploymentDate.ToString("yyyy-MM-dd")}', '{doctor.Department.ID}'," +
                    $"{doctor.Salary}, {doctor.IsHead})";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Doctor.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertNurse(Nurse nurse)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO nurse VALUES('{nurse.NurseID}', '{nurse.Name}', " +
                    $"'{nurse.BirthDate}', '{nurse.Address}', '{nurse.EmploymentDate}', '{nurse.Department.DepartmentId}'," +
                    $"{nurse.Salary})";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Nurse.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertPatient(Patient patient)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO patient VALUES('{patient.PatientID}', '{patient.Name}', " +
                    $"'{patient.BirthDate}', '{patient.Address}', '{patient.Diagnosis}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();

                if (patient.GetType() == typeof(ResidentPatient))
                {
                    query = $"INSERT INTO ResidentPatient VALUES('{Guid.NewGuid()}', '{((ResidentPatient)patient.Room.Roo}', " +
                        $"'{((ResidentPatient)patient).Department.DepartmentId}', '{((ResidentPatient)patient).EntryDate}')";
                    command = new SqlCommand(query, con);
                    await command.ExecuteNonQueryAsync();
                }
            }
            catch
            {
                Console.WriteLine("Error Inserting Patient.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertRoom(Room room)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO room VALUES('{Guid.NewGuid()}', {room.RoomNumber}, '{room.GetType()}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Room.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertAppointment(Appointment appointment)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO appointment VALUES('{appointment.AppointmentID}', '{appointment.Patient.AppointmentPatientID}', " +
                    $"'{appointment.Doctor.DoctorID}', '{appointment.Date}', {appointment.Duration})";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Appointment.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertMedicine(Medicine medicine, Patient patient)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO medicine VALUES('{medicine.MedecineID}', '{medicine.Name}', " +
                    $"'{medicine.StartingDate}', '{medicine.EndingDate}', '{patient.PatientID}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Medicine.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertNurseRoom(String NurseID, String RoomID)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO nurse_room VALUES('{NurseID}', '{RoomID}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Nurse Room.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void InsertDoctorPatient(String DoctorID, String PatientID)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"INSERT INTO doctor_patient VALUES('{DoctorID}', '{PatientID}')";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Inserting Doctor Patient.");
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Updating Operations

        public async static void UpdateConfig(Config config)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE config SET standard_price = {config.StandardWardPrice}, semi_price = {config.SemiPrivateRoomPrice}, " +
                    $"private_price = {config.PrivateRoomPrice}, appointment_price = {config.AppointmentHourPrice}, " +
                    $"standard_capacity = {config.StandardWardCapacity}, semi_capacity = {config.SemiPrivateRoomCapacity}, " +
                    $"private_capacity = {config.PrivateRoomCapacity} " +
                    $"WHERE id = 1";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Config.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdateDepartment(Department department)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE department SET name = '{department.Name}' WHERE DepartmentId = '{department.DepartmentId}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Department.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdateDoctor(Doctor doctor)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE doctor SET Name = '{doctor.Name}', BirthDate = '{doctor.BirthDate}', " +
                    $"address = '{doctor.Address}', EmploymentDate = '{doctor.EmploymentDate}', " +
                    $"DepartmentID = '{doctor.Department.DepartmentId}', Salary = {doctor.Salary}, IsHead = {doctor.IsHead} " +
                    $"WHERE DoctorID = '{doctor.DoctorID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Doctor.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdateNurse(Nurse nurse)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE Nurse SET Name = '{nurse.Name}', BirthDate = '{nurse.BirthDate}', " +
                    $"Address = '{nurse.Address}', EmploymentDate = '{nurse.EmploymentDate}', " +
                    $"DepartmentId = '{nurse.Department.DepartmentId}', Salary = {nurse.Salary} " +
                    $"WHERE NurseID = '{nurse.NurseID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Nurse.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdateAppointment(Appointment appointment)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE Appointment SET PatientID = '{appointment.Patient.PatientID}', DoctorID = '{appointment.Doctor.DoctorID}', " +
                    $"Date = '{appointment.Date.ToString("yyyy-MM-dd hh:mm:ss")}', duration = {appointment.Duration}, " +
                    $"WHERE appointment_id = '{appointment.ID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Appointment.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdatePatient(Patient patient)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE patient SET name = '{patient.Name}', birth_date = '{patient.BirthDate}', " +
                    $"address = '{patient.Address}', diagnosis = '{patient.Diagnosis}' " +
                    $"WHERE patient_id = '{patient.PatientID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();

                if (patient.GetType() == typeof(ResidentPatient))
                {
                    query = $"UPDATE resident_patient SET room_id = '{((ResidentPatient)patient).Room.ID}', " +
                        $"department_id = '{((ResidentPatient)patient).Department.ID}', " +
                        $"entry_date = '{((ResidentPatient)patient).EntryDate.ToString("yyy-MM-dd")}' " +
                        $"WHERE patient_id = '{patient.ID}'";

                    command = new SqlCommand(query, con);
                    await command.ExecuteNonQueryAsync();
                }
            }
            catch
            {
                Console.WriteLine("Error Updating Patient.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void UpdateRoom(Room room)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"UPDATE room SET room_number = {room.RoomNumber}, type = '{room.GetType()}' " +
                    $"WHERE room_id = '{room.ID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Updating Room.");
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Deleting Operations

        public async static void DeleteDepartment(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM department WHERE department_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Department.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteDoctor(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM doctor WHERE doctor_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Doctor.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteNurse(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM nurse WHERE nurse_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Nurse.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeletePatient(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM patient WHERE patient_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Patient.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteAppointment(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM appointment WHERE appointment_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Appointment.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteRoom(String id)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM room WHERE room_id = '{id}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Room.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteNurseRoom(String NurseID, String RoomID)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM nurse_room WHERE nurse_id = '{NurseID}' AND room_id = '{RoomID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Nurse Room.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteDoctorPatient(String DoctorID, String PatientID)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM doctor_patient WHERE doctor_id = '{DoctorID}' AND patient_id = '{PatientID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Doctor Patient.");
            }
            finally
            {
                con.Close();
            }
        }

        public async static void DeleteMedicine(String MedicineID)
        {
            SqlConnection con = InitConnection();

            try
            {
                await con.OpenAsync();
                String query = $"DELETE FROM medicine WHERE medicine_id = '{MedicineID}'";
                SqlCommand command = new SqlCommand(query, con);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                Console.WriteLine("Error Deleting Medicine.");
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
