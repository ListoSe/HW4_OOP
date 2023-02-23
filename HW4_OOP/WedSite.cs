using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP
{
    internal class WedSite
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public WedSite(){}
        public WedSite(string name, string url, string description, string ip) {
            this.name = name;  
            this.url = url;
            this.description = description;
            this.ip = ip;
        }

        public void SetName(string name) { this.name = name; }
        public void SetUrl(string url) { this.url = url; }
        public void SetDescription(string description) { this.description = description; }
        public void SetIp(string ip) { this.ip = ip; }

        public string GetName() { return name; }
        public string GetUrl() { return url; }
        public string GetDescription() { return description; }
        public string GetIp() { return ip; }

    }
}
