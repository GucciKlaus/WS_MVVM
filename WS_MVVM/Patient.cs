using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_MVVM
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public bool IsMale { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return $"{Firstname} {Lastname} [{PatientID}] {Birthday.ToShortDateString()}";
        }
    }
}
