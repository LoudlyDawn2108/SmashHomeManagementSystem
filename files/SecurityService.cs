using System;
using System.Security.Cryptography;
using System.Text;

namespace SmartHomeManagementSystem
{
    public class SecurityService
    {
        public string EncryptData(string data, string key)
        {
            // Encrypt data using the key
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }

        public string DecryptData(string encryptedData, string key)
        {
            // Decrypt data using the key
            return Encoding.UTF8.GetString(Convert.FromBase64String(encryptedData));
        }

        public bool ValidateUser(string username, string password)
        {
            // Validate user credentials
            return true;
        }
    }
}