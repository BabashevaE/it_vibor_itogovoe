Console.WriteLine("Введите строки массива через запятую:");                               
string[] array1 = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);   
string[] array2 = new string[array1.Length];                                                                                                     
int count = 0;                                                                           
Console.WriteLine("Результат:");                                                           
for (int i = 0; i < array1.Length; i++)                                                   
{                                                                                         
    if (array1[i].Length <= 3)                                                            
    {                                                                                     
        array2[i] = array1[i];                                                            
        Console.Write(array2[i] + " ");                                                   
        count ++;                                                                         
    }  
}
if (count == 0)                                                                           
    Console.WriteLine("В массиве нет нужной нам длинны строк, пробел учитывается");       
    