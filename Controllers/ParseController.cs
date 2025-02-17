namespace Boocking.Controllers
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
                throw new FormatException($"No se puede convertir '{input}' en entero.");
            }
        }

        public decimal ParseToDecimal(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch (FormatException )
            {
                throw new FormatException($"No se puede convertir '{input}' en decimal");
            }
        }

    }
}
