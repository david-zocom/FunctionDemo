using System;

namespace FunctionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Function demo");
			//Introduction();

			//Friends();

			SumArray();

			//RandomArray();

		}

		static void Introduction()
		{
			// function that adds two numbers?
			int x = 12, y = 3;
			int result = Add(x, y);
			Console.WriteLine("The result is: " + result);

			string sentence = BuildSentence("funktioner", "i", "c#", "!");
			Console.WriteLine(sentence);

			ShowGreeting("Karl");
		}

		static void Friends()
		{
			string[] friends = new string[]
						{
				"Mark Hamill", "Tom Cruise", "Sean Connery"
						};
			Console.WriteLine("Mina vänner");
			Console.WriteLine("-----------");
			Console.WriteLine($"Du har {friends.Length} vänner");
			Console.WriteLine("De är:");

			// Man kan använda antingen string eller var när man skapar en variabel
			foreach (var friend in friends)
			{
				Console.WriteLine(friend);
			}

			Console.WriteLine("Vilken vän ska byta namn? (index 0, 1 eller 2)");
			bool notValidIndex = true;
			int friendIndex = -1;
			while (notValidIndex)
			{
				string maybeFriendIndex = Console.ReadLine();
				try
				{
					friendIndex = int.Parse(maybeFriendIndex);
					// TODO: kontollera att friendIndex är ett giltigt index, dvs inom arrayens gränser
					// Vi behöver använda friends.Length

					notValidIndex = false;
					// Ctrl K + D    för att auto-indentera koden
				}
				catch (Exception)
				{
					Console.WriteLine("Det var ingen bra input. Skriv in ett heltal med siffror.");
				}
			}

			Console.WriteLine("Skriv det nya namnet:");
			string newFriendName = Console.ReadLine();
			friends[friendIndex] = newFriendName;



			Console.WriteLine("De är:");
			foreach (var friend in friends)
			{
				Console.WriteLine(friend);
			}
		}

		private static void RandomArray()
		{
			/* 5.3 Skriv ett program som skapar en array med fem heltal, som ska slumpas fram. Programmet ska sedan gå igenom arrayen och skriva ut vilket det största och minsta talet är samt hur många tal som är udda.
			*/
			const int numberOfRandoms = 15;
			int[] slumpadArray = new int[numberOfRandoms];

			// undvik "magic numbers", använd variabler i stället för att upprepa tal
			const int maximum = 20, minimum = 10;
			Random r = new Random();
			for (int i = 0; i < slumpadArray.Length; i++)
			{
				int slumpatTal = r.Next(minimum, maximum);
				slumpadArray[i] = slumpatTal;
			}
			// skriva ut vilket det största och minsta talet är samt hur många tal som är udda.
			Console.WriteLine();
			Console.WriteLine("Slumpad array:");
			int max = minimum, min = maximum;
			foreach (int tal in slumpadArray)
			{
				Console.WriteLine(tal);
				if (tal > max) { max = tal; }
				if (tal < min) { min = tal; }
			}
			Console.WriteLine($"Största värdet är {max} och minsta värdet är {min}.");
		}

		// Används av SumArray
		static int CalculateSum(int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		private static void SumArray()
		{
			/* 5.2 Skriv ett program som räknar ut summan av alla element i arrayen [2, 3, 5, 8, 13, 21, 34].
			Extra utmaning: varannat tal ska adderas och varannat subtraheras. Testa med arrayen [1, 1, 1, 1].
			 */
			// skapa en array
			// loopa och gör en addition i taget
			// kom ihåg värdet hittills - variabel för summan
			int[] numbers = new int[] { 2, 3, 5, 8, 13, 21, 34 };
			int sum = CalculateSum(numbers);
			Console.WriteLine("Summan är: " + sum);

			// 1 - 1 + 1 - 1
			int[] numbers2 = new int[] { 1, 1, 1, 1 };
			int sum2 = 0;
			bool usePlus = true;
			for (int i = 0; i < numbers2.Length; i++)
			{
				// Alternativ lösning: if(i % 2 == 0)
				if (usePlus)
				{
					usePlus = false;
					sum2 += numbers2[i];
				}
				else
				{
					usePlus = true;
					sum2 -= numbers2[i];
				}
			}
			Console.WriteLine("Summan är: " + sum2);
		}

		static int Add(int a, int b)
		{
			Console.WriteLine("inside Add");
			return a + b;
		}

		static string BuildSentence(string a, string b, string c, string d)
		{
			string sentence = $"{a} {b} {c} {d}";
			return sentence;
		}

		static void ShowGreeting(string name)
		{
			Console.WriteLine($"Hello {name}!");
			return;  // return är frivilligt i en VOID funktion
		}
	}
}
