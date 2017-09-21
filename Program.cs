using System;

namespace Arrayex1
{
    class Program
    {
        static void Main()
        {  int x,y=0;
           string[] week = new string[7];
           string[] week1 = new string[7];
                week[0] = "Sunday";
                week[1] = "Monday";
                week[2] = "Tuesday";
                week[3] = "Wednesday";
               week[4] = "Thursday";
               week[5] = "Friday";
               week[6] = "Saturday";

           Console.WriteLine("Enter the string you want to search from the  array: ");
              string word = Console.ReadLine();
            
            for(x=0;x<7;x++)
            {
                if(word==week[x]){
                    y=1;
                }
            }

                if( y==1){
                Console.WriteLine("Searched string is present in the array");
                }
                else{
                    Console.WriteLine("Searched word is not present in  the  array");
                }
            
            Array.Sort( week, comparer: StringComparer.InvariantCulture);
            for(x=0;x<7;x++){
            Console.WriteLine(week[x]);
            }

            Console.WriteLine("The sorted array is: \n");

            for(x=0;x<7;x++){
                week1[x]=week[x];
            
            Console.WriteLine(week1[x]);
            }
        }
    }
}
