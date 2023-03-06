using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRandom
{
	internal class RandomTest
	{
		
		//The slower but better random generator
		public static void Execute(int maxRandom, int randomCount)
		{
			
			for (int i = 0; i < randomCount; i++)
			{
				Console.WriteLine(RandomNumberGenerator.GetInt32(0, maxRandom));
			}
			

		}

		// the faster but not so randomly random generator
		public static void PseudoRandom(int maxRandom, int randomCount)
		{
			Random random = new Random();
			for (int i = 0; i < randomCount; i++)
			{
				Console.WriteLine(random.Next(0, maxRandom));
			}
		}

	}
}
