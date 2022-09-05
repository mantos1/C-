void DiffMaxMinFromArray (string[] Arr){
int min = 0;
int max = 0;
int number;
for (int i = 0; i < Arr.Length; i++)
{
    number = Convert.ToInt32(Arr[i]);
    if (i == 0){
        min = number;
        max = number;
    }
    else {
        if (number < min) {
            min = number;
        }
        else if (number > max){
            max = number;
        }
    }
}
 Console.WriteLine(max - min); 
}

Console.WriteLine("Введите массив чисел: ");
string[] Arr = Convert.ToString(Console.ReadLine()).Split(new[] {' '});;
DiffMaxMinFromArray(Arr);

