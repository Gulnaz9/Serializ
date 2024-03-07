
namespace Cowshed
{
    public class Cow
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }
        public Farmer Farmer { get; set; }
        public Shed Shed { get; set; } 
    }
}
