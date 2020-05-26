using System;
using System.Collections.Generic;
using System.Text;

namespace FsspLibrary
{
    public class Result
    {
        public int status { get; set; }
        public Result[] result { get; set; }
        public Query query { get; set; }
        public string name { get; set; }
        public string exe_production { get; set; }
        public string details { get; set; }
        public string subject { get; set; }
        public string department { get; set; }
        public string bailiff { get; set; }
        public string ip_end { get; set; }

        public override string ToString()
        {
            return $"name:{name}{Environment.NewLine}" +
                $"exe_production:{exe_production}{Environment.NewLine}" +
                $"details{details}{Environment.NewLine}subject{subject}{Environment.NewLine}" +
                $"department{department}{Environment.NewLine}" +
                $"bailiff:{bailiff}{Environment.NewLine}ip_end{ip_end}{Environment.NewLine}";
        }

    }
}
