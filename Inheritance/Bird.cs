namespace Inheritance;

public class Bird : Animal
{
    public string Hatching { get; set; } // "altricial" or "precocial"
    public string Nest { get; set; } // "scrape nest", "cup nests", "cavity nests", "platform nest", "mound nest", "hanging or pendant nest", "holding eggs at feet"
    public string Flight { get; set; } //flapping, soaring, and gliding,undulating flight,high-speed flight, hovering, diving
    public int WingspanInches { get; set; }
}