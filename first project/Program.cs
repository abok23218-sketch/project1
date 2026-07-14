

Console.WriteLine("welcom to islam's carpet cleaning serv - what is your name?: ");
string name = Console.ReadLine();
Console.WriteLine($"hello mr/s: {name}");

Console.Write("$35 pre large , how many do you want to wash?:  ");
decimal bigCarpet = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"cost of largecarpet: {bigCarpet * 35}");

Console.Write("do you want to wash small too?: true / false:  ");

decimal total = 0;
decimal tax = 0;

 

bool wash= Convert.ToBoolean(Console.ReadLine());

if (wash)

{ Console.WriteLine($"25 per small " +
    $"how many do you want:  " );

    decimal smallcarpe = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"cost of smallcarpet: {smallcarpe * 25}");

     total = ((bigCarpet * 35) + (smallcarpe * 25));
    Console.WriteLine($" total= {total}");

     tax = (total * 10 / 100);

    Console.WriteLine($"tax = {tax}"); }

 else
{
     total = ((bigCarpet * 35) );

    Console.WriteLine($" total= {total}");

   tax = (total * 10 / 100);

    Console.WriteLine($"tax = {tax}");

  }
decimal finaltotal = (tax + total);

Console.Write($" final total: {finaltotal}");



