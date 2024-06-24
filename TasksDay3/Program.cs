// Task #2 from Paper 3
// >500 -> 3%, >1000 -> 5%

Console.WriteLine("Give an item a price: ");
double itemPrice = double.Parse(Console.ReadLine());

double totalPrice = 1;

if(itemPrice > 500 && itemPrice <= 1000) totalPrice = itemPrice * 0.97;
else if(itemPrice > 1000) totalPrice = itemPrice * 0.95;
else totalPrice = itemPrice;

Console.WriteLine(totalPrice);
Console.WriteLine("End of Task #2 \n");

