
namespace duplicatestring
{
	class Program
	{
	
		static int maxCHAR = 256;
	
	

		static void calculate (string s, int[] cal)
		{
			for (int i=0; i < s.length; i++)
				cal[s[i]]++;
		}

		public static void Main()
		{
			Console.WriteLine("Enter String :- ");
			string s = Console.ReadLine();

			int[] cal = new int [maxCHAR];
			calculate(s,cal);

			for (int i=0; i < maxCHAR; i++)
			{
				if (cal[i] >1)
				{
					Console.Write((char)i);
					Console.WriteLine(" Occurence = "+cal[i]+" Times");
				}
			}
			Console.ReadLine();
	}
}
