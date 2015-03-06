using System;
class factor {
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		int k = 2;
		while (n > 1) {
			while (n % k == 0 && n > 1) {
				Console.WriteLine(k);
				n = n / k;
			}
			k++;
		}
	}
}
