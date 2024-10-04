
using System.Security.Cryptography.X509Certificates;

namespace blekenbleu
{
    public class CarSpecAtlas
    {
		public string Version = "0.1";
        public Dictionary<string, List<CarSpec>> AtlasDict;
        public CarSpecAtlas()
        {
            AtlasDict = new();
        }

        public Dictionary<string, List<CarSpec>> Atlas()
            { return AtlasDict; } 
    }

}
