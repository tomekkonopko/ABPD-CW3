using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace ABPD03
{
    public class Studies
    {
        public string name { get; set; }
        public string mode { get; set; }

        public Studies(string studies, string type)
        {
            this.name = studies;
            this.mode = type;
        }

        public Studies()
        {
        }

    }
}
