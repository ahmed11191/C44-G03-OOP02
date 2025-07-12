using OOP_ASS_02;
#region Q1
//Person[] people = new Person[3];
//people[0] = new Person( "ahmed",40);
//people[1] = new Person("ayman", 38);
//people[2] = new Person("omar", 15);



//for(int i = 0; i < people.Length; i++)
//{

//    Console.WriteLine(people[i]);
//}
#endregion
#region Q2
Console.WriteLine("Enter  first point:");
double.TryParse(Console.ReadLine(), out double x1);
Console.WriteLine("Enter  first point:");
double.TryParse(Console.ReadLine(), out double y1);
Console.WriteLine("Enter  first point:");
double.TryParse(Console.ReadLine(), out double x2);
Console.WriteLine("Enter  first point:");
double.TryParse(Console.ReadLine(), out double y2);
Point point1 = new Point(x1, y1);
Point point2 = new Point(x2, y2);
double distance = Point.Distance(point1, point2);
Console.WriteLine(distance);
#endregion