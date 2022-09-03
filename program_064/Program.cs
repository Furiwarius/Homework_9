// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> 1, 2, 3, 4, 5
// M = 4; N = 8. -> 4, 6, 7, 8

int[] CreateNumber(){
    Random random = new Random();
    int M = random.Next(1, 20);
    int[] numbers = new int[]{M, random.Next(M, 50)};
    System.Console.Write($"M = {numbers[0]}; N = {numbers[1]}.  -> ");
    return numbers;
}

void PrintNumbers(int ceiling, int floor = 1){
    if (floor < ceiling){
        System.Console.Write($"{floor}, ");
        PrintNumbers(ceiling, floor+1);
    }
    else System.Console.Write(ceiling);
}

int[] newNumbers = CreateNumber();
PrintNumbers(newNumbers[1], newNumbers[0]);
