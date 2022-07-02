using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class SystemConfiguration
    {
        private string _RAM;
        private string _HDD;

        public SystemConfiguration(string rAM, string hDD)
        {
            _RAM = rAM;
            _HDD = hDD;
        }

        public string BuildSystem()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("RAM: {0} & ", _RAM));
            sb.Append(string.Format("HDD: {0}", _HDD));

            return sb.ToString();
        }
    }
}
