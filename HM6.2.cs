double xk1 = ReadInt("Введите значение k1: ");
double yb1 = ReadInt("Введите значение b1: ");
double xk2 = ReadInt("Введите значение k2: ");
double yb2 = ReadInt("Введите значение b2: ");


double x= (yb2-yb1)/(xk1-xk2);
double y= xk1 * x + yb1;  

Console.WriteLine(x + "," +y ); 


int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
