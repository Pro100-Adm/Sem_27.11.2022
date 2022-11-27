int AskUser()
{
Console.Write("Введите количество чисел: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
        Console.WriteLine("Введите количество чисел > 0!");
        return AskUser();
    };
}
catch (Exception)
{
    Console.WriteLine("Введите верное количество чисел!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное количество чисел!");
    return AskUser();
}
}

double AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}

double count_positive_nums(double [] array){
int count_positive = 0;
foreach(double element in array){
    if(element>0) count_positive++;
}
return count_positive;
}

double [] FillArray(double [] array){
    for (int i = 0; i<array.Length; i++){
        array[i] = AskUser2();
    }
return array;
}

double [] array = new double [AskUser()];
FillArray(array);
Console.WriteLine($"Количество положительных чисел: {count_positive_nums(array)}");



