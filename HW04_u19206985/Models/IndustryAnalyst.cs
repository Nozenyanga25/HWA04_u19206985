using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19206985.Models
{
    public class IndustryAnalyst : Jobs
    {
        private string _TimeFrame;
        private string _Summary;
        private string _Reporting;
        private string _Duration;

        public IndustryAnalyst(string name, string location, string timeframe, string summary, string reporting, string duration) : base(name, location)
        {
            _TimeFrame = timeframe;
            _Summary = summary;
            _Reporting = reporting;
            _Duration = duration;
        }

        public string TimeFrame
        {
            get { return _TimeFrame; }
            set { _TimeFrame = value; }
        }

        public string Summary
        {
            get { return _Summary; }
            set { _Summary = value; }
        }

        public string Reporting
        {
            get { return _Reporting; }
            set { _Reporting = value; }
        }

        public string Duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

        public override string GetPosition()
        {
            return base.GetPosition() + " Position Open";
        }

        public override string Geo()
        {

            return "Position preferably based in Belgium, open to remote telework";
        }
    }
}