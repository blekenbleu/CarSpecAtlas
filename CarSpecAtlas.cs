namespace blekenbleu
{
    public partial class CarSpecAtlas
    {
        public string Version = "0.3";
        public Dictionary<string, List<CarSpec>> AtlasDictTest;
        public CarSpecAtlas()
        {
            AtlasDictTest = new()
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
            };							// AtlasDictTest
        }

        public Dictionary<string, List<CarSpec>> Atlas()
        {
			return AtlasDict;
		}
    }
}
