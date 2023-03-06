using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRandom
{
	internal class Encrypter
	{

		private byte[] ascii;
		private byte num = 1;

		public string EncryptToAscii(string textToBeEncrypted)
		{

			ascii = Encoding.ASCII.GetBytes(textToBeEncrypted);
			for (int i = 0; i < ascii.Length; i++)
			{
				ascii[i] += num;
			}

			return Encoding.ASCII.GetString(ascii);
		}

		public string DecryptFromAscii(string encryptedText)
		{
			ascii = Encoding.ASCII.GetBytes(encryptedText);

			for (int i = 0; i < ascii.Length; i++)
			{
				ascii[i] -= num;
			}

			return Encoding.ASCII.GetString(ascii);
		}
	}
}
