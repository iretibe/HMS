using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.WPF.Data
{
    public class Patient
    {
        public Guid PatientID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Diagnosis { get; set; }
    }
}
