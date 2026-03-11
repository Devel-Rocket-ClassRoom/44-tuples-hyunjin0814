using System;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.
(string, int) bob = ("Bob", 23);
Console.WriteLine(bob.Item1);
Console.WriteLine(bob.Item2);

(int, int, int) numbers = (12, 34, 56);
Console.WriteLine($"{numbers.Item1}, {numbers.Item2}, {numbers.Item3}");

var tuple = ("Hello", 100, true, 3.14);
Console.WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}");

(string, int) alice = ("Alice", 25);
Console.WriteLine($"{alice.Item1}, {alice.Item2}");

(ushort Width, ushort Height) resolution = (1920, 1080);
Console.WriteLine($"해상도: {resolution.Width} x {resolution.Height}");

var copy = bob;
copy.Item1 = "Joe";

Console.WriteLine($"원본: ({bob.Item1}, {bob.Item2})");
Console.WriteLine($"복사본: ({copy.Item1}, {copy.Item2})");

var bob2 = (name: "Bob", age: 23);
Console.WriteLine(bob2.name);
Console.WriteLine(bob2.age);
Console.WriteLine(bob2.Item1);
Console.WriteLine(bob2.Item2);

var order = (Name: "철수", IsStudent: true, OrderPrice: 1000);
Console.WriteLine($"{order.Name}(학생: {order.IsStudent}) - 주문: {order.OrderPrice:N0}원");

(string name, int age, char gender) bob3 = ("Bob", 23, 'M');
Console.WriteLine($"이름: {bob3.name}");
Console.WriteLine($"나이: {bob3.age}");
Console.WriteLine($"성별: {bob3.gender}");

var now = DateTime.Now;
var dateTuple = (now.Day, now.Month, now.Year);

Console.WriteLine($"일: {dateTuple.Day}");
Console.WriteLine($"월: {dateTuple.Month}");
Console.WriteLine($"년: {dateTuple.Year}");