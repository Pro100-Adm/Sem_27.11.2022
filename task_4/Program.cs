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

void print_fibo(int n){
    int [] fibo = new int[n];
    fibo[0] = 0;
    fibo[1] = 1;
    Console.Write(fibo[0]+" "+fibo[1]+" ");
    for(int i=2; i<fibo.Length; i++){
        fibo[i] = fibo[i-1]+fibo[i-2];
        Console.Write(fibo[i]+" ");
    }
}

print_fibo(AskUser());