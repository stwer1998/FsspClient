using System;
using System.Collections.Generic;
using System.Text;

namespace FsspLibrary
{
    public class Response
    {
        public string task { get; set; }

        public string progress { get; set; }

        public int status { get; set; }
        public object task_start { get; set; }
        public Query query { get; set; }
        public string task_end { get; set; }
        public Result[] result { get; set; }

        public override string ToString()
        {
            return $"task={task}";
        }
    }
}
