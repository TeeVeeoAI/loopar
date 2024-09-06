/*Console.Write("Enter a number :");
int tal = int.Parse(Console.ReadLine());
Console.WriteLine("Printing all even numbers between " + tal + " and 101");
while (tal <= 101) {
    if (tal % 2 == 0) {
        Console.Write(tal);
        if(tal != 100) {
            Console.Write(", ");
        }
    }
    tal++;
} */

/* Console.Write("Enter a number :");
int tal = int.Parse(Console.ReadLine());
Console.WriteLine("Printing all even numbers between " + tal + " and 101");
while (tal <= 101) {
    Console.Write(tal);
    if(tal != 101) {
        Console.Write(", ");
    }
    tal++;
} */

/*Console.Write("Enter a number :");
for (int i = int.Parse(Console.ReadLine()); i <= 101; i++ ){
    Console.Write(i);
    if (i != 101) {
        Console.Write(", ");
    }
}*/

double biggest = 0;
double smallest = 0;
int Antal;
double summa = 0, input;
Console.Write("Enter the amunt of numbers that you want: ");
Antal = int.Parse(Console.ReadLine());
for (int i = 1; i <= Antal; i++) {
    Console.Write("Enter the number " + i + ": ");
    input = double.Parse(Console.ReadLine());
    summa = summa + input;
    if (i == 1){
        biggest = input;
        smallest = input;
    }
    
    if (smallest >= input) {
        smallest = input;
    } else if (biggest <= input) {
        biggest = input;
    }
}
Console.WriteLine("The average value is: " + (summa / Antal));
Console.WriteLine("The biggest value was: " + biggest);
Console.WriteLine("The smallest value was: " + smallest);