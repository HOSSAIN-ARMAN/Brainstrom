using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brainstorm.Models
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int ReorderLevel { get; set; }
        public DateTime Expdate { get; set; }
        public int OpeningBalance { get; set; }
        public int In { get; set; }
        public int Out { get; set; }
        public int ClosingBalance { get; set; }
    }
}