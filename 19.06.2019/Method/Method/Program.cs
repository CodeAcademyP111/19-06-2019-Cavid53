using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Try Catch Finally
            //Console.WriteLine("Eded daxil edin:");
            //string a = Console.ReadLine();


            //try
            //{
            //    int b = int.Parse(a);
            //    Console.WriteLine("Bu string chevrildi: " + b);
            //}
            //catch
            //{

            //    Console.WriteLine("String integer-e chevrile bilmez !!!");
            //}
            //finally
            //{
            //    Console.WriteLine("Salam");
            //}
            #endregion

            //SumWord("Salam", 7);
            //int result=Sum(7,6);
            //Console.WriteLine(result);
            //Console.WriteLine(Calc(6,5,'*'));
            //char[] letters = { 'a', 'b', 'c',' ' };
            //byte[] intg = { 5};
            //SumWord(new string[] {"Cavide","Esq","Olsun" });

            SumWord("Cavide","Esq","Olsun");
        }

        // overloading
        static void SumWord(string word1, int word2)
        {
            //string result = $"Sozlerin birlesgmesi: - {word1} {word2}";
            string result = "Sozlerin birlesgmesi: - " + word1 + word2;
            Console.WriteLine(result);
        }

        static void SumWord(string word1, string word2)
        {
            Console.WriteLine("2 strinli method: "+word1 + word2);
        }

        static void SumWord(params string[] arr)
        {
            string result = "";
            foreach (var a in arr)
            {
                if (a != arr[0])
                {
                    result += " " + a;
                }
                else
                {
                    result += a;
                }
                
            }
            Console.WriteLine(result);
        }

        #region Optional parms,summary comment

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1">X1 birinci alacagimiz deyerdir</param>
        /// <param name="x2">X2 ikinci alacagimiz deyerdir</param>
        /// <param name="oper">operatorlardir.Switch bunu yoxlayir</param>
        /// <returns></returns>
        //static int Calc(int x1, int x2, char oper='-')
        //{
        //    switch (oper)
        //    {
        //        case '+':
        //            return x1 + x2;
        //            break;
        //        case '-':
        //            return x1 - x2;
        //            break;
        //        case '*':
        //            return x1 * x2;
        //            break;
        //        case '/':
        //            return x1 / x2;
        //            break;
        //        default:
        //            throw new ArgumentException("Duzgun operator daxil etmemisiniz");
        //            break;
        //    }
        //}

        //static int Sum(int number1, int number2)
        //{
        //    if (number1>5)
        //    {
        //        return number1 + number2;
        //    }
        //    return number2;

        //}

        //static int Sum(int n1, int n2) => n1 + n2;
        #endregion





    }
}
