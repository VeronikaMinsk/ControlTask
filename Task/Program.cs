Console.WriteLine("\nПервоначальный массив:");
string[] array1 = {"Minsk", ";-)", "22", "opa", "56473", "GB", "S_N", "Romeo"};
string[] array2 = new string[array1.Length];
ResultArray(array1, array2);
void ResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
            {
            array2[count] = array1[i];
            count++;
            }
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array1));
Console.WriteLine("\nСформированный массив согласно условию задачи:");
Console.WriteLine("[{0}]\n", string.Join(", ", array2.Where(s => !string.IsNullOrEmpty(s))));