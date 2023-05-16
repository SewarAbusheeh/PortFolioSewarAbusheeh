using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Models
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectHint { get; set; }
        public string ProjectDescription { get; set; }

        public string ProjectDate { get; set; }
        public string Category { get; set; }
        public string Img { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Client { get; set; }
     

    }
}
