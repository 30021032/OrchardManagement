using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardManagementApp
{
    class Section
    {
        public int SectionID { get; set; }
        public string Name { get; set; }
        public string TreeType { get; set; }
        public double Size { get; set; }
        public string DatePlanted { get; set; }
        public string Comment { get; set; }

        public Section(int Id, string name, string tree_type, double size, string date)
        {
            SectionID = Id;
            Name = name;
            TreeType = tree_type;
            Size = size;
            DatePlanted = date;
        }

        public Section()
        {
            //empty constructer as well
        }
    }
}
