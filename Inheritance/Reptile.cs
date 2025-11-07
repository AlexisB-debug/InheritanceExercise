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
    public string Scale { get; set; } // cycloid, granular, keeled, scutes, ventral, feature, rostral, rattle
    public bool VenomousPoisonous { get; set; }
    public string BloodColor { get; set; }
    public bool FairytaleMythology { get; set; }

    public List<Reptile> reptiles = new List<Reptile>();

    public void SecretsOfEden()
    {
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