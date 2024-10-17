int[] inventory = { 200, 450, 700, 175, 250 };
int total = 0;
int bin = 0;

foreach (int num in inventory)
{
    total += num;
    bin++;
    Console.WriteLine($"Bin {bin} = {num} items (Running total: {total})");
};

Console.WriteLine($"We have {total} items in inventory.");
