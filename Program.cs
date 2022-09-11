/*

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);


void CheckNumber(string number)

{
  if (number[0] == number[4] || number[1] == number[3])
  
  {
    Console.WriteLine($"{number} - да.");
  }
  
  else Console.WriteLine($"{number} - нет.");
}

if (number!.Length == 5){
  CheckNumber(number);
}
else Console.WriteLine($"Введите пятизначное число");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

int x1 = Point("x", "A");
int y1 = Point("y", "A");
int z1 = Point("z", "A");
int x2 = Point("x", "B");
int y2 = Point("y", "B");
int z2 = Point("z", "B");

int Point(string coorName, string pointName)
{
    Console.Write($"Координата {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Method(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return (Math.Pow((x2-x1), 2) + 
        Math.Pow((y2-y1), 2) + 
        Math.Pow((z2-z1), 2));
}

double distance =  Math.Round (Method(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние  {distance}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число N: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);

*/
