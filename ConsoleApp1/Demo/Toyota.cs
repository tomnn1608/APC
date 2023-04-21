using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T2207A
{
    public class Toyota
    {
        public Toyota() 
        {
            try
            {
                int x = 10;
                int y = 0;
                throw new Exception("Error y = 0");
                int z = x / y;
                Console.WriteLine("z = " + z);
            }catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            finally 
            {
                //luc nao cung chay qua
            }
        }
        public void SpeedUp() 
        {
        }
    }
}
