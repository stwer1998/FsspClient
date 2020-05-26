using System;
using System.Collections.Generic;
using System.Text;

namespace FsspLibrary
{
    public class ResponseFssp
    {
        public string status { get; set; }
        public int code { get; set; }
        public string exception { get; set; }
        public Response response { get; set; }
    }
}
