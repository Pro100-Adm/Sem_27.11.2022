// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    return op;
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

double [] array = new double [5];

for (int i = 0; i < array.Length; i++){
    array[i] = AskUser();
    Console.Write(array[i] + " ");
}

void duplicate_array(double [] array){
    double [] new_array = new double [array.Length];
    for (int i = 0; i < new_array.Length; i++){
    new_array[i] = array[i];
    Console.Write(new_array[i] + " ");
    }  
}