using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Viết chương trình yêu cầu người dùng nhập vào số nguyên N, tính tổng các giai thừa từ 1 đến N và hiển thị kết quả ra màn hình.

			Console.Write("Moi ban nhap vao so nguyen N:  ");
			int SoN = int.Parse(Console.ReadLine());

			int sum = 0;
			int i = 1;

			while (i <= SoN)
			{
				sum += i;
				i++;
			}
			Console.WriteLine("Giai thua so nguyen ban vua nhap la: {0}",sum);
			Console.ReadKey();


			ConsoleKeyInfo NTG;

			Console.TreatControlCAsInput = true;

			Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
			Console.WriteLine("Press the Escape (Esc) key to quit: \n");

			do
			{
				NTG = Console.ReadKey();
				Console.Write("------- You pressed");
				if ((NTG.Modifiers & ConsoleModifiers.Alt)!=0) Console.Write("Alt+");
				Console.WriteLine(NTG.Key.ToString());


			} while (NTG.Key != ConsoleKey.Escape);






		}
	}
}
