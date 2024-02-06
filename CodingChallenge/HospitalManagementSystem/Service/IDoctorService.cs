using HospitalManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Service
{
    internal interface IDoctorService
    {
        string CreateDoctor();

        List<Doctor> GetAllDoctors();

        string UpdateDoctor();

        string DeleteDoctor();
    }
}
