using System.Collections.Generic;
using T2207A;
using T2207A.Exam;

public class Program
{
    /* public static void Main(string[] args)
     {*/

    /*   Thread t = new Thread(DemoRun); // Tham so la 1 function
       t.IsBackground = true;
       t.Start("Hello");*/
    /*  Console.WriteLine("Hello world"); //print
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
      st.Learn("ABC");
      Console.WriteLine(st.Name);
      st.Name = "Nguyen Van An";

      Human h = new Human(); 
      Human h2 = new Human();

      h.family[0] = "Nguyen Duc Anh";
      Console.WriteLine(h.family[0]);

      h2[0] = "Dao Nhat Tan";

      List<string> strs = new List<string>();
      strs.Add("Hello");
      Console.WriteLine(strs[0]);*/

    //Car c = new Car();// trong C# khong co anonymous class
    /*   }

       private static bool IsPrimed(int n)
       {
           throw new NotImplementedException();
       }

       static void DemoRun(object o) 
       {
           string s = (string)o;
           for(int i = 0; i < 20; i++) 
           {
               Console.WriteLine("i=" +i);
               try 
               {
                   Thread.Sleep(1000);
               }catch(Exception e) 
               {
               }
           }
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


   }*/
    public static void Main(string[] args)
    {
        ListProduct list = new ListProduct();
        int option;
        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        list.AddProduct();
                        break;
                    case 2:
                        list.DisplayProducts();
                        break;
                    case 3:
                        list.DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine();
        } while (option != 4);
    }
}


