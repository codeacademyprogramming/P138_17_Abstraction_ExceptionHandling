using System;
using System.ComponentModel.DataAnnotations;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abbas", "Hikmet", null };


            int num;
            string numStr;
            do
            {
                Console.WriteLine("Ededi daxil edin:");
                numStr = Console.ReadLine();

            } while (!int.TryParse(numStr, out num));
           


            Console.WriteLine(num);


            try
            {
                Console.Write("num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("num2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                var result = num1 / num2;
                Console.WriteLine($"result={result}");
            }
            catch (DivideByZeroException ex)
            {
                //NullReferenceException;
                //DivideByZeroException;
                //IndexOutOfRangeException;
                //StackOverflowException;
                //FormatException;
                    
                Console.WriteLine("Siz 0-a bolme ede bilmezsiniz");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yazdiginiz yazi eded formatinda olmalidir!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi");
            }





            //Console.WriteLine("Ededi daxil edin:");
            //string numStr = Console.ReadLine();
            //byte num = Convert.ToByte(numStr);

            //Console.WriteLine(names[0].Length);
            //Console.WriteLine(names[1].Length);
            //Console.WriteLine(names[2].Length);
            //Console.WriteLine(names[3].Length);

            Console.WriteLine("Layihe davam edir");
            Console.WriteLine("Layihe davam edir");
            Console.WriteLine("Layihe davam edir");

        }

        static bool ConvertInt(string numStr,out int num)
        {
            try
            {
                num = Convert.ToInt32(numStr);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }
    }
}
