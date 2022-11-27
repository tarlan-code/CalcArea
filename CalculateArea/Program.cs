

using CalculateArea.Models;
using System.Diagnostics;

bool LoopBool = true;



while (LoopBool)
{
	Console.WriteLine("\n1.Calc. Square area\n2.Calc. Rectangular area\n0.Quit");
	Console.Write("Enter command number: ");
	byte.TryParse(Console.ReadLine(), out byte key);
	switch (key)
	{
		case 0:
			LoopBool = false;
			Console.WriteLine("Quit");
			break;
		case 1:
			while (true)
			{
				Console.Write("Enter square side: ");
				float.TryParse(Console.ReadLine(), out float side);
				if (side<=0)
				{
					Console.WriteLine("Wrong side input! Try again");
				}
				else
				{
					Square square = new(side);
					Console.Write($"Square Area: {square.CalcArea()}\n");
					break;
				}
			}
			break;
		case 2:
			while (true)
			{
				
				Console.Write("Enter rectangular length: ");
				float.TryParse(Console.ReadLine(), out float length);

				if (length <= 0)
				{
					Console.WriteLine("Wrong length input! Try again");
					continue;
				}

				
				Console.Write("Enter rectangular witdh: ");
				float.TryParse(Console.ReadLine(), out float witdh);
				if (witdh<=0)
				{
                    Console.WriteLine("Wrong witdh input! Try again");
					continue;
                }

				Rectangular rectangular = new(length,witdh);	
				Console.WriteLine($"Rectangular Area: {rectangular.CalcArea()}\n");
				break;
			}
            break;
		default:
			Console.WriteLine("Wrong coomand!");
			break;
    }
}
