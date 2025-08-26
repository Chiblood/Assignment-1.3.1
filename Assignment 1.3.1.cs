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
int choice = 0;

while (choice != 4)
{
    Console.WriteLine("\n Area Calculator Menu, enter a number between 1 and 3:");
    Console.WriteLine("1. Area of Triangle");
    Console.WriteLine("2. Area of Square");
    Console.WriteLine("3. Area of Rectangle");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Please choose a valid option (1-4)");
        continue;
    }
    switch (choice)
    {
        case 1: // Area of Triangle
            {
                Console.WriteLine("\n--- Area of Triangle: (1/2) * base * height ---");
                Console.Write("Enter base: ");
                float.TryParse(Console.ReadLine(), out float baseLength);
                Console.Write("Enter height: ");
                float.TryParse(Console.ReadLine(), out float height);
                float area = 0.5f * baseLength * height;
                Console.WriteLine($"Area of Triangle: (1/2) * {baseLength} * {height} = {area}");
                break;
            }
        case 2: // Area of Square
            {
                Console.WriteLine("\n--- Area of Square: side * side ---");
                Console.Write("Enter side length: ");
                float.TryParse(Console.ReadLine(), out float side);
                float area = side * side;
                Console.WriteLine($"Area of Square: {side} * {side} = {area}");
                break;
            }
            case 3: // Area of Rectangle
            {
                Console.WriteLine("\n--- Area of Rectangle: length * width ---");
                Console.Write("Enter length: ");
                float.TryParse(Console.ReadLine(), out float length);
                Console.Write("Enter width: ");
                float.TryParse(Console.ReadLine(), out float width);
                float area = length * width;
                Console.WriteLine($"Area of Rectangle: {length} * {width} = {area}");
                break;
            }
        case 4: // Exit
            {
                Console.WriteLine("Exiting...");
                break;
            }
        default:
            {
                Console.WriteLine("Please choose a valid option (1-4)");
                break;
            }
    }
}