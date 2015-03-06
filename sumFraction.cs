using System;
class sumFraction {
	static void Main() {
		Console.Write("a = ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("b = ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("c = ");
		int c = int.Parse(Console.ReadLine());
		Console.Write("d = ");
		int d = int.Parse(Console.ReadLine());
		a = a * d + b * c;
		b = b * d;
		c = a;
		d = b;
		while (a != 0 && b != 0) {
			if (a != 0)
				b = b % a;
			if (b != 0)
				a = a % b;
		}
		if (c % d == 0)
			Console.WriteLine("z = {0}", c / d);
		else
			Console.WriteLine("z = {0} / {1}", c / (a + b), d / (a + b));
	}
}