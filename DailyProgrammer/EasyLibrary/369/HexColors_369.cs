namespace EasyLibrary.Challenge369
{
    using System.Globalization;
    using System.Diagnostics;
    using System;

    public class HexColors_369
    {
        /// <summary>
        /// Given three integers between 0 and 255, corresponding to the red, green, and blue channel values of a color, find the hex string for that color. 
        /// You may use anything built into your programming language, such as for base conversion, but you can also do it manually.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static string ConvertToHex(byte red, byte green, byte blue)
        {
            return $"#{red.ToString("X2")}{green.ToString("X2")}{blue.ToString("X2")}";
        }

        /// <summary>
        /// Given a list of hex color strings, produce the hex color string you get from averaging their RGB values together. 
        /// You'll need to round channel values to integers.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public static string Blend(params string[] colors)
        {
            int added = 0;

            float? red = null;
            float? green = null;
            float? blue = null;

            foreach (string color in colors)
            {
                var parts = ConvertFromHex(color);
                red = CalculateAverage(red, parts.Item1, added);
                green = CalculateAverage(green, parts.Item2, added);
                blue = CalculateAverage(blue, parts.Item3, added);

                added += 1;
            }

            if (added > 0)
            {
                return ConvertToHex((byte)Math.Round(red.Value), (byte)Math.Round(green.Value), (byte)Math.Round(blue.Value));
            }

            return null;
        }

        private static float? CalculateAverage(float? runningValue, float newValue, int added)
        {
            if (runningValue == null)
            {
                return newValue;
            }

            return (runningValue * added) / (added + 1) + newValue / (added + 1);
        }

        private static (byte, byte, byte) ConvertFromHex(string color)
        {
            Debug.Assert(color.Length == 7);
            return (
                        byte.Parse(color.Substring(1, 2), NumberStyles.HexNumber),
                        byte.Parse(color.Substring(3, 2), NumberStyles.HexNumber),
                        byte.Parse(color.Substring(5, 2), NumberStyles.HexNumber));
        }
    }
}