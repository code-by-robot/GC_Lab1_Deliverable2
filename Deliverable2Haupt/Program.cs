//Greet Customer
Console.WriteLine("Welcome to James Buffett's Buffet, home of the arbitrarily low party size limit of six and arbitrarily high buffet price of $20 per person. How many are in your party?");

//Store number of guests in a variable as a number
int guests = int.Parse(Console.ReadLine());
int cost = guests*20;

//Initialize check for party size
if (guests <= 6)
{
    Console.WriteLine("Wonderful. Please have a seat at this perfectly normal table.");
    Console.WriteLine("Can I get you started with some drinks? We have margaritas for $10 and virgin margaritas for $5. If you try to order something else, you get NOTHING, so choose wisely.");

    // Loop over guests to ask for drinks.
    int guest_count = 1;
    int margs = 0;
    int v_margs = 0;
    while (guest_count <= guests)
    {
        Console.WriteLine("Alright guest number "+ guest_count+", would you like a margarita or a virgin margarita?");
        string order = Console.ReadLine();
        
        if (order == "margarita")
        {
            cost = cost + 10;
            Console.WriteLine("Alright, a margarita.");
            margs++;
        }
        else if(order == "virgin margarita")
        {
            cost = cost + 5;
            Console.WriteLine("Ok, a virgin margarita.");
            v_margs++;

        }
        else
        {
            Console.WriteLine("NO DRINK FOR YOU.");
        }
        guest_count++;
    }
    Console.WriteLine("That's "+margs+" margarita(s) and "+v_margs+" virgin margarita(s).");
    Console.WriteLine("Your total is $"+cost+". Now get out.");
}
else { 
    Console.WriteLine("Your party size is too big. Please leave. And don't come back in separate groups of less than six, I have a photographic memory and have memorized all of your faces.");
}