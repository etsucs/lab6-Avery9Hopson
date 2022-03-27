static char ShowCharacter(string str,int i)
{
    return str[i-1];
}
string str = "New York";

Console.WriteLine(ShowCharacter(str,2));

static double CalculatRetail(double wholeSaleCost, double markUpPercent)
{
    double markUpAmount = wholeSaleCost * markUpPercent;
    double retailPrice = wholeSaleCost + markUpAmount;

    return retailPrice;
}

Console.Write("What is the wholesale cost?: ");
double wholeSaleCost = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the markup percentage?: ");
double markUp = Convert.ToDouble(Console.ReadLine());

double markUpPercent = markUp / 100;

double retailPrice = CalculatRetail (wholeSaleCost, markUpPercent);

Console.WriteLine("Retail price: " + retailPrice.ToString("0.00"));

static float Celsius(float fahrenheit)
{
    float celsiusConversion = (9f/5f)*(fahrenheit - 32);
    return celsiusConversion;
}

Console.WriteLine ("Fahrenheit          Celsius");
    for(int i = 80;i<=100;i++)
    {
        float celsiusConversion = (float) i;

        Console.WriteLine("    "+i+"             "+Celsius(celsiusConversion));
    }

bool isPrime(int n)
{
    if(n==2)
    return true;

    if(n==1)
    return false;

    if(n%2==0)
    return false;

    for(int i=2;i<=n/2;i++)
    {
        if(n%i==0)
        return false;
    }
    return true;
}
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(isPrime(n))
{
    Console.WriteLine($"{n} is a prime number.");
}
else
Console.WriteLine($"{n} is not a prime number.");