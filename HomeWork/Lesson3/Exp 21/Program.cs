Console.WriteLine("Введите координаты первой точки через запятую:");
var a  = Convert.ToString(Console.ReadLine()).Split(new[] {','});
Console.WriteLine("Введите координаты первой точки через запятую:");
var b  = Convert.ToString(Console.ReadLine()).Split(new[] {','});

double a1 = Convert.ToDouble(a[0]);
double b1 = Convert.ToDouble(b[0]); 

double a2 = Convert.ToDouble(a[1]);
double b2 = Convert.ToDouble(b[1]); 

double a3 = Convert.ToDouble(a[2]);
double b3 = Convert.ToDouble(b[2]); 

Console.Write(Math.Round(Math.Sqrt(Math.Pow((a1-b1), 2)+Math.Pow((a2-b2), 2)+Math.Pow((a3-b3), 2)), 2));
