using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19206985.Models
{
    public class SeniorManager : Jobs
    {
        private string _Contract;
        private string _StartingDate;
        private string _Package;
        private string _Position;

        public SeniorManager(string name, string location, string contract, string startingdate, string package, string position) : base(name, location)
        {
            _Contract = contract;
            _StartingDate = startingdate;
            _Package = package;
            _Position = position;
        }


        public string Contract
        {
            get { return _Contract; }
            set { _Contract = value; }
        }

        public string StartingDate
        {
            get { return _StartingDate; }
            set { _StartingDate = value; }

        }

        public string Package
        {
            get { return _Package; }
            set { _Package = value; }
        }

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public override string GetPosition()
        {
            return base.GetPosition() + " Position Open";
        }

        public override string Geo()
        {
            return "Benelux or UK, or remote";
        }
    }
}