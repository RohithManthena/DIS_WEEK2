using System;

namespace DIS_WEEK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            int experience= int.Parse(Console.ReadLine());
            if (experience == 0)
            {
                Console.WriteLine("Need lots of practice");
            }
            else if (experience == 1)
            {
                Console.WriteLine("looks like you have a little experience");
            }
            else if (experience == 2)
            {
                Console.WriteLine("wow! you've been doing this for a little while");
            }
            else
            {
                Console.WriteLine("You are an expert!");
            }
 
        }
        }
 

    }
