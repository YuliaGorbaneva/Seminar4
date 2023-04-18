// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("ВВедите число: ");

int a = int.Parse(Console.ReadLine());

int getsum(int number){
    int sum = 0;

    for (int i = 1; i <= a; i ++){
    sum += i; 
    return sum;
    }
  
}

Console.WriteLine($"Сумма чиселот 1 до {a}: {getsum(a)}");

