using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSortirovkaShivrovanie
{
	class Program
	{
		static void Main(string[] args)
		{
				#region Factoreal
				Console.WriteLine("Задача - вычислить n!");
				Console.WriteLine(" ");
				Console.WriteLine("Введите число для расчета факториала");
				var ff = Console.ReadLine();
				try
				{
					var f = int.Parse(ff);

					if (f == 0)
					{
						Console.WriteLine("Факториал {0}! = {1} ", f, f + 1);
					}
					else
						if (f >= 1)
					{
						Console.WriteLine("Факториал {0}! = {1} ", f, factoreial(f));
					}
					else
					{
						Console.WriteLine("Факториал {0}! нельзя посчитать, т.к. факториал не может быть отрицательным ", f);
					}
				}
				catch
				{
					Console.WriteLine("Для расчета факториала должно быть введено число");
				}
				Console.ReadKey();
				#endregion
			#region Sortirovka
			Console.WriteLine("Задача - Сортировка массива из чисел 1,0,2,1,0,1");
			int[] chisla = { 1, 0, 2, 1, 0, 1 };
			VivodMassivaChisla(chisla);
			Array.Sort(chisla, 0, chisla.Length);
			Console.WriteLine(" ");
			VivodMassivaChisla(chisla);
			Console.ReadKey();
			#endregion
			#region Shifrovanie_Deshifrovka
			// Shifrovanie
			Console.WriteLine("Задача - Зашифровать слов ГАВ с помощью строки АБВГДЕЖ со смещением на key символов");
			Console.WriteLine(" ");
			Console.WriteLine("Введите слово для шифрования");
			Console.WriteLine(" ");
			string slovo = Console.ReadLine();
			Console.WriteLine(" ");
			Console.WriteLine("Введите ключ (смещение по алгоритму Цезаря)");

			string simbol = "АБВГДЕЖ";
			string save = " ";
			string desave = " ";
			// подсчет количества символов разрешенных для использования при шифровании
			int cs = simbol.Length;
			try
			{
				int key = int.Parse(Console.ReadLine());
				//цикл для перебора slovo
				for (int i = 0; i < slovo.Length; i++)
				{
					//цикл для перебора simbol
					for (int j = 0; j < simbol.Length; j++)
					{
						//условие для сравнения введенного слова по буквенно с нашим набором символов для шифрования
						if (slovo[i] == simbol[j])
						{
							int temp = j+key;
							//чтобы temp не уходил за рамки алфавита
							while (temp >= cs)
								temp -= cs;
							//накапливаю зашифрованные ссимволы в слово
							save = save + simbol[temp];
						}
					}
				}
				Console.WriteLine("Зашифрованное слово - {0}", save);
				// Deshifrovka
				//цикл для перебора slovo
				for (int i = 0; i < save.Length; i++)
				{
					//цикл для перебора simbol
					for (int j = 0; j < simbol.Length; j++)
					{
						//условие для сравнения введенного слова по буквенно с нашим набором символов для шифрования
						if (save[i] == simbol[j])
						{
							int detemp = j-key;
							//чтобы detemp не уходил за рамки алфавита
							while (detemp >= cs)
								detemp -= cs;
							//накапливаю зашифрованные ссимволы в слово
							desave = desave + simbol[detemp];
						}
					}
				}
				Console.WriteLine("Расшифрованное слово - {0}", desave);
			}
			catch
			{
				Console.WriteLine("Ключ должен состоять из цифр в промежутке 0 - {0}",simbol.Length);
			}
			Console.ReadKey();
			#endregion
		}
		//функция рассчета факториала
		static int factoreial(int f)
		{
			int n = 1;
			for(int i =1;i<=f;i++)
			{
				n *= i;
			}
			return n;
		}
		//функция для перебора массива из чисел во время сортировки
		static void VivodMassivaChisla(int[] chisla)
		{
			for (int i = 0; i < chisla.Length; i++)
			{
				Console.WriteLine("номер в массиве {0}f = {1}", i, chisla[i]);
			}
		}
	}
}
