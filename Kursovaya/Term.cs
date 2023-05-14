using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    internal class Term
    {
        public string Name { get; set; }
        public string Definition { get; set; }
        public List<string> RelatedTerms { get; set; }

        public Term()
        {
            RelatedTerms = new List<string>();
        }
    }
}
