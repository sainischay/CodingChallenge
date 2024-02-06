using HospitalManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Service
{
    internal interface IPatientService
    {
        string CreatePatient();

        List<Patient> GetAllPatients();

        string UpdatePatient();

        string DeletePatient();
    }
}
