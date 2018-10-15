/*
 * Created by SharpDevelop.
 * User: Артём
 * Date: 01.10.2018
 * Time: 14:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab1nom3
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			// TODO: Implement Functionality Here
			
			Console.WriteLine("Введите максимальное число");
			int max = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите минимальное число");
			int min = Convert.ToInt32(Console.ReadLine());
			int [,] A = new int [10,10];
			Random rnd = new Random();
			for(int i = 0;i<10;i++)
			{
				for(int j=0;j<10;j++)
				{
					A[i,j]  = rnd.Next(min,max);
					Console.Write(A[i,j]+" ");
					
				}
				Console.WriteLine();
				Console.ReadKey();
			}
			}
			
	}
}