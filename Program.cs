using System;

namespace gyif
{
    class Program
    {
        public static void Main() {
	    int a=10, b=20;
	    BytPlats(ref a, ref b);
	    //Här ska a ha värdet 20 och b värdet 10. 
	    Console.WriteLine(a+" "+b);
        }
	
	    public static void BytPlats(ref int a, ref int b) {
            
            int x = a;
            int y = b;
            a = y;
            b = x;
        }
    }
}
