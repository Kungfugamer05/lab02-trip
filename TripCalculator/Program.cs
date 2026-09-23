
Console.WriteLine("=== Part 1: Road Trip ===");
//.WriteLine puts input or whatever under it

Console.Write("How many Round trip miles? ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());
//How to ask a question ^^ //.Write puts input to the side

Console.Write("How many Miles per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much is Price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / milesPerGallon;
//gallons needed = miles divided / by miles per gallon

double fuelCost = gallonsNeeded * pricePerGallon; 
//gallons needed are multiplied * by price per gallon
//And then the code saves the result as "fuelCost" the variable

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

Console.WriteLine();

