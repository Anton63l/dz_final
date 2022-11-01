using System;
using static System.Console;



string[] GenerateArray(int length){
    var array = new string[length];
    for (int i = 0; i < length; i++)
    { 
        System.Console.Write("Элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
return array;
}





System.Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());