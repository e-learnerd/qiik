using Qiik.ExerciseCore;
using System.Text;

namespace Qiik.ExerciseService
{
    /// <summary>
    /// Handles triangle category.
    /// </summary>
    public class TriangleCategory
    {
        /// <summary>
        /// Shows the triangle category.
        /// </summary>
        /// <param name="input">Word to reverse.</param>
        /// <returns>Reversed word.</returns>
        public string GetResult(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide == 0 || secondSide == 0 || thirdSide == 0)
            {
                return "Invalid triagle input";
            }
            else
            {
                if (firstSide == secondSide && secondSide == thirdSide && thirdSide == secondSide)
                {
                    return "Equilateral Triangle";
                }
                else
                {
                    if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
                        return "Isoceles Triangle";
                    else 
                        if (firstSide != secondSide && secondSide != thirdSide && thirdSide != firstSide)
                        return "Scalene Triangle";
                }

                double s, x;
                s = (firstSide + secondSide + thirdSide) / 2.0;
                x = (s * (s - firstSide) * (s - secondSide) * (s - thirdSide));

                double area = Math.Sqrt(x);

                return $"Area: {area}";
            }
        }
    }
}