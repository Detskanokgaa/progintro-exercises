/*
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

*/

/*
for (int y=1 ; y<=10 ; y++) {
    for (int x=1 ; x<=y ; x++) {
        Console.Write(string.Format("{0,4}", x*y));
    }
    Console.WriteLine("");
}
*/


/*
// 5.20 Dice
int dice = 4;
bool isevenandgreaterthanthree = dice % 2 == 0 && dice > 3;
Console.WriteLine(isevenandgreaterthanthree);

// 6.3 Christmas Sale

ulong secSinceNewYear = 21816000;
ulong days = 86400;
ulong month = days*30;
float price = 599.95f;
ulong pastMonth = secSinceNewYear/month;
ulong reminder = secSinceNewYear%month;
ulong pastDays = reminder/days;
Console.WriteLine(pastMonth);
Console.WriteLine(reminder);
Console.WriteLine(pastDays);

// er vi i den 12 måned er det jul, hvordan spørger man om det?

ulong christmas = 12;
if(pastMonth == christmas){
    Console.WriteLine(price*0.7);
} else {
    Console.WriteLine(price);
}

*/

/*
int autumnHolidays = 10;
int christmasHolidays = 12;
int springHolidays = 4;
int summerJuly = 7;
int summerAugust = 8;

switch (holidays){
    case "10":
    Console.WriteLine("Autumn Holidays");
    break;
    case "12":
    Console.WriteLine("Christmas Holidays");
    break;
    case "4":
    Console.WriteLine("Spring Holidays");
    break;
    case "7":
    Console.WriteLine("Summer July");
    break;
    case "8":
    Console.WriteLine("Summer August");
    break;
    default:
    Console.WriteLine("Hard Work");
    break;
}
*/

/*
// 6.6 Create a table of matching Celcius and Fahrenheit

for (double c = -5.0; c <= 40.0; c += 0.5){
    double f = 32 + (9.0/5.0) * c;
    Console.WriteLine($"{c}  {f}");
}
*/

// 6.9 Areas of circles

// Chapter 7 exercises 
class Door {
    public bool open;
    public int height;
    public int width;
}

Door door = new Door { open=true , height=200 , width=112 };
Console.WriteLine(door.height);

door = {"open": True, "height": 200, "width": 112}

print(door["open"])
