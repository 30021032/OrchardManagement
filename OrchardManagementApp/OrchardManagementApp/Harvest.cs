using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardManagementApp
{
    class Harvest
    {
        public int HarvestID { get; set; }
        public int SectionID { get; set; }
        public int Kg_Harvested { get; set; }
        public string Date { get; set; }
        public double PriceKg { get; set; }
        public double TotalIncome { get; set; }
        public string Comment { get; set; }

        public Harvest(int id, int kgharvested, string date, double pricekg, double totalincome, string comment)
        {
            HarvestID = id;
            Kg_Harvested = kgharvested;
            Date = date;
            PriceKg = pricekg;
            TotalIncome = totalincome;
            Comment = comment;
        }

        public Harvest()
        {
            //empty constructer
        }
    }
}
