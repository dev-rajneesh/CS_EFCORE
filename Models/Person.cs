﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS_EFCORE.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        private string Email { get; set; }
    }
}
