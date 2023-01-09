using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Qiik.ExerciseService
{
    /// <summary>
    /// Interface for Fibonacci
    /// </summary>
    public interface IFibonacci
    {
        /// <summary>
        /// Calculates the Fibonacci sequence from a given value as the length of the calculation.
        /// </summary>
        /// <param name="length">The length of result to print.</param>
        /// <returns>Fibonacci sequences.</returns>
        string GetResult(int length);
    }

    public class Fibonacci : IFibonacci
    {
        public string GetResult(int length)
        {
            //first number after the next loop
            int first = 0;
            //second number
            int second = 1;
            //the place sum of first and second
            int result = 0;

            StringBuilder builder = new();
            builder.Append($"{first} {second} ");
            for (int i = 2; i < length; i++)
            {
                result = first + second;
                first = second;
                second = result;

                builder.Append($"{result} ");
            }

            return builder.ToString().Trim();
        }
    }
}
