namespace Qiik.ExerciseCore
{
    public class RequestParameter
    {
        /// <summary>
        /// Input string value for current parameter.
        /// </summary>
        public string Value { get; set; }
    }

    public class TriangleRequestParameter
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
    }
}