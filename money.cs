using System;
class Money {
	static void Main() {
		int money = int.Parse(Console.ReadLine());
		Console.WriteLine(money / 1000);
		money = money % 1000;
		Console.WriteLine(money / 500);
		money = money % 500;
		Console.WriteLine(money / 100);
		money = money % 100;
		Console.WriteLine(money / 50);
		money = money % 50;
		Console.WriteLine(money / 20);
		money = money % 20;
		Console.WriteLine(money / 10);
		money = money % 10;
		Console.WriteLine(money / 5);
		money = money % 5;
		Console.WriteLine(money / 2);
		money = money % 2;
		Console.WriteLine(money / 1);
	}
}
