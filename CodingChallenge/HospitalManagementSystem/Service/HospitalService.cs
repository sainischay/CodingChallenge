using HospitalManagementSystem.Model;
using HospitalManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Service
{
    internal class HospitalService:IHospitalService
    {
        IHospitalRepository _hospitalRepository=new HospitalRepository();

        public Appointment GetAppointmentById()
        {
            try
            {
                PrintingService.GetAllAppointments();
                Console.WriteLine("Enter AppointmentId");
                int appointmentId = int.Parse(Console.ReadLine());
                Appointment appointment = _hospitalRepository.GetAppointmentById(appointmentId);
                return appointment;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Appointment();
            }
        }

        public List<Appointment> GetAppointmentsForPatient()
        {
            try
            {
                PrintingService.GetAllPatients();
                Console.WriteLine("Enter PatientId");
                int patientId = int.Parse(Console.ReadLine());
                List<Appointment> appointments = _hospitalRepository.GetAppointmentsForPatient(patientId);
                return appointments;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Appointment>();
            }
        }

        public List<Appointment> GetAppointmentsForDoctor()
        {
            try
            {
                PrintingService.GetAllDoctors();
                Console.WriteLine("Enter DoctorId");
                int doctorId = int.Parse(Console.ReadLine());
                List<Appointment> appointments = _hospitalRepository.GetAppointmentsForDoctor(doctorId);
                return appointments;
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Appointment>();
            }
        }

        public string ScheduleAppointment()
        {
            try
            {
                Appointment appointment = new Appointment();
                PrintingService.GetAllPatients();
                Console.WriteLine("Enter PatientId");
                appointment.PatientId = int.Parse(Console.ReadLine());
                PrintingService.GetAllDoctors();
                Console.WriteLine("Enter DoctorId");
                appointment.DoctorId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter AppointmentDate");
                appointment.AppointmentDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Description");
                appointment.Description = Console.ReadLine();
                int status = _hospitalRepository.ScheduleAppointment(appointment);
                if (status > 0)
                    return "Appointment Scheduled";
                else
                    return "Appointment Not Scheduled";
            }
            catch ( Exception ex )
            {
                Console.WriteLine(ex.Message);
                return "Appointment Not Scheduled";
            }
        }

        public string UpdateAppointment()
        {
            try
            {
                PrintingService.GetAllAppointments();
                Appointment appointment = new Appointment();
                Console.WriteLine("Enter AppointmentId");
                appointment.AppointmentId = int.Parse(Console.ReadLine());
                PrintingService.GetAllPatients();
                Console.WriteLine("Enter PatientId");
                appointment.PatientId = int.Parse(Console.ReadLine());
                PrintingService.GetAllDoctors();
                Console.WriteLine("Enter DoctorId");
                appointment.DoctorId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter AppointmentDate");
                appointment.AppointmentDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Description");
                appointment.Description = Console.ReadLine();
                int status = _hospitalRepository.UpdateAppointment(appointment);
                if (status > 0)
                    return "Appointment Updated";
                else
                    return "Appointment Not Updated";
            }
            catch( Exception ex )
            {
                Console.WriteLine(ex.Message);
                return "Appointment Not Updated";
            }
        }

        public string CancelAppointment()
        {
            try
            {
                PrintingService.GetAllAppointments();
                Console.WriteLine("Enter AppointmentId from above list");
                int appointmentId = int.Parse(Console.ReadLine());
                int status = _hospitalRepository.CancelAppointment(appointmentId);
                if (status > 0)
                    return "Appointment canceled";
                else
                    return "Appointment not canceled";
            }
            catch ( Exception ex ) { Console.WriteLine( ex.Message); return "Appointment not canceled"; }
        }
    }
}
