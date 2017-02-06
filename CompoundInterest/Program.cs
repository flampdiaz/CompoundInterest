using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal capital, rate, fee, interestPayment, principalAmortization, accumulatedAmortization = 0;
            int time;

            int prueba = 2 ^ 4;
            Console.WriteLine(prueba);
            Console.SetWindowSize(Console.WindowWidth, 60);
            Console.Title = "Interes compuesto - Flampeyeiry Diaz [2015-2772]";

            capital = CaptureValue("capital");
            rate = CaptureValue("Taza de interes");
            time = (int)CaptureValue("Plazo");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Periodos pagos \t| Cuota \t| Pagos de interes \t| Amort principal \t| Amort acumulada \t| Capital pendiente");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t| {0:C}", capital);

            rate /= 1200;
            time *= 12;
            fee = capital * (rate / (decimal)(1 - Math.Pow(1 + (double)rate, -time)));

            for (int i = 0; i < time; i++)
            {
                interestPayment = capital * rate;

                principalAmortization = fee - interestPayment;
                accumulatedAmortization += principalAmortization;
                capital -= principalAmortization;

                Console.WriteLine("{0} \t\t| {1:C} \t| {2:C} \t\t| {3:C} \t\t| {4:C} \t\t| {5:C}", i + 1, fee, interestPayment, principalAmortization, accumulatedAmortization, capital);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCreado por Flampeyeiry Jeinix Jampyer Diaz Montero [2015-2772]");
            Console.ReadLine();
        }

        /// <summary>
        /// this method is for read console and set color to the text
        /// </summary>
        /// <param name="text">this is the parameter for into a text to show on the console for indicate to user that value need enter</param>
        /// <returns>return a decimal value</returns>
        private static decimal CaptureValue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Cyan;
            return Convert.ToDecimal(Console.ReadLine());
        }
    }
}
