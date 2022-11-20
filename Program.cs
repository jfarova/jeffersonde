internal class Program
{
    private static void Main(string[] args)
    {
        int n1;
       Console.WriteLine("digite el primer numero");
       n1=int.Parse(Console.ReadLine());
       
       if(n1% 2 == 0){
        Console.WriteLine("el numero  es par" + n1);


       }
       else{
        Console.WriteLine("el numero  es impar" + n1);
       }
    }
    }
