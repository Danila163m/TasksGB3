int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            // Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            //Несмог с ариф дей
            string? number = Console.ReadLine();

            void CheckingNumber(string number){
                if (number[0]==number[4] || number[1]==number[3]){
                Console.WriteLine($"Ваше число: {number} - палиндром.");
            }
            else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

            if (number!.Length == 5){
                CheckingNumber(number);
            }
                else Console.WriteLine($"Введи правильное число");
            break;

        case 2:
            int x1 = Coordinate("x", "A");
            int y1 = Coordinate("y", "A");
            int z1 = Coordinate("z", "A");
            int x2 = Coordinate("x", "B");
            int y2 = Coordinate("y", "B");
            int z2 = Coordinate("z", "B");

        int Coordinate(string coorName, string pointName) {
            Console.Write($"Введите координату {coorName} точки {pointName}: ");
        return Convert.ToInt16(Console.ReadLine());
        }

                double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
                return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                Math.Pow((y2-y1), 2) + 
                Math.Pow((z2-z1), 2));
                }

        double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

        Console.WriteLine($"Длина отрезка  {segmentLength}");
            break;

        case 4:
           
            Console.Write("Введите число: ");
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
            int index = 0;
            while(index < count){
                Console.Write(coll[index]+ " ");
                index++;
  }
} 

            int[] array = new int[cube+1];
            Cube(array);
            PrintArray(array);
            break;
    }
}