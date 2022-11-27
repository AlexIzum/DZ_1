// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 ==0){
    Console.WriteLine("Да, число чётное");
}
else{
    Console.WriteLine("Нет, число не чётное");
}