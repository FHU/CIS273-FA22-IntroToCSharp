using System;
namespace IntroToCSharp
{
	public class Animal
	{
		private int numberOfLegs;
		public int NumberOfLegs {
			get
			{
				Console.WriteLine("getting num legs");
				return numberOfLegs;
			}
			set
			{
				if( value >= 0)
				{
					numberOfLegs = value;
				}
				else
				{
					numberOfLegs = 0;
				}
			}
		}

		public string Species { get; set; }
		public double Weight { get; set; }
		public double Speed {
			get
			{
				return Weight / 3;
			}
		}

		private string genotype;

        public Animal(string species, int numLegs)
        {
			Species = species;
			NumberOfLegs = numLegs;
			genotype = "ATCG";
        }


        public void Move()
		{
			Console.WriteLine($"I'm an animal, and I'm moving at {this.Speed} mph.");
		}

		public void Vocalize()
		{
            Console.WriteLine("I'm an animal, and I'm vocalizing.");
        }
    }
}

