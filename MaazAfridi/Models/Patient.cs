using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaazAfridi.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [DisplayName("Bed Number")]
        public string SeatNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateTime { get; set; }
    }
}