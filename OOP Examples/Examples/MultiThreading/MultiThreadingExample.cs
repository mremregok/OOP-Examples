using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Examples.Models.Generic;

namespace OOP_Examples.Examples.MultiThreading
{
	internal class BadExample
	{
		private object _lockObj;
		public Person person;
		public BadExample()
		{
			person = new Person();

			Thread t = new Thread(() => SetPerson("Emre", "Gök"));
			Thread t1 = new Thread(() => SetPerson("Umut", "Akter"));
			Thread t2 = new Thread(() => SetPerson("Cihan", "Dürmüş"));
			t.Start();
			t1.Start();
			t2.Start();
		}

		public void SetPerson(string name, string surname)
		{
			_lockObj = new object();

			Random rand = new Random();
			
			lock (_lockObj)
			{
				person.Name = name;
				Thread.Sleep(rand.Next(100, 500));
				person.Surname = surname;

				Console.WriteLine($"İsim: {person.Name} Soyisim: {person.Surname}");
			}
		}
	}

	internal class GoodExample
	{
		public object _lockObj = new object();
		public Person person;
		public GoodExample()
		{
			person = new Person();

			Thread t = new Thread(() => SetPerson("Emre", "Gök"));
			Thread t1 = new Thread(() => SetPerson("Umut", "Akter"));
			Thread t2 = new Thread(() => SetPerson("Cihan", "Dürmüş"));
			t.Start();
			t1.Start();
			t2.Start();
		}

		public void SetPerson(string name, string surname)
		{

			Random rand = new Random();

			lock (_lockObj)
			{
				person.Name = name;
				Thread.Sleep(rand.Next(100, 500));
				person.Surname = surname;

				Console.WriteLine($"İsim: {person.Name} Soyisim: {person.Surname}");
			}
		}
	}

	public static class MultiThreadingRunner
	{
		public static void RunExample()
		{
			while (true)
			{
				//BadExample badExample = new BadExample();
				GoodExample goodExample = new GoodExample();

				Console.WriteLine("Bitirmek için y tuşuna basınız.");
				if (Console.ReadKey().KeyChar == 'y')
					break;
				Console.Clear();
			}
		}
	}
}
