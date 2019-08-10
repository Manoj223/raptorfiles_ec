using System;
using System.IO;
using System.Text;

namespace avarage of prime numbers
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? j;
         ?? c;
         ?? sum;
         ?? i;
         ?? n;
         ?? x;
      
         i =2;
         j =1;
         c =0;
         sum =0;
         raptor_prompt_variable_zzyz ="enter range";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         n= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="enter ending range";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         x= Double.Parse(Console.ReadLine());
         while (1)
         {
            j =1;
            if (i>n)) break;
            while (!(j>x))
            {
               if ((i % j)==0)
               {
                  c =c+1;
               }
               else
               {
               }
               j =j+1;
            }
            if (c==2)
            {
               Console.WriteLine(i);
               sum =sum+i;
            }
            else
            {
            }
            c =0;
            i =i+1;
         }
         Console.WriteLine("average of prime numbers"+sum/n);
      }
   }
}
