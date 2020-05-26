using System;
using System.Collections.Generic;
using System.Text;

namespace FsspLibrary
{
    public class PhysicalPerson
    {
        public int Region { get; set; }

        public string Firsname { get; set; }

        public string Secondname { get; set; }

        public string Lastname { get; set; }

        public DateTime? Birthday { get; set; }

        public override string ToString()
        {
            var result = $"region={Region}&firstname={Firsname}&lastname={Lastname}";
            if (Secondname != null)
            {
                result += $"&secondname={ Secondname}";
            }
            if (Birthday != null)
            {
                result += $"&birthdate={Birthday.Value.ToShortDateString()}";
            }
            return result;
        }
    }
}
