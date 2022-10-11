Console.WriteLine("Enter number ");
string number = Console.ReadLine();
Console.Write("The number entered has ");
Console.Write(number.Length);
Console.WriteLine(" digit(-s).");
if (number.Length < 3)
{
    Console.WriteLine("There are no 3rd digit.");
}
else
{
   int N = int.Parse(number);
   int A = number.Length - 3;
   if (A==0)
   {
        int n = N % 10;
        Console.WriteLine(n);
   }
   else
   {
        int N1 = N/(int)Math.Pow(10,A);
        int N2 = N1 % 10;
        Console.WriteLine(N2);
   }
}