//Task 1

bool IsPalindrome(int number) { 
    string original = number.ToString(); 
    string reverted = ""; 
    for (int i = original.Length - 1; i > -1; i--) { 
        reverted += original[i];
    }
    return original == reverted;
} 
 
Console.WriteLine("Введите число:"); 
int n = int.Parse(Console.ReadLine()); 
if (n.ToString().Length != 5) { 
    Console.WriteLine("Число не пятизначное"); 
} else { 
    Console.WriteLine(IsPalindrome(n) ? "да" : "нет"); 
}


//Task 2

int[] ReadCoordinates(string pointName) 
{ 
    Console.WriteLine("Введите координаты точки " + pointName + " как X,Y,Z:"); 
    string[] coords = Console.ReadLine().Split(","); 
    if (coords.Count() != 3) 
    { 
        Console.WriteLine("Неверные координаты"); 
        Environment.Exit(1); 
    } 

    int[] point = new int[coords.Count()];
    for (int i = 0; i < coords.Count(); i++) {
        point[i] = int.Parse(coords[i]);
    }
    return point; 
} 

double CalculateDistance(int[] a, int[] b) 
{ 
    double distance = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2));
    return Math.Round(distance, 2); 
} 
 
int[] a = ReadCoordinates("A"); 
int[] b = ReadCoordinates("B");
 
Console.WriteLine(CalculateDistance(a, b));


//Task 3

void PrintCube(int number)
{
    string result = "";
    for (int i = 1; i <= number; i++)
    {
        if (i > 1)
        {
            result += ",";
        }
        result += Math.Pow(i, 3);
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
if (number > 0) {
    PrintCube(number);
} else {
    Console.WriteLine("Число отрицательное или 0");
}
