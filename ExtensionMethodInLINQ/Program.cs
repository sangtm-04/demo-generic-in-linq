using System;
using System.Collections.Generic;

public static class ListExt
{
	public static T randomElement<T>(this List<T> list)
	{
		Random ran = new Random();
		int randomIndex = ran.Next(list.Count - 1);
		return list[randomIndex];
	}
}

public class Program
{
	public static void Main()
	{
		List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };
		List<double> doubleList = new List<double> { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6 };

		// Sử dụng method generic
		var randomInt = getRandomElement(intList);
		var randomDouble = getRandomElement(doubleList);
		Console.WriteLine(randomInt);
		Console.WriteLine(randomDouble);

		// Extension method
		Console.WriteLine(intList.randomElement());
		Console.WriteLine(doubleList.randomElement());
	}

	public static T getRandomElement<T>(List<T> list)
	{
		Random ran = new Random();
		int randomIndex = ran.Next(list.Count - 1);
		return list[randomIndex];
	}
}