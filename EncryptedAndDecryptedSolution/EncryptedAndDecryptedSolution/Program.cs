using System;
using EncryptionFeature;

namespace EncryptedAndDecryptedSolution
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string jsonData = "{\"UserExist\":1,\"UserID\":1,\"Active\":1,\"UserName\":\"user1\",\"GroupId\":1,\"GroupType\":\"A\",\"GroupName\":\"Test_xXx\",\"WebMenuId\":0,\"LocationId\":0,\"Currency\":null,\"Credit\":0,\"logintoken\":\"0C1141EE3A0540428019278175038664\",\"PassChanged\":true,\"Country\":null}";

            // Set Secret Key according to your wishes
            string secretKey = Encryption.GenerateRandomKey();

            // Generate a random IV
            byte[] iv = Encryption.GenerateIV();

            // Encrypt data
            string encryptedData = Encryption.Encrypt(jsonData, secretKey, iv);
            Console.WriteLine("Encrypted Data: " + encryptedData);

            // Decrypt
            string decryptedData = Encryption.Decrypt(encryptedData, secretKey, iv);
            Console.WriteLine("Decoded Data: " + decryptedData);
            Console.ReadLine();
        }
    }
}
