//Part 1 Started//

Console.WriteLine("=== Part 1: Road Trip ===");
//.WriteLine puts input or whatever under it

Console.Write("How many Round trip miles? ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());
//How to ask a question ^^ //.Write puts input to the side

Console.Write("How many Miles per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much is Price per gallon? $");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / milesPerGallon;
//gallons needed = miles divided / by miles per gallon

double fuelCost = gallonsNeeded * pricePerGallon; 
//gallons needed are multiplied * by price per gallon
//And then the code saves the result as "fuelCost" the variable

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//Part 2 Started//

Console.WriteLine("=== Part 2: Pizza Party ===");

Console.Write("How many people are going? ");
int slicesPerPerson = Convert.ToInt32(Console.ReadLine());

Console.Write("How many WHOLE pizzas? ");
int totalSlices = Convert.ToInt32(Console.ReadLine());

Console.Write("How much did each Pizza Cost? $");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

double howManySlices = totalSlices * 8; 

double howManySlicesEachPersonGets = howManySlices / slicesPerPerson;

double totalPizzasPrice = totalSlices * pricePerPizza;

System.Console.WriteLine("Total slices: " + howManySlices.ToString("F2"));
System.Console.WriteLine("Slices per Person: " + howManySlicesEachPersonGets.ToString("F2"));
System.Console.WriteLine("Pizza cost: $" + totalPizzasPrice.ToString("C"));

//Part 3 Started//

