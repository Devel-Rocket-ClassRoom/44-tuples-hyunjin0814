using System;

// README.md를 읽고 코드를 작성하세요.
var item = Tally();
Console.WriteLine($"합계: {item.Item1}, 개수: {item.Item2}");

var result = Calculate();
Console.WriteLine($"합계: {result.Sum}, 개수: {result.Count}");

var pair = GetPair();
Console.WriteLine($"{pair.first}, {pair.second}");

var minmax = FindMinMax();
Console.WriteLine($"최솟값: {minmax.min}, 최댓값: {minmax.max}");

var basic = ZeroZero();
Console.WriteLine($"{basic.Item1}, {basic.Item2}");

var bob = ("Bob", 23);
(string name, int age) = bob;
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");

var (sum, count) = Tally();
Console.WriteLine($"Sum: {sum}, Count: {count}");

string name1 = "";
int age1 = 0;

(name1, age1) = ("Alice", 30);
Console.WriteLine($"{name1}, {age1}");

(_, int age2, _) = (12, 23, 34);
Console.WriteLine($"나이: {age2}");

(int, int) Tally()
{
    return (12, 3);
}

(int Sum, int Count) Calculate()
{
    return (45, 6);
}

(int first, int second) GetPair() => (100, 200);

(int min, int max) FindMinMax()
{
    int[] nums = new int[] { 5, 2, 8, 1, 9, 3 };
    int min = nums[0];
    int max = nums[0];

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < min)
        {
            min = nums[i]; 
        }
        if (nums[i] > max)
        {
            max = nums[i]; 
        }
    }

    return (min, max);
}

(int, int) ZeroZero()
{
    return default;
}