using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[10];           
            nhapMang(mang);
            xuatMang(mang);          
            Console.WriteLine("Trong mang co chua 5?"+"\n"+CheckConstain1(mang));
            Console.WriteLine("Trong mang co chua 5 or 6?"+"\n"+CheckConstain2(mang));
            Console.WriteLine("Trong mang co chua 5 and 6?" + "\n" + CheckConstain3(mang));
            Console.WriteLine("Co {0} so 5",CountConstain(mang));
            Console.WriteLine("Co {0} so 5 or 6", CountConstain2(mang));
            Console.WriteLine(CalculateSum(mang));
        }
      public  static void nhapMang(int[] mang)
        {
            Random rand = new Random();
            for (int i = 0; i < mang.Length;i++)
            {      
                mang[i] = rand.Next(1,10);
            }
        }
       public static void xuatMang(int[] mang)
        {
            for(int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("Mang{0}={1}",i,mang[i]);
            }        
        }
        static bool CheckConstain1(int[]mang,int key1 = 5)
        {                     
            for(int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == key1)
                {                
                    return true;                  
                }               
            }           
            return false;
        }
        static bool CheckConstain2(int[] mang,int key1=5,int key2=6)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == key1 || mang[i] == key2)
                {
                    return true;
                }
            }
            return false;
        }
       public static bool CheckConstain3(int[] mang,int key1 = 5,int key2= 6)
        {
            if (CheckConstain1(mang, key1) && CheckConstain1(mang, key2))
                return true;
            return false;

           // return CheckConstain1(mang, key1)
            //    && CheckConstain1(mang, key2);

        }
       static int CountConstain(int[]mang,int key = 5)
        {
            int count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i]==key)
                    count++;
            }
            return count;
        }
        static int CountConstain2(int[]mang,int key1=5,int key2 = 6)
        {
            int count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == key1 || mang[i]==key2)
                    count++;
            }          
            return count;
        }
        static int CalculateSum(int[] mang)
        {
            int sum = 0;
            for(int i = 0; i < mang.Length; i++)
            {
                sum += mang[i];
            }
            return sum;
        }
    }
}
