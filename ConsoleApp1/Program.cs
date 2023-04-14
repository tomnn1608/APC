using System.Collections.Generic;
using T2207A;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world"); //print
        int x = 10;
        String s = "T2207A";
        double pi = 3.14159;

        if (x > 5) {
            x--;
        }
        else
        {
            x++;
        }
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 15;
        arr[2] = 9;
        arr[3] = 55;
        arr[4] = -16;
        
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        String cmd = Console.ReadLine();
        Console.WriteLine("Chuoi vua nhap" +cmd);
        String cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        Console.WriteLine("So vua nhap" + n);
        if (IsPrimed(n))
        {
            Console.WriteLine(n + "la so nguyen to");
        }
        List<int> ints = new List<int>();
        ints.Add(4);
        ints.Add(19);

        Student st = new Student();
        //st.Run();
        //st.Learn();
        st.Learn();
        st.Learn();
    }

    private static bool IsPrimed(int n)
    {
        throw new NotImplementedException();
    }

    public static Boolean isPrimed(int n)
    {
        if ( n < 2 ) return false;
        if (n < 4) return true;
        for(int i = 1; i <= n / 2; i++) 
        {
        if(n % i ==0) return false;
        }
        return true;
    }


}