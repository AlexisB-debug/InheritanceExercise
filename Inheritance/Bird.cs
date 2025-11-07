using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        CommonName = "";
        ScientificName = "";
        TaxonomyRank = [];
        Extinct = true;
    }
    public string Hatching { get; set; } // "altricial" or "precocial"
    public string Nest { get; set; } // "scrape nest", "cup nests", "cavity nests", "platform nest", "mound nest", "hanging or pendant nest", "holding eggs at feet"
    public string Flight { get; set; } // "flapping", "soaring", "gliding", "undulating flight", "high-speed flight", "hovering", & "diving"
    public int WingspanInches { get; set; }
    
    public List<Bird> birds = new List<Bird>();

    public void SecretsOfEden()
    {
        foreach (Bird bird in birds)
        {
            Console.WriteLine($"Common Name: {CommonName}\nScientificName: {ScientificName}\nExtinct: {Extinct}\nHatching: {Hatching}\nNest: {Nest}\nFlight: {Flight}\nWingspan in inches: {WingspanInches}\nTaxonomyRank:");
            foreach (string rank in TaxonomyRank)
            {
                Console.WriteLine(rank);
            }
        }
    }
}