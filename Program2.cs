using System;

namespace gyif
{
    class Program
    {
        public static void Main()
        {
            double a=10, b=7, c=2;
	        Console.WriteLine("10 upphöjt till 7: "+ Power(ref a,ref b));
	        Console.WriteLine("2 upphöjt till 10: "+ aPower(ref c,ref a));
        }

	
	    public static double Power(ref double a, ref double b) {
        return Math.Pow(a, b);
           
        }
        public static double aPower(ref double c, ref double b) {
        return Math.Pow(c, b);
        }
    }
}
