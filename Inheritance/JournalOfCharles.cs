using System;
using System.Collections.Generic;
namespace Inheritance;

public class JournalOfCharles
{

    public List<Bird> fowlOfTheSky = new List<Bird>();
    public List<Reptile> beastOfTheEarth  = new List<Reptile>();
    public void SecretsOfEden()
    {
        foreach (Bird fowl in fowlOfTheSky)
        {
            Console.WriteLine($"Common Name: {fowl.CommonName}\nScientificName: {fowl.ScientificName}\nExtinct: {fowl.Extinct}\nHatching {fowl.Hatching}\nNest {fowl.Nest}\nFlight {fowl.Flight}\nWingspan in inches: {fowl.WingspanInches}\nTaxonomyRank:");
            foreach (string rank in fowl.TaxonomyRank)
            {
                Console.WriteLine(rank);
            }
        }

        foreach (Reptile beast in beastOfTheEarth)
        {
            Console.WriteLine($"Common Name: {beast.CommonName}\nScientificName: {beast.ScientificName}\nExtinct: {beast.Extinct}\nScale: {beast.Scale}\nVenomous or Poisonous: {beast.VenomousPoisonous}\nBlood Color: {beast.BloodColor}\nCreature of Fairytale or Mythology: {beast.FairytaleMythology}\nTaxonomyRank:");
            foreach (string rank in beast.TaxonomyRank)
            {
                Console.WriteLine(rank);
            }
        }
    }
}