Console.WriteLine("Hello, world!");

string name ="project nummer 1";
Console.WriteLine(name);

int dag = 1;
Console.WriteLine("dag " + dag);


byte max = byte.MaxValue;
Console.WriteLine("Max value for byte: " + max);

byte overflow = (byte)(max + 1);
Console.WriteLine("After adding 1:" + overflow);

double Area(double radius){
    return Math.PI * radius * radius;
}
double radius;
double area;
radius = 1;
area = Math.PI * radius * radius;
Console.WriteLine("The area for the circle of radius " + radius + " is " + area);
Console.WriteLine(Area(1));
Console.WriteLine(Area(3));
Console.WriteLine(Area(5));


double fahrenheit(double celcius){
    return celcius * 9/5 + 32;
}
Console.WriteLine(fahrenheit(20));
