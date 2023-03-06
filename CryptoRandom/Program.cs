using CryptoRandom;
using System.Diagnostics;
using System.Security.Cryptography;

internal class Program
{
	private static void Main(string[] args)
	{
		bool repeat = true;
		// Menu for choosing assignment solution

		while (repeat)
		{
			Console.WriteLine("Press 1 for Encrypter and 2 for Random test");
			string menuChoice = Console.ReadLine();



			switch (menuChoice)
			{
				case "1":
					{
						Console.Clear();
						Encrypter encrypter = new Encrypter();

						Console.WriteLine("Please enter your code to encrypt:");
						string textToBeEncrypted = Console.ReadLine();

						if (textToBeEncrypted != null)
						{
							Thread.Sleep(500);
							string encryptedText = encrypter.EncryptToAscii(textToBeEncrypted);

							Console.WriteLine($"Encrypted text: {encryptedText}\n");
							Console.WriteLine("Press a key to decrypt again.\n");
							Console.ReadKey(true);

							string decryptedText = encrypter.DecryptFromAscii(encryptedText);

							Console.WriteLine($"Decrypted text: {decryptedText}\n\n");
						}

						Console.WriteLine("Press a key to return to menu.");
						Console.ReadKey();
						Console.Clear();
						break;
					}
				case "2":
					{
						Console.Clear();
						// Starting the stop watch and calling the better, but slower random method, stopping the watch again
						Stopwatch stopWatch = new Stopwatch();
						stopWatch.Start();
						RandomTest.Execute(10, 10000);
						stopWatch.Stop();
						// Get the elapsed time as a TimeSpan value.
						TimeSpan ts = stopWatch.Elapsed;

						// Starting the stop watch and calling the some what predictable but faster random method, stopping the watch again
						Stopwatch stopWatch2 = new Stopwatch();
						stopWatch2.Start();
						RandomTest.PseudoRandom(10, 10000);
						stopWatch2.Stop();

						TimeSpan ts2 = stopWatch2.Elapsed;

						// Writing out the elapsed time for the two stop watches.

						string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
							ts.Hours, ts.Minutes, ts.Seconds,
							ts.Milliseconds / 10);
						Console.WriteLine($"RunTime {elapsedTime}\n\n");
						elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
							ts2.Hours, ts2.Minutes, ts2.Seconds,
							ts2.Milliseconds / 10);
						Console.WriteLine($"RunTime {elapsedTime}");

						Console.WriteLine("Press a key to return to menu.");
						Console.ReadKey();
						Console.Clear();
						break;
					}

					/* Results:
					1000
					ts = 00:00:00:06
					ts2 = 00:00:00:04

					10.000
					ts = 00:00:00:06
					ts2 = 00:00:00:04

					100.000
					first try
					ts = 0000:04:89
					ts2 = 00:00:04:79
					second try
					ts = 00:00:04:96
					ts2 = 00:00:04:66

					*/
			}

		}


	}
}