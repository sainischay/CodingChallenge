﻿using HospitalManagementSystem.Model;
using HospitalManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Service
{
    internal class DoctorService:IDoctorService
    {
        IDoctorRepository _doctorRepository = new DoctorRepository();
        public string CreateDoctor()
        {
            try
            {
                Doctor doctor = new Doctor();
                Console.WriteLine("Enter Firstname");
                doctor.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                doctor.LastName = Console.ReadLine();
                Console.WriteLine("Enter Specialization");
                doctor.Specialization = Console.ReadLine();
                Console.WriteLine("Enter ContactNumber");
                doctor.ContactNumber = Console.ReadLine();
                int status = _doctorRepository.CreateDoctor(doctor);
                if (status > 0)
                    return "Record Created";
                return "Record Not Created";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Record not created";
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = _doctorRepository.GetAllDoctors();
            return doctors;
        }

        public string UpdateDoctor()
        {
            try
            {
                PrintingService.GetAllDoctors();
                Console.WriteLine("Enter the ids from above list");
                Doctor doctor = new Doctor();
                Console.WriteLine("Enter DoctorId");
                doctor.DoctorId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Firstname");
                doctor.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                doctor.LastName = Console.ReadLine();
                Console.WriteLine("Enter Specialization");
                doctor.Specialization = Console.ReadLine();
                Console.WriteLine("Enter ContactNumber");
                doctor.ContactNumber = Console.ReadLine();
                int status = _doctorRepository.UpdateDoctor(doctor);
                if (status > 0)
                    return "Record Updated";
                return "Record Not Updated";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Record Not Updated";
            }
        }

        public string DeleteDoctor()
        {
            try
            {
                PrintingService.GetAllDoctors();
                Console.WriteLine("Enter the ids from above list");
                Console.WriteLine("Enter DoctorId");
                int doctorId = int.Parse(Console.ReadLine());
                int status = _doctorRepository.DeleteDoctor(doctorId);
                if (status > 0)
                    return "Record Deleted";
                return "Record Not Deleted";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Record Not deleted";
            }
        }
    }
}
