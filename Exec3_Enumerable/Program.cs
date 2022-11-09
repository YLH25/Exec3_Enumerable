using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var items=Enumerable.Range(1, 10).ToList();
			var items1= Enumerable.Range(10, 6).ToList();
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			foreach (var item in items1)
			{
				Console.WriteLine(item);
			}
		}
	}
}
