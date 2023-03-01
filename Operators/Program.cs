namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = 7;
           int b = 8;
           int c = a + b;
           int d;
           d = a + b + c;
           Console.WriteLine(c);
           Console.WriteLine(d);


           short k = 3;
           short l = 7;
           Console.WriteLine(k + l);

           int m = 679;
           int h = 9;
           float g = m / h;
           Console.WriteLine(g);

           int m1 = 7648;
           int h1 = 57;
           float g1 = m1 / h1;
           Console.WriteLine(g1);

           char myChar1 = 'a';
           char myChar2 = 'b';
           int myChar3 = myChar1 + myChar2;
           Console.WriteLine(myChar3);


           string myString1 = "hello ";
           string myString2 = "world";
           var myString3 = myString1 + myString2;
           Console.WriteLine(myString3);

           string a1 = "hello";
           char b1 = 'U';
           var c1 = a1 + b1;
           Console.WriteLine(c1);

           int a2 = 8;
           int b2 = 30;
           if (a2 >= b2)
           {
               Console.WriteLine("A is the winner");
           }
           else
           {
               Console.WriteLine("B is the winner");
           }
        }
    }
}