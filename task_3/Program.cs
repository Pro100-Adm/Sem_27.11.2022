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

void DecimalToBinary(int num){
    int temp = 0;
    string result = String.Empty;
    while(num>0){
        temp = num%2;
        num = num/2;
        result = temp.ToString() + result;
    }
    Console.Write(result);
}

DecimalToBinary(AskUser());



