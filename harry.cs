using System;
class Harry {
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		bool isWhite = false;
		while (n > 0) {
			if (n % 1000 == 711)
				isWhite = true;
			n = n / 10;
		}
		if (isWhite)
			Console.WriteLine("Expelliarmus!");
		else
			Console.WriteLine("Avada Keavra!");

	}
}
