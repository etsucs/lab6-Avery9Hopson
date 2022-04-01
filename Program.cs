
    Console.WriteLine(ShowCharacter("New York",2));



    double retailPrice = CalculatRetail (5.00, 100);
    Console.WriteLine("Retail price: " + retailPrice.ToString("0.00"));



    Console.WriteLine ("Fahrenheit          Celsius");
    for(int i = 80;i<=100;i++)
    {
        float celsiusConversion = (float) i;

        Console.WriteLine("    "+i+"             "+Celsius(celsiusConversion));
    }


    
    Console.WriteLine("isPrime(5): " + isPrime(5));




static char ShowCharacter(string str,int i)
{
    return str[i-1];
}



static double CalculatRetail(double wholeSaleCost, double markUp)
{
    double markUpPercent = markUp / 100;
    double markUpAmount = wholeSaleCost * markUpPercent;
    double retailPrice = wholeSaleCost + markUpAmount;

    return retailPrice;
}



static float Celsius(float fahrenheit)
{
    float celsiusConversion = (9f/5f)*(fahrenheit - 32);
    return celsiusConversion;
}



static bool isPrime(int n)
{
    for(int i=2; i<=n/2; i++)
    {
        if(n%i==0)
            return false;
    }
    return true;
}