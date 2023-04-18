// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine(" Введите число");

int n = int.Parse(Console.ReadLine());
int f = 1;
for (int i = 1; i <= n; i++){
    f *= i; 
}      
System.Console.WriteLine(f);








// int number = ReadInt("чило: ");

// int ReadInt(string a){
//     Console.Write($"input {a}: ");

//     int i;
//     while (! int.TryParse(System.Console.ReadLine(), out i)){
//         System.Console.WriteLine("not number");
//     };

//     return i;
// }

// int Facktorial(int a){
//     int count = 1;
//     int i = 1;
//     while (i <= a){
//         count *= i;
//         i++;
//     }
//     return count;
// }

// System.Console.WriteLine(Facktorial(number));


























// for (int i = 1; i <= n; i++)
//         factorial *= i;
//     return factorial;
// }