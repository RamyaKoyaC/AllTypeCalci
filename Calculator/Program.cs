using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithematicCalculator
{
    class Calci
    {

        public int Add(int num1, int num2)
        {

            return num1 + num2;
        }
        
        public static int Read()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            Calci c = new Calci();

            int num1 = Read();
            int num2 = Read();

            int sum = c.Add(num1, num2);
            Console.WriteLine(sum);


            
            for (int i = 0; ; i++)
                
            {


                int num = Read();

                int result = c.Add(sum, num);
                sum = result;
                Console.WriteLine(sum);
                
                

                


            }
            

        }

        

            
        
    }
}
