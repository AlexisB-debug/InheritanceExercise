using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        CommonName = "";
        ScientificName = "";
        TaxonomyRank = [];
        Extinct = true;
    }
    public string Scale { get; set; } // "cycloid", "granular", "keeled", "rattle"
    public bool VenomousPoisonous { get; set; }
    public string BloodColor { get; set; }
    public bool FairytaleMythology { get; set; }
}