using System;

class BaiTap2
{
	public static void Main()
	{
		//Viết chương trình yêu cầu người dùng nhập vào số nguyên N, tìm các số nguyên tố trong khoảng từ 2 đến N,
		//hiển thị ra màn hình các số nguyên tố vừa tìm được cùng với tổng của chúng.
		//Biết răng chương trình sẽ dừng khi người dùng bấm nút ESC.
		//Sử dụng ConsoleKeyInfo được hỗ trợ sẵn trong C# để kiểm tra nút bấm có phải là nút ESC (Escape).

		Console.Write("Moi ban nhap vao so nguyen N:  ");
		int SoN = int.Parse(Console.ReadLine());

		int i = 2;
		bool soNguyento = true;

		if (SoN < 2)
		{
			soNguyento = false;

			Console.WriteLine("Khong phai so nguyen to");

		}

		while(i<SoN)
		{

		}

		Console.ReadKey();


		ConsoleKeyInfo cki;
		// Prevent example from ending if CTL+C is pressed.
		Console.TreatControlCAsInput = true;

		Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
		Console.WriteLine("Press the Escape (Esc) key to quit: \n");
		do
		{
			cki = Console.ReadKey();
			Console.Write(" --- You pressed ");
			if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
			if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
			if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
			Console.WriteLine(cki.Key.ToString());
		} while (cki.Key != ConsoleKey.Escape);
	}
}
// This example displays output similar to the following:
//       Press any combination of CTL, ALT, and SHIFT, and a console key.
//       Press the Escape (Esc) key to quit:
//
//       a --- You pressed A
//       k --- You pressed ALT+K
//       ► --- You pressed CTL+P
//         --- You pressed RightArrow
//       R --- You pressed SHIFT+R
//                --- You pressed CTL+I
//       j --- You pressed ALT+J
//       O --- You pressed SHIFT+O
//       § --- You pressed CTL+U