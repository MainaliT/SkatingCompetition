using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkatingCompetition
{
    class Program
    {
        public static void averageScore(params int[] scores) {
            double sum = 0;
            for (int i = 0; i < scores.Length; i++) {
                sum += scores[i];
            }

            double average = sum / scores.Length;

            Console.WriteLine("The total scores = " + sum);
            Console.WriteLine("The number of score given by judge = " + scores.Length);
            Console.WriteLine("The Average score earned is = " + System.Math.Round(average, 1));
            
        }

        static void Main(string[] args)
        {
            int input, input1, input2, input3, input4, input5, input6, input7, input8;
           
            //  int averageScore = 0;


            Console.WriteLine("Please select week of the game: \n1 for Week1, \n2 for Week2, \n3 for Week3 and \n4 for week4:");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("YOU SELECTED WEEK 1");
                Console.WriteLine("Please enter the  first score");
                input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  second score");
                input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  third score");
                input3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  fourth score");
                input4 = Convert.ToInt32(Console.ReadLine());

                averageScore(input1, input2, input3, input4);
              //  Console.WriteLine("The first score:" + input1 + "\nSecond score: " + input2 + "\nThird Score: " + input3 + "\nFourth Score:" + input4 + "\nWith the average score of: " + averageScore);
                Console.ReadLine();
            }
            else if (input == 2) {
                Console.WriteLine("YOU SELECTED WEEK 2");
                Console.WriteLine("Please enter the  first score");
                input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  second score");
                input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  third score");
                input3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  fourth score");
                input4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  Fifth score");
                input5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  six score");
                input6 = Convert.ToInt32(Console.ReadLine());

                averageScore(input1 ,input2, input3 ,input4 ,input5, input6);
               // Console.WriteLine("The first score:" + input1 + "\nSecond score: " + input2 + "\nThird Score: " + input3 + "\nFourth Score:" + input4 + "\nFifth Score: " + input5 + "\nSix Score:" + input6 + "\nWith the average score of: " + averageScore);
                Console.ReadLine();
            } else if (input == 3) {
                Console.WriteLine("YOU SELECTED WEEK 3");
                Console.WriteLine("Please enter the  first score");
                input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  second score");
                input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  third score");
                input3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  fourth score");
                input4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  fifth score");
                input5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  six score");
                input6 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  fifth score");
                input7 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  six score");
                input8 = Convert.ToInt32(Console.ReadLine());

                averageScore(input1, input2, input3, input4, input5, input6, input7, input8);

                //Console.WriteLine("The first score:" + input1 + "\nSecond score: " + input2 + "\nThird Score: " + input3 + "\nFourth Score:" + input4 + "\nFifth Score: " + input5 + "\nSix Score:" + input6 + "\nThird Score: " + input7 + "\nSeventh Score:" + input8 + "\nEighth Score: " + "\nWith the average score of: " + averageScore);
                Console.ReadLine();
            } else if (input == 4) {
                Console.WriteLine("YOU SELECTED WEEK 4");
                Console.WriteLine("Please enter the  first score");
                input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  second Score score");
                input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the  third score");
                input3 = Convert.ToInt32(Console.ReadLine());

                averageScore(input1, input2, input3);

                //Console.WriteLine("The first score:" + input1 + "\nSecond score: " + input2 + "\nThird Score: " + input3 + "\nWith the average score of: " + averageScore);
                Console.ReadLine();
            }
           
           
        }

        //private static void averageScore(double input1, double input2, double input3, double input4, double input5, double input6)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void averageScore(double input1, double input2, double input3)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void averageScore(double input1, double input2, double input3, double input4, double input5, double input6, double input7, double input8)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void averageScore(double input1, double input2, double input3, double input4)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
            