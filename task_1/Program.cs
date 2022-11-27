int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
        Console.WriteLine("Введите число > 0!");
        return AskUser();
    };
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
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

double [] array = new double [5];

for (int i = 0; i < array.Length; i++){
    array[i] = i+1;
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++){
    double temp = array[i]; 
    array[i] = array[array.Length-i-1];
    array[array.Length-i-1] = temp;
    Console.Write(array[i] + " " + array[array.Length-i-1] + " ");
}