/*
 * Name:Jordyn Lutz
 * Date:02/05/2023
 * Description: Deliverable 4: Array using Fibonacci sequence
 */

using System;

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
      
        {
            Console.WriteLine("To show the Fibonacci sequence for an input of 25."); //shows message to console

            int input = 25;  //creates integer variable with value 25

                 
              int[] fibonacci = new int[input]; //line creates length equal to input variable

            //Start fibonacci array

                fibonacci[0] = 0; //value of 0, index 0 of the array
                fibonacci[1] = 1; //value of 1, index 1 of the array

                for(int i=0; i < input; i++) //loop will populate the array
                {


                    if (i >= 2) //allows to populate the array
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; //equation

                    }
                    Console.WriteLine("Fibonacci number ("+ i +")= " + fibonacci [i]); //display the array values
                }
            }
        }
    }
