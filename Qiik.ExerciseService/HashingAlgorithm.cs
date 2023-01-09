using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Newtonsoft.Json;
using Qiik.ExerciseCore;
using SharpHash.Base;
using SharpHash.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Qiik.ExerciseService
{
    /// <summary>
    /// Handles hasing algorithm. It is including MD5, SHA
    /// </summary>
    public class HashingAlgorithm: IBaseService
    {
        /// <summary>
        /// Gets hashed string from the given input.
        /// </summary>
        /// <param name="input">Input string to hash.</param>
        /// <returns>Hashed string with various types.</returns>
        public string GetResult(string input)
        {
            var d = new List<HashingAlgorithmResult>();

            d.Add(new ("SHA-1", HashFactory.Crypto.CreateSHA1().ComputeString(input, Encoding.UTF8)));
            d.Add(new ("SHA-224", HashFactory.Crypto.CreateSHA3_224().ComputeString(input, Encoding.UTF8)));
            d.Add(new("SHA-256", HashFactory.Crypto.CreateSHA3_256().ComputeString(input, Encoding.UTF8)));
            d.Add(new("SHA-384", HashFactory.Crypto.CreateSHA3_384().ComputeString(input, Encoding.UTF8)));
            d.Add(new("SHA-512", HashFactory.Crypto.CreateSHA3_512().ComputeString(input, Encoding.UTF8)));
            d.Add(new("MD5", HashFactory.Crypto.CreateMD5().ComputeString(input, Encoding.UTF8)));
            d.Add(new("RIPEMD", HashFactory.Crypto.CreateRIPEMD().ComputeString(input, Encoding.UTF8)));
            d.Add(new("Keccak-512", HashFactory.Crypto.CreateKeccak_512().ComputeString(input, Encoding.UTF8)));
            d.Add(new("WhirlPool", HashFactory.Crypto.CreateWhirlPool().ComputeString(input, Encoding.UTF8)));
            d.Add(new("Snefru-8-256", HashFactory.Crypto.CreateSnefru_8_256().ComputeString(input, Encoding.UTF8)));

            return JsonConvert.SerializeObject(d);
        }

        public record HashingAlgorithmResult
        {
            public HashingAlgorithmResult(string algo, IHashResult value)
            {
                Algorithm = algo;
                Value = value.ToString().ToLower();
            }

            public string Algorithm { get; }
            public string Value { get; }
        }
    }

     
}
