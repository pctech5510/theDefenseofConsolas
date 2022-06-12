// See https://aka.ms/new-console-template for more information
/* Example
 * Target Row? 6
 * Target Column? 5
 * Deploy to:
 * (6, 4)
 * (5, 5)
 * (6, 6)
 * (7, 5)
 */


//Change the window title to be "Defense of Consolas"
Console.Title = "Defense of Consolas";

//Ask the user for the target row and column
Console.Write("What is the target row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the target column? ");
int column = Convert.ToInt32(Console.ReadLine());

//Display the deployment instructions in a different color of your choosing
//Compute the neighboring rows and columns of where to deploy the squad
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Deploy to: ");
Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");


//Play a sound with console.beep when the results have been computed and displayed
Console.Beep();
