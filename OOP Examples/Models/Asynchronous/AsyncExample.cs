using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Examples.Models.Asynchronous
{
	internal class AsyncExample
	{
        public AsyncExample()
        {
			TryMe();
			Console.WriteLine("Ben daha sonra çalışacağım.");
        }

		public async void TryMe()
		{
			await Task.Delay(TimeSpan.FromSeconds(3));
			Console.WriteLine("Ben de çalıştım.");
		}
    }

	internal class AnotherExample
	{
        public AnotherExample()
        {
			Console.WriteLine("Asıl metodumuz çalışıyor");

			TrySomething();

			Console.WriteLine("Asıl metodumuz bitti");
        }

		public async static void TrySomething()
		{
			Console.WriteLine("Bir şeyler oluyor...");

			Waiter();

			Console.WriteLine("İşlem gerçekleşti.");
		}

		private static async Task Waiter()
		{
			await Task.Delay(TimeSpan.FromSeconds(5));
			Console.WriteLine("İşlemler sürüyor...");
		}
    }

	public static class AsyncRunner
	{
		public static void RunExample()
		{
			//AsyncExample example = new AsyncExample();

			AnotherExample example2 = new AnotherExample();

			Console.ReadKey();
		}
	}
}
