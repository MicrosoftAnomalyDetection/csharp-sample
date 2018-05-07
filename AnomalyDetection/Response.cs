using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnomalyDetection
{
    public class Response
    {
        public double? Period { get; set; }
        public string WarningText { get; set; }
        public List<double> ExpectedValue { get; set; }
        public List<double> UpperMargin { get; set; }
        public List<double> LowerMargin { get; set; }
        public List<bool> IsAnomaly { get; set; }
        public List<bool> IsAnomaly_Neg { get; set; }
        public List<bool> IsAnomaly_Pos { get; set; }
    }
}