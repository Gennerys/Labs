using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_Papirnyk
{
	class Randomizer
	{
		const int RandomBorder = 100;
		public IList<int> Randomize(IList<int> nums, int numberOfElements)
		{
			nums = new List<int>();
			Random random = new Random();

			for (int i = 0; i < numberOfElements; i++)
			{
				nums.Add(random.Next(RandomBorder));
			}

			return nums;
		}
	}
}
