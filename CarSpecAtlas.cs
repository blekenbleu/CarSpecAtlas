
using System.Security.Cryptography.X509Certificates;

namespace blekenbleu
{
    public class CarSpecAtlas
    {
        public string Version = "0.2";
        public Dictionary<string, List<CarSpec>> AtlasDict;

        public CarSpecAtlas()
        {
            AtlasDict = new()
            {
				{						// first game list
					"game1", new () {	// first CarSpec
						new() {								
   		             		id = "fe",
   		             		cyl = 2
   	            		}
					}
				},
				{						// next game list
					"game2", new () {
						new() {
   		             		id = "fi",
   		             		cyl = 4
   	            		},
						new() {
   		             		id = "fo",
   		             		cyl = 8,
							idlerpm = 700
   	            		}
					}
				}
            };							// AtlasDict
        }

        public Dictionary<string, List<CarSpec>> Atlas()
        {
			return AtlasDict;
		}
    }

}
