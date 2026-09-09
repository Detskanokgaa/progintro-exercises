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


ulong timestamp = 100000000;
ulong minutes = timestamp/60;
ulong hours = minutes/60;
ulong days = hours/24;
ulong years = days/365;
Console.WriteLine(years + 1970);
ulong reaminingdays = days % 365;
Console.WriteLine(reaminingdays);
// 3 år og 62 dage

double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9;
Console.WriteLine(tuesday - monday);
Console.WriteLine(wednesday - tuesday);
Console.WriteLine(thursday - wednesday);
Console.WriteLine(friday - thursday);
Console.WriteLine(saturday - friday);
Console.WriteLine(sunday - saturday);


int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg- female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

//

int i = 42;
long l = 56;
float f = 3.14159F;
double d = 3.14159 * 10;
Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.00}", i, l, f, d);
Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.00}", d, l, f, i);

