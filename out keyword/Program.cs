using System;

namespace out_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variable
            // without assigning value
            int i;
            int j;
            int k;
            int l;

            // Pass variable i to the method
            // using out keyword
            Addition(out i, out j, out k, out l);

            // Display the value i
            Console.WriteLine("The addition of the value i is: {0}", i);
            Console.WriteLine("The addition of the value j is: {0}", j);
            Console.WriteLine("The addition of the value k is: {0}", k);
            Console.WriteLine("The addition of the value l is: {0}", l);
        }

        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Addition(out int i, out int j,out int k, out int l)
        {
            i = 30;
            j = 50;
            k = 80;
            l = 20;
            i = i+20;
            j = j + 40;
            k = k + 10;
            l = l + 0;
        }
    }
}
