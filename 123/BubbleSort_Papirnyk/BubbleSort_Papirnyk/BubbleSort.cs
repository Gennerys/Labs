using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_Papirnyk
{
	public class BubbleSort
	{
		public IEnumerable<int> BubbleSortAlgorithm(IList<int> nums)
		{
			int temp;
			for (int i = 0; i < nums.Count - 1; i++)
			{
				for (int j = i + 1; j < nums.Count; j++)
				{
					if (nums[i] > nums[j])
					{
						temp = nums[i];
						nums[i] = nums[j];
						nums[j] = temp;
					}
				}
			}
			return nums;
		}
	}
}
