using System.Security.Principal;

namespace Inheritance;

public class Animal
{
    public string CommonName { get; set; }
    public string ScientificName { get; set; }
    public string[] TaxonomyRank { get; set; }
    // public decimal EncephalizationQuotient { get; set; }
    public bool Extinct { get; set; }
}