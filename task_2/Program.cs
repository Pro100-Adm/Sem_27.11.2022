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

string is_triangle_exists( double side_1, double side_2, double side_3){
    if (side_1<side_2+side_3&&side_2<side_1+side_3&&side_3<side_1+side_2){
        return "Triange exists!";
    }else{
        return "Triange not exists!";
    }
}

Console.WriteLine(is_triangle_exists(AskUser2(), AskUser2(), AskUser2()));