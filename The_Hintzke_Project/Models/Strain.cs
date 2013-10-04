using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Hintzke_Project.Models
{
    public class Strain
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double PercentSativa { get; set; }
        public double PercentIndica { get; set; }
        public double PricePerGram { get; set; }
    }
}