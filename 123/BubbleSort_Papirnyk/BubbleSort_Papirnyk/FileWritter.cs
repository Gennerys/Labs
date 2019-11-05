using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_Papirnyk
{
	class FileWritter
	{
		public void WriteToFile(string path,long elapsedTime, int arrayLength)
		{
			//string writePath = @"C:\SomeDir\hta.txt";

			try
			{
				using (StreamWriter sw = new StreamWriter(path,true))
				{
					sw.WriteLine(arrayLength + " " + elapsedTime);
					
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}

