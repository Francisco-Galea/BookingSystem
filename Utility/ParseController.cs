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
                throw new FormatException($"Cannot parse '{input}' into int.");
            }
        }

        public static decimal ParseToDecimal(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("No se puede convertir un valor vacio en decimal");
            }
            catch (FormatException)
            {
                throw new FormatException($"Cannot parse '{input}' into decimal");
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
                throw new FormatException($"Cannot parse '{input}' into DateOnly");
            }
        }

    }
}
