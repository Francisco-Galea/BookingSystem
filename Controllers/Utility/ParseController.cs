namespace Booking.Controllers.Utility
{
    public class ParseController
    {

        public int ParseToInt(string input)
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

        public decimal ParseToDecimal(string input)
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

    }
}
