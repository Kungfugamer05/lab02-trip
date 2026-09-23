//Part 1 Started//
System.Console.WriteLine();
Console.WriteLine("=== Part 1: Road Trip ===");
//.WriteLine puts input or whatever under it
System.Console.WriteLine();
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
System.Console.WriteLine();
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//Part 2 Started//
System.Console.WriteLine();
Console.WriteLine("=== Part 2: Pizza Party ===");
System.Console.WriteLine();
Console.Write("How many people are going? ");
int slicesPerPerson = Convert.ToInt32(Console.ReadLine());

Console.Write("How many WHOLE pizzas? ");
int totalSlices = Convert.ToInt32(Console.ReadLine());

Console.Write("How much did each Pizza Cost? $");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

double howManySlices = totalSlices * 8; 

double howManySlicesEachPersonGets = howManySlices / slicesPerPerson;

double totalPizzasPrice = totalSlices * pricePerPizza;
System.Console.WriteLine();
System.Console.WriteLine("Total slices: " + howManySlices.ToString("F2"));
System.Console.WriteLine("Slices per Person: " + howManySlicesEachPersonGets.ToString("F2"));
System.Console.WriteLine("Pizza cost: $" + totalPizzasPrice.ToString("C"));

//Part 3 Started//
System.Console.WriteLine();
System.Console.WriteLine("=== Part 3: Paycheck ===");
System.Console.WriteLine();
Console.Write("How many hrs have you worked this week? ");
double totalHoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("How much do you get payed per hr? $");
double totalPayPerHour = Convert.ToDouble(Console.ReadLine());

double grossPay = totalHoursWorked * totalPayPerHour; 

double taxWithHeld = grossPay / 7.00;

double takeHomePay = grossPay - taxWithHeld;
System.Console.WriteLine();
System.Console.WriteLine("Gross pay: $" + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: $" + taxWithHeld.ToString("C"));
System.Console.WriteLine("Take home pay: $" + takeHomePay.ToString("C"));

//Part 4 Started// 
System.Console.WriteLine();
System.Console.WriteLine("=== Part 4: The Whole Trip ===");
double tripTotal = fuelCost + pricePerPizza; 

double costPerPerson = tripTotal / slicesPerPerson;

double takeHomePayPerHour = takeHomePay / totalHoursWorked;

double hoursYouMustWork = costPerPerson / takeHomePayPerHour;
System.Console.WriteLine();
Console.WriteLine("Trip total: $" + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: $" + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: $" + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: $" + hoursYouMustWork.ToString("C"));