﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace parcial1.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

         public DateTime Date { get; set; }
        public bool Used { get; set; }
      

        public string? Entrance { get; set; }

       



    }
}
