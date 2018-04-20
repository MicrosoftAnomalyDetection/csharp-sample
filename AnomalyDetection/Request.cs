using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnomalyDetection
{
    public class Point
    {
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }
    }

    public class Request
    {
        public List<Point> Points { get; set; }
        public float Period { get; set; }
    }
}
