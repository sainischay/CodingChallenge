﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Exceptions
{
    internal class InvalidPhoneNumber:ApplicationException
    {
        public InvalidPhoneNumber(string msg):base(msg)
        {
            
        }
    }
}
