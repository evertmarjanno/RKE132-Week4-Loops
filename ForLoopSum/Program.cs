﻿int sum = 0;

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total : {sum}");
    sum += i;
}

Console.WriteLine($"Final total {sum}");
