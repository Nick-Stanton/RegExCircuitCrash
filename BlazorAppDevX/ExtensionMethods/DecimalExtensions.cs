namespace BlazorAppDevX.ExtensionMethods
{
    public static class DecimalExtensions
    {
        // <summary>
        /// Function divides the given number by 1 million. 
        /// </summary>
        /// <param name="valueToConvert"></param>
        /// <returns>The given value divided by Math pow 10,6</returns>
        public static decimal DivideBy1Million(this decimal value)
        {
            return value /= (decimal)Math.Pow(10, 6);
        }

        public static decimal MultiplyBy1Million(this decimal value)
        {
            return value *= (decimal)Math.Pow(10, 6);
        }
    }
}
