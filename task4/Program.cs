// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//     2, 3, 7 -> 7
//     44 5 78 -> 78
//     22 3 9 -> 22
Console.WriteLine("Введите три числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
if(A > B && A > C){
    Console.WriteLine("max = " + A);
}
else if(B > A && B > C){
    Console.WriteLine("max = " + B);
}
else{
    Console.WriteLine("max = " + C);
}    
