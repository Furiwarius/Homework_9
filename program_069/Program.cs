// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exponentiation(int number, int degree){
    if (degree > 1) number = number * Exponentiation(number, degree-1);
    
    return number;

}

Random random = new Random();
int numberA = random.Next(1, 15);
int numberB = random.Next(1, 10);

System.Console.WriteLine($"A = {numberA}; B = {numberB}; -> {Exponentiation(numberA, numberB)}");
System.Console.WriteLine($"Проверка с Math.Pow() - {Math.Pow(numberA, numberB)}");


