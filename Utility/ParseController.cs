namespace Booking.Utility
{
    public static class ParseController
    {

        public static int ParseToInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                throw new FormatException($"No se puede convertir ' {input} ' en un entero.");
            }
        }

        public static decimal ParseToDecimal(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch (FormatException)
            {
                throw new FormatException($"No se puede convertir ' {input} ' en decimal");
            }
        }

        public static DateOnly ParseToDateOnly(DateTime input)
        {
            try
            {
                return DateOnly.FromDateTime(input);
            }
            catch
            {
                throw new FormatException($"Cannot parse ' {input} ' into DateOnly");
            }
        }

    }
}
