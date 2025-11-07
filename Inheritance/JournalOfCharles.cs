using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
namespace Inheritance;

public class JournalOfCharles
{
    public List<Bird> birds = new List<Bird>();
    public List<Reptile> reptiles  = new List<Reptile>();
    
    public void SecretsOfEden()
    {
        foreach (Bird bird in birds)
        {
            Console.WriteLine($"Common Name: {bird.CommonName}\nScientificName: {bird.ScientificName}\nExtinct: {bird.Extinct}\nHatching: {bird.Hatching}\nNest: {bird.Nest}\nFlight: {bird.Flight}\nWingspan in inches: {bird.WingspanInches}\nTaxonomyRank:");
            foreach (string rank in bird.TaxonomyRank)
            {
                Console.WriteLine(rank);
            }
        }

        foreach (Reptile reptile in reptiles)
        {
            Console.WriteLine($"Common Name: {reptile.CommonName}\nScientificName: {reptile.ScientificName}\nExtinct: {reptile.Extinct}\nScale: {reptile.Scale}\nVenomous or Poisonous: {reptile.VenomousPoisonous}\nBlood Color: {reptile.BloodColor}\nCreature of Fairytale or Mythology: {reptile.FairytaleMythology}\nTaxonomyRank:");
            foreach (string rank in reptile.TaxonomyRank)
            {
                Console.WriteLine(rank);
            }
        }
    }
}