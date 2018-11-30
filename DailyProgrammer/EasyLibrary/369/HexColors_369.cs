namespace EasyLibrary.Challenge369
{
    public class HexColors_369
    {
        public static string ConvertToHex(int red, int green, int blue)
        {
            return $"#{red.ToString("X2")}{green.ToString("X2")}{blue.ToString("X2")}";
        }
    }
}