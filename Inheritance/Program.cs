using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            
            string[] pterodactylTaxonomy = new string[]
            {
                "Animalia", "Chordata", "Sauropsida", "Pterosauria", "Pterodactylidae", "Pterodactylus",
                "antiquus"
            };
            Bird pterodactyl = new Bird()
            {
                CommonName = "Pterodactyl", ScientificName = "Pterodactylus antiquus",
                TaxonomyRank = pterodactylTaxonomy, Extinct = true, Hatching = "precocial", Nest = "burial",
                Flight = "soar & dive", WingspanInches = 60
            };

            string[] greenTreeSkinkTaxonomy = new string[]
            {
                "Animalia", "Chordata", "Reptilia", "Ssquamata", "Scincidae", "Prasinohaema",
                "scurrula"
            };
            Reptile greenTreeSkink = new Reptile()
            {
                CommonName = "Green Tree Skink", ScientificName = "Prasinohaema scurrula",
                TaxonomyRank = greenTreeSkinkTaxonomy, Extinct = false, Scale = "cycloid", VenomousPoisonous = false,
                BloodColor = "vivid green", FairytaleMythology = false
            };
            
            JournalOfCharles journalLoneInstance = new JournalOfCharles();
            journalLoneInstance.birds.Add(pterodactyl);
            journalLoneInstance.reptiles.Add(greenTreeSkink);
            journalLoneInstance.SecretsOfEden();
        }
    }
}
