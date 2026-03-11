using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
List<(string name, int quantity, int price)> inventory = new();

AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

Console.WriteLine("=== 아이템 인벤토리 ===");
foreach (var item in inventory)
{
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price:N0}원");
}

var mostExpensive = FindMostExpensive();
Console.WriteLine("\n=== 가장 비싼 아이템 ===");
Console.WriteLine($"이름: {mostExpensive.name}, 단가: {mostExpensive.price:N0}원");

var total = CalculateTotal();
Console.WriteLine("\n=== 인벤토리 합산 ===");
Console.WriteLine($"총 가치: {total.totalValue:N0}원");
Console.WriteLine($"총 아이템 수: {total.totalCount}개");

void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    var result = (name, quantity, price);
    inventory.Add(result);
}

(string name, int price) FindMostExpensive()
{
    int maxPrice = int.MinValue;
    string maxName = string.Empty;

    foreach (var item in inventory)
    {
        if (item.price > maxPrice)
        {
            maxPrice = item.price;
            maxName = item.name;
        }
    }

    return (maxName, maxPrice);
}

(int totalValue, int totalCount) CalculateTotal()
{
    int totalPrice = 0;
    int totalQuantity = 0;

    foreach (var item in inventory)
    {
        totalPrice += item.price * item.quantity;
        totalQuantity += item.quantity;
    }

    return (totalPrice, totalQuantity);
}