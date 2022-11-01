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
string[] FindLessThan(string[] input, int n) {
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}





System.Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());