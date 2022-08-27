Console.Clear();
start:
Console.WriteLine("Введите день недели или нажмите q для выхода:");
string a = Console.ReadLine();
if ( a == "q") {
    return;
}
int x = Convert.ToInt32(a);
if ( x > 7 || x < 0) {
    Console.WriteLine("Выбран некорректный день недели!");
    goto start;
}
var DaysNumber = new Dictionary<int, string>();
var TypeDay = new Dictionary<int, string>();

TypeDay.Add (0, "будний день :(");
TypeDay.Add (1, "выходной день!!!");

DaysNumber.Add (1, "Понедельник");
DaysNumber.Add (2, "Вторник");
DaysNumber.Add (3, "Среда");
DaysNumber.Add (4, "Четверг");
DaysNumber.Add (5, "Пятница");
DaysNumber.Add (6, "Суббота");
DaysNumber.Add (7, "Воскресенье"); 
 
string Day = DaysNumber[x];
string typeD = "";

if ( x <= 5) {
    typeD = TypeDay[0];
}
else {
    typeD = TypeDay[1];
}

Console.Write($"Выбран {Day} и это {typeD}");