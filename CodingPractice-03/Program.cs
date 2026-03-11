using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
var one = (1, 2);
var two = (1, 2);
var three = (2, 3);

Console.WriteLine(one.Equals(two));
Console.WriteLine(one.Equals(three));

Console.WriteLine(one == two);
Console.WriteLine(one == three);

(string name, int age) alice = ("Alice", 25);
(string a, int b) copy = alice;
Console.WriteLine($"{copy.a}, {copy.b}");

(string name, int age, char sex) bob = ("Bob", 23, 'M');
(string age, int sex, char name) copy2 = bob;
Console.WriteLine(copy2.age);
Console.WriteLine(copy2.sex);
Console.WriteLine(copy2.name);

List<(string name, int age)> peoples = new List<(string name, int age)>
{
    ("Alice", 25),
    ("Bob", 30),
    ("Charlie", 35)
};

foreach (var people in peoples)
{
    Console.WriteLine($"{people.name}: {people.age}세");
}

Dictionary<(int x, int y), string> points = new Dictionary<(int x, int y), string>
{
    { (0, 0), "원점"},
    { (1, 0), "오른쪽" },
    { (0, 1), "위" }
};

Console.WriteLine(points[(0, 0)]);
Console.WriteLine(points[(1, 0)]);

var tuple1 = new Tuple<string, int>("Bob", 23);
var tuple2 = Tuple.Create("Alice", 25);

Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");
Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");