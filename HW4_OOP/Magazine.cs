using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP
{
    internal class Magazine
    {
        private string name;
        private string description;
        private string phone;
        private string email;
        public Magazine() { }
        public Magazine(string name, string description, string phone, string email) { 
            this.name = name;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public void SetName(string name) { this.name = name; }
        public void SetDescription(string description) { this.description = description; }
        public void SetPhone(string phone) { this.phone = phone; }
        public void SetEmail(string email) { this.email = email; }

        public string GetName() { return name; }
        public string GetDescription() { return description; }
        public string GetPhone() { return phone; }
        public string GetEmail() { return email; }

    }
}
