using Qiik.ExerciseCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Qiik.ExerciseService
{
    /// <summary>
    /// Handles reserverd words.
    /// </summary>
    public class ReversedWord: IBaseService
    {

        /// <summary>
        /// Make words reversed or upside down.
        /// </summary>
        /// <param name="input">Word to reverse.</param>
        /// <returns>Reversed word.</returns>
        public string GetResult(string input)
        {
            input = input.Trim();
            StringBuilder builder = new();
            for (var i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();
        }
    }
}
