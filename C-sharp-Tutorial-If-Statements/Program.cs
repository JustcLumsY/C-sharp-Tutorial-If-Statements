using System;

namespace C_sharp_Tutorial_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMax(9, 10, 40));


            bool isTall = true;
            bool isMale = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            } else
            {
                Console.WriteLine("You are not male or tall");
            }
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
              result = num1;
            }else if (num2 >= num1 && num2 >= num3)
            {
                result=num2;
            } else
            {
                result = num3;
            }



            return result;
        }
    }
}


//static int GetMax(int num1, int num2)
//{
//    int result;
//    if (num1 > num2)
//    {
//        result = num1;
//    }
//    else
//    {
//        result = num2;
//    }



//    return result;
//}