using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Encrypter {
    public interface IEncrypter {
        byte[] CreateDBPassword(byte[] unsaltedPassword);

        string Decrypt(string cipherText);

        string Encrypt(string planText);
    }
}
