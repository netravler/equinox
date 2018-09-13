using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace equinox
{
    public class hashem
    {
        private string hashme;
        private byte[] hasharray;
        private string hashed;

        public hashem() { }

        public hashem(string hashme, byte[] hasharray, string hashed)
        {
            this.Hashme = hashme;
            this.Hasharray = hasharray;
            this.Hashed = hashed;
        }

        public string Hashme
        {
            get
            {
                return hashme;
            }
            set 
            {
                hashme = value;
            }
        }

        public byte[] Hasharray
        {
            get
            {
                return hasharray;
            }
            set
            {
                hasharray = value;
            }
        }

        public string Hashed
        {
            get
            {
                return hashed;
            }
            set
            {
                hashed = value;
            }
        }

        public string makeHash(string hashmeplease)
        {
            // this routine also contains an md5 hash routine that can be made into a method:)
            // Create an MD5 hash.

            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(hashmeplease));
            
            // string it all together...!
            int i;
            StringBuilder sOutput = new StringBuilder(hash.Length);
            for (i = 0; i < hash.Length; i++)
            {
                sOutput.Append(hash[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
