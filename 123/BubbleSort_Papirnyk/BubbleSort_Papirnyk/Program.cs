using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_Papirnyk
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\oleksandr.papirnyk\Desktop\BubbleSort_Papirnyk\BubbleSort_Papirnyk\bin\Debug\results.txt";
			int arrayLength = 20000;
			Randomizer randomizer = new Randomizer();
			List<int> nums =  new List<int>();
			IList<int> arrayToSort = randomizer.Randomize(nums, arrayLength);

			BubbleSort bubbleSorter = new BubbleSort();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			IEnumerable<int> answer = bubbleSorter.BubbleSortAlgorithm(arrayToSort);
			stopwatch.Stop();

			FileWritter fileWritter = new FileWritter();
			fileWritter.WriteToFile(path, stopwatch.ElapsedMilliseconds, arrayLength);
			Console.WriteLine(stopwatch.ElapsedMilliseconds);
			Console.WriteLine("Solution completed");

			Console.ReadKey();
		}
	}
}
