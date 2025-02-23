namespace Booking.Controllers.Utility
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
                MessageBox.Show($"No se puede convertir '{input}' en entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException($"Cannot parse '{input}' into int.");
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
                MessageBox.Show($"No se puede convertir '{input}' en decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"No se puede convertir '{input}' en DateOnly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException($"Cannot parse '{input}' into DateOnly");
            }
        }

    }
}
