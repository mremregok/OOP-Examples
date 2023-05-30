using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Examples.Examples.MultiThreading
{
	internal class RaceCondition
	{
		public int result = 0;
		Random rnd = new Random();

        public RaceCondition()
        {
			Thread t = new Thread(() => Work1());
			Thread t1 = new Thread(() => Work2());
			Thread t2 = new Thread(() => Work3());
			t.Start();
			t1.Start();
			t2.Start();
			Thread.Sleep(rnd.Next(10, 50));
			Console.WriteLine(result);
		}
		void Work1(){ Thread.Sleep(rnd.Next(10, 50)); result = 1; }
		void Work2() { Thread.Sleep(rnd.Next(10, 50));  result = 2; }
		void Work3() { Thread.Sleep(rnd.Next(10, 50));  result = 3; }
	}

	public static class RaceConditionRunner
	{
		public static void RunExample()
		{
			while (true)
			{
				for(int i = 0; i < 10; i++)
				{
					RaceCondition example = new RaceCondition();
				}
				

				Console.WriteLine("Bitirmek için y tuşuna basınız.");
				if (Console.ReadKey().KeyChar == 'y')
					break;
				Console.Clear();
			}
		}
	}
}
