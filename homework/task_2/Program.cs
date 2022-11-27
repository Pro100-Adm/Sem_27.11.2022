using pointNamespace;

double AskUser(string hint)
{
Console.Write(hint);
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное значение!");
    return AskUser(hint);
}
}
else{
    Console.WriteLine("Введите верное значение!");
    return AskUser(hint);
}
}

Point cross_point(double k1, double b1, double k2, double b2){
if(k1 == k2 && b1 == b2){
    Console.WriteLine("Прямые совпадают!");
    return cross_point(AskUser("Введите k1: "), AskUser("Введите b1: "), AskUser("Введите k2: "), AskUser("Введите b2: "));
}
if(k1 == k2){
    Console.WriteLine("Прямые параллельны!");
    return cross_point(AskUser("Введите k1: "), AskUser("Введите b1: "), AskUser("Введите k2: "), AskUser("Введите b2: "));
}
double x = (b2-b1)/(k1-k2);
double y = ((k1*(b2-b1))/(k1-k2))+b1;
Point cross = new Point(x, y);
return cross;
}
Point res = cross_point(AskUser("Введите k1: "), AskUser("Введите b1: "), AskUser("Введите k2: "), AskUser("Введите b2: "));
Console.Write(res.get_x() + " " + res.get_y());