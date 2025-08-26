/* 1.3.1 Assignment
Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus. */
/* 1.3.2 Assignment
Write a console application in C# to explore different ways in which array is declared and initialized and explore different properties and methods of Array class. */
/* 1.3.3 Assignment
Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
*/
using System;

namespace Assignment_1._3._1
{
    class Program
    {
        static void AreaOfTriangle(float baseLength, float height)
        {
            float area = 0.5f * baseLength * height;
            Console.WriteLine($"Area of Triangle: (1/2) * {baseLength} * {height} = {area}");
        }
        static void AreaOfSquare(float side)
        {
            float area = side * side;
            Console.WriteLine($"Area of Square: {side} * {side} = {area}");
        }
        static void AreaOfRectangle(float length, float width)
        {
            float area = length * width;
            Console.WriteLine($"Area of Rectangle: {length} * {width} = {area}");
        }
        static float GetPositiveFloatFromUser(string prompt)
        {
            float value;
            Console.Write(prompt);
            while (!float.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write(prompt);
            }
            return value;
        }
        static void Main(string[] args)
        {
            bool continueProgram = true;
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("Welcome to the Area Calculator!");
            Console.WriteLine("--------------------------------");

            while (continueProgram)
            {
                Console.WriteLine("\nArea Calculator Menu, enter a number between 1 and 4:");
                Console.WriteLine("1. Area of Triangle");
                Console.WriteLine("2. Area of Square");
                Console.WriteLine("3. Area of Rectangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    continue;
                }
                switch (choice)
                {
                    case 1: // Area of Triangle
                        {
                            Console.WriteLine("\n--- Area of Triangle: (1/2) * base * height ---");
                            float baseLength = GetPositiveFloatFromUser("Enter base: ");
                            float height = GetPositiveFloatFromUser("Enter height: ");
                            AreaOfTriangle(baseLength, height);
                            break;
                        }
                    case 2: // Area of Square
                        {
                            Console.WriteLine("\n--- Area of Square: side * side ---");
                            float side = GetPositiveFloatFromUser("Enter side length: ");
                            AreaOfSquare(side);
                            break;
                        }
                    case 3: // Area of Rectangle
                        {
                            Console.WriteLine("\n--- Area of Rectangle: length * width ---");
                            float length = GetPositiveFloatFromUser("Enter length: ");
                            float width = GetPositiveFloatFromUser("Enter width: ");
                            AreaOfRectangle(length, width);
                            break;
                        }
                    case 4: // Exit
                        {
                            Console.WriteLine("Exiting...");
                            continueProgram = false;
                            break;
                        }
                    default:
                        {
                            // This case is now handled by the input validation check above.
                            break;
                        }
                }
                // Pause and wait for user to press Enter before returning to the menu.
                if (continueProgram)
                {
                    Console.Write("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}