using System;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* #region Program01

             1-Write a program that allows the user to enter a number then print it.

                -- ANSWER ==>
               Console.WriteLine("Enter the Nums AS U Want");

               int Nums = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("The Nums You Entered is: " + Nums);
               #endregion
            */


            /*  #region program02
            
            2-Write C# program that Assigning one value type variable 
            to another and modifying the value of one variable and 
            mention what will happen

            The Answer ==>

              int a = 10;

              int b = a;

              Console.WriteLine($"Initial values: a = {a}, b = {b}");

              // Modify the value of 'a'
              a = 20;
              Console.WriteLine($"After modification: a = {a}, b = {b}");
              #endregion
            */

            /* #region program03
             
            3-Write C# program that Assigning one reference type variable to another and 
            modifying the object through one variable and mention what will happen

            The Answer ==>

             String person1 = "Alice";

             String person2 = person1;

             // Print the initial names
             Console.WriteLine($"Initial names: person1.Name = {person1}, person2.Name = {person2}");

             // Modify the object through person1
             person1 = "Bob";

             // Print the names after modification
             Console.WriteLine($"After modification: person1.Name = {person1}, person2.Name = {person2}");
             #endregion
             */


        }

    }
}
