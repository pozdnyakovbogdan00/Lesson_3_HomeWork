int Answer = Program_Main_InputData();

switch (Answer)
{
    case 1: Palindrome.Palindrome_Main(); break;  
    case 2: Distance_Between_Points.Distance_Between_Points_Main(); break;
    case 3: Table_Cubes_Numbers.Table_Cubes_Numbers_Main(); break;
    default: Console.WriteLine("You have entered an invalid value (Enter 1, 2 or 3)."); break;
}

// START Procedures and functions

static int Program_Main_InputData()
{
    Console.WriteLine("Choose one of the suggested values: ");
    Console.WriteLine("1: Palindrome program (exercise 19).");
    Console.WriteLine("2: Distance between two points (exercise 21).");
    Console.WriteLine("3: Table cubes numbers (exercise 23).");
    Console.WriteLine("Your choice? ");
    int InputData = Convert.ToInt32(Console.ReadLine());
    
    return InputData; 
}

// END Procedures and functions