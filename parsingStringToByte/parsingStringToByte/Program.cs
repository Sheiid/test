using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// program should convert the string in to bytes 02423FXX ------> 0x02 0x42
namespace parsingStringToByte
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string: ");
            String str = Console.ReadLine(); //02423FXXYY
            byte[] buff = new byte[str.Length/2];


            for (int i = 0; i < str.Length; i += 2)
            {

                String token = str.Substring(i, 2);
                //Console.WriteLine(token);

               buff[i/2] = Convert.ToByte(token, 16);
               Console.WriteLine("0x{0:X2} ", buff[i/2]);
              
               


            }


        }


    }
}