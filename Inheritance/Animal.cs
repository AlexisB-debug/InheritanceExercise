using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
namespace Inheritance;

public class Animal
{
    public string CommonName { get; set; }
    public string ScientificName { get; set; }
    public string[] TaxonomyRank { get; set; }
    // public double EncephalizationQuotient { get; set; }
    public bool Extinct { get; set; }
}