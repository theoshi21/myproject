int val1, val2;

Console.Write("Insert number 1: ")
val1 = int.Parse(Console.ReadLine());

Console.Write("Inser number 2: ")
val2 = int.Parse(Console.ReadLine());

switch(val1 > val2)
{
    case true:
        Console.WriteLine("The maximum value is " + val1);
        break;
    case false:
        Console.WriteLine("The maximum value is " + val2);
        break;
    default:
        Console.WriteLine("Invalid input.");
        break;
}
