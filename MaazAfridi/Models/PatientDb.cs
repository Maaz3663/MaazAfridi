using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MaazAfridi.Models
{
   
        public class PatientDb : DbContext
        {

            public PatientDb() : base("PatientDb")
            {

            }
            public DbSet<Patient> Patient { get; set; }

        }
}
