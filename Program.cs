
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

Console.Write("Enter a number :");
int tal = int.Parse(Console.ReadLine());
Console.WriteLine("Printing all even numbers between " + tal + " and 101");
while (tal <= 101) {
    Console.Write(tal);
    if(tal != 101) {
        Console.Write(", ");
    }
    tal++;
} 