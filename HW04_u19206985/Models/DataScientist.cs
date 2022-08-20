using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19206985.Models
{
    public class DataScientist : Jobs
    {
        private string _TimeFrame;

        public DataScientist(string name, string location, string timeframe) : base(name, location)
        {
            _TimeFrame = timeframe;
        }

        public string TimeFrame
        {
            get { return _TimeFrame; }
            set { _TimeFrame = value; }
        }

        public override string GetPosition()
        {
            return base.GetPosition() + " Position Open";
        }

        public override string Geo()
        {
            return "Position based Europe remotely or Office in Brussels";
        }
    }
}