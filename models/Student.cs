﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDotNet001.models
{
    public class Student
    {
        public Student()
        {

        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
