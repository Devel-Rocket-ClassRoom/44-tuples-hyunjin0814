using System;

// README.md를 읽고 코드를 작성하세요.
var people1 = CreateStudent("철수", 16, 1);
var people2 = CreateStudent("영희", 17, 2);
var people3 = CreateStudent("민수", 18, 3);

Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(people1);
PrintStudent(people2);
PrintStudent(people3);

(string name, int age, int grade) = people1;
Console.WriteLine("\n=== 첫 번째 학생 분해 ===");
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"학년: {grade}");

(string name, int age, int grade) CreateStudent(string name, int age, int grade)
{
    return (name, age, grade);
}

void PrintStudent((string name, int age, int grade) student)
{
    Console.WriteLine($"{student.name} - 나이: {student.age}세, 학년: {student.grade}학년");
}