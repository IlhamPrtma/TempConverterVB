namespace RefTugasMod8
{
    public class Converter
    {
        // Celcius ke Reamur
        public double cToR(double c)
        {
            return (int)(c * 4 / 5.0 * 100) / 100.0;
        }

        // Celcius ke Fahrenheit
        public double cToF(double c)
        {
            return (int)((c * 9 / 5.0 + 32) * 100) / 100.0;
        }

        // Celcius ke Kelvin
        public double cToK(double c)
        {
            return (int)((c + 273.15) * 100) / 100.0;
        }

        // Reamur ke Celcius
        public double rToC(double r)
        {
            return (int)(r * 5 / 4.0 * 100) / 100.0;
        }

        // Reamur ke Fahrenheit
        public double rToF(double r)
        {
            return (int)((r * 9 / 4.0 + 32) * 100) / 100.0;
        }

        // Reamur ke Kelvin
        public double rToK(double r)
        {
            return (int)((r * 5 / 4.0 + 273.15) * 100) / 100.0;
        }

        // Fahrenheit ke Celcius
        public double fToC(double f)
        {
            return (int)((f - 32) * 5 / 9.0 * 100) / 100.0;
        }

        // Fahrenheit ke Reamur
        public double fToR(double f)
        {
            return (int)(((f - 32) * 5 / 9.0) * 4 * 100) / 100.0;
        }

        // Fahrenheit ke Kelvin
        public double fToK(double f)
        {
            return (int)(((f - 32) * 5 / 9.0 + 273.15) * 100) / 100.0;
        }

        // Kelvin ke Celcius
        public double kToC(double k)
        {
            return (int)((k - 273.15) * 100) / 100.0;
        }

        // Kelvin ke Reamur
        public double kToR(double k)
        {
            return (int)(((k - 273.15) * 4 / 5.0) * 100) / 100.0;
        }

        // Kelvin ke Fahrenheit
        public double kToF(double k)
        {
            return (int)(((k - 273.15) * 9 / 5.0 + 32) * 100) / 100.0;
        }

        // Celcius ke Celcius
        public double cToC(double c)
        {
            return c;
        }

        // Fahrenheit ke Fahrenheit
        public double fToF(double f)
        {
            return f;
        }

        // Reamur ke Reamur
        public double rToR(double r)
        {
            return r;
        }

        // Kelvin ke Kelvin
        public double kToK(double k)
        {
            return k;
        }
    }
}
