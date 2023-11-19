using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////type casting  --> 
            //// implicit -- explicit
            ////when change between value types and it self
            //// each datatype has its own range of values

            //int x = 10;
            //long y = x; //(implicity) 


            ////warning you may lose data 
            //int z = (int)y; // (explicte)

            //// boxing and unboxing 

            //int x = 10;
            //// string is array of character 
            //string s = x.ToString();

            //Console.WriteLine(s[0]);


            //bool flage = false;
            //string sflage = flage.ToString();



            //// tryparse (value, out ...)
            //bool res;
            //int a;
            //string myStr = "12";
            //res = int.TryParse(myStr, out a);
            //Console.WriteLine("String is a numeric representation: " + res);



            //try parse 
            //string value = "9999";
            //int x;
            //bool res = int.TryParse(value, out x);
            //Console.WriteLine(res);


            //String name = null;
            //name = name ?? "na";
            //Console.WriteLine(name);

            //string value = null;
            //Console.WriteLine(value?.ToLower()?? "na");








            

            //// null colasing :
            //Console.WriteLine("-----Null collasing----");
            //string name = "ahmed";
            //name = name ?? "yousef";
            //Console.WriteLine("nnull colasing : "+ name);


            //string name2 = null;
            //name2 = name2 ?? "yousif";
            //Console.WriteLine("null colasing :" +  name2);

            //// null operator 
            //Console.WriteLine("----- null operator=-------");
            //string name3 = "YUOSSIF";
            //Console.WriteLine(name3?.ToLower());


            ////null operator and collasing 

            //Console.WriteLine("----- null operator and collasing-------");
            //string name4 = "YUOSSIF";
            //Console.WriteLine(name4?.ToLower() ?? "NA");


            //Console.WriteLine("-------");
            //string name5 = null;
            //Console.WriteLine(name5?.ToLower()?? "NA");



            // for loop


            int[] arr1 = { 1, 2, 3 ,4,5,6};
            Console.WriteLine(arr1.Length);

            for (int i = 0; i< arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }


            // while loop

            int ii = 0;
            while (ii < arr1.Length)
            {
                Console.WriteLine(arr1[ii]);
                ii++;
            }
            Console.WriteLine(ii);



            // while loop



            while (1 == 2)
            {
                Console.WriteLine(arr1[0]);
            
            }
            do
            {
                Console.WriteLine("hello from while");
            } while (1 == 2);



            // foreach looop


            foreach(int num in arr1)
            {
                Console.WriteLine(num);
            }











        }
    }
}