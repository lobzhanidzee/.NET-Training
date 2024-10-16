int[] inventory = { 200, 450, 700, 175, 250 };
int total = 0;

foreach (int num in inventory)
{
    total += num;
};

Console.WriteLine($"We have {total} items in inventory.");