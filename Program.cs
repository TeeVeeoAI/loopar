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

int Antal;
double summa = 0, input;
Console.Write("Enter the amunt of number that you want: ");
Antal = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= Antal; i++) {
    Console.Write("Enter the number " + i + ": ");
    input = Convert.ToDouble(Console.ReadLine());
    summa = summa + input;
}
Console.Write("");