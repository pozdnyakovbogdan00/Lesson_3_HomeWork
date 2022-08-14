class Palindrome
{
    static int? N;

    public static void Palindrome_Main()
    {
        int InputData = Palindrome_InputData();
        bool NumbersCorrespond = Palindrome_CheckEnteredValues(InputData);

        if (NumbersCorrespond)
        {
            int InverseNumber = Palindrome_GetInverseNumber(InputData);
            Palindrome_OutPutResult(InputData, InverseNumber);
        }
        else
        {
            Console.WriteLine("Error. The entered number does not correspond to the bit depth.");
        }


    }

    static int Palindrome_InputData()
    {
        Console.WriteLine("How many digits should be in the number: ");
        N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your number: ");
        int InPutNumber = Convert.ToInt32(Console.ReadLine());

        return InPutNumber;
    }

    static bool Palindrome_CheckEnteredValues(int InPutNumber)
    {

        int InPutNumber_ABS = Math.Abs(InPutNumber);
        int i = 1;
        while ((InPutNumber_ABS/=10) > 0)
        {
            i = i + 1;
        }

        return (i) == N ? true : false;
    }

    static int Palindrome_GetInverseNumber(int InPutNumber)
    {
        int CapacityOfDigit = 1;
        for (int i = 0; i <= N - 2; i++)
        {
            CapacityOfDigit = CapacityOfDigit * 10;
        }

        int Divisible = 1;
        int InverseNumber = 0;
        int PartOfNumber;

        for (int i = 0; i < N; i++)
        {
            PartOfNumber = (InPutNumber % (Divisible * 10) - InPutNumber % Divisible) / Divisible;
            InverseNumber = InverseNumber + (PartOfNumber * CapacityOfDigit);
            Divisible = Divisible * 10;
            CapacityOfDigit = CapacityOfDigit / 10;
        }

        return InverseNumber;
    }

    static void Palindrome_OutPutResult(int Original_Number, int Inverse_Number)
    {
        if (Original_Number == Inverse_Number)
        {
            Console.WriteLine("The entered number is a palindrome");
        }
        else
        {
            Console.WriteLine("The entered number is NOT a palindrome");
        }

    }

}

class Distance_Between_Points
{
    static string[] ArrNamePoint = {"x", "y", "z"};
    public static void Distance_Between_Points_Main()
    {
        Dictionary<string, int> InputData = Distance_Between_Points_InputData();
        double result = Distance_Between_Points_CalculateDistanceBetweenPoints(InputData);
        Distance_Between_Points_OutPutData(result);
    }

    static Dictionary<string, int> Distance_Between_Points_InputData()
    {
        Dictionary<string, int> DictCoordinates = new Dictionary<string, int>();

        Console.WriteLine("Enter your coordinates in 3D (x1, y1, z1) (x2, y2, z2)");
        int CurrentCoordinate;
        foreach (var item in ArrNamePoint)
        {
            Console.WriteLine("Enter your coordinate "+item+"1");
            CurrentCoordinate = Convert.ToInt32(Console.ReadLine());
            DictCoordinates.Add(Convert.ToString(item+"1"), CurrentCoordinate);
            Console.WriteLine("Enter your coordinate "+item+"2");
            CurrentCoordinate = Convert.ToInt32(Console.ReadLine());
            DictCoordinates.Add(Convert.ToString(item+"2"), CurrentCoordinate);

        }

        return DictCoordinates;
    }

    static double Distance_Between_Points_CalculateDistanceBetweenPoints(Dictionary<string, int> InputData)
    {
        double result = 0;

        foreach (var item in ArrNamePoint)
        {
            result = result + Math.Pow(InputData[item+"2"] - InputData[item+"1"], 2);
        }

        return Math.Sqrt(result); 
    }

    static void Distance_Between_Points_OutPutData(double result)
    {
        Console.WriteLine("Distance between points: "+result);
    }
}

class Table_Cubes_Numbers
{
    static int NumberN;
    public static void Table_Cubes_Numbers_Main()
    {
        int InputData = Table_Cubes_Numbers_InputData();
        string result = Table_Cubes_Numbers_Find_Cubes_Number(InputData);
        Table_Cubes_Numbers_OutPutData(result);
    }  

    static int Table_Cubes_Numbers_InputData()
    {
        Console.WriteLine("Enter your number N: ");
        NumberN = Convert.ToInt32(Console.ReadLine());

        return NumberN;
    } 

    static string Table_Cubes_Numbers_Find_Cubes_Number(int InputData)
    {
        string result = "";
        for (int i = 1; i <= InputData; i++)
        {   
            result = result + Convert.ToInt32(Math.Pow(i, 3)) + "; ";            
        }
        return result;
    }

    static void Table_Cubes_Numbers_OutPutData(string result)
    {
        Console.WriteLine("Tabele cubs number: " + result);
    }
}