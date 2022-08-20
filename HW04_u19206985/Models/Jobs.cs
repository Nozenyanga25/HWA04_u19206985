using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19206985.Models
{
    public abstract class Jobs
    {
        private string _Name;
        private string _Location;
        public Jobs(string name, string location)
        {
            _Name = name;
            _Location = location;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public virtual string GetPosition()
        {
            return Name;
        }

        public abstract string Geo();

    }
}