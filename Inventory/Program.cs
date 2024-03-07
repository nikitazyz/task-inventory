﻿namespace Inventory;

public static class Program
{
    private static void Main(string[] args)
    {
        Inventory inventory = new Inventory(20);
        Item sword = new Item("Sword", 1);
        Item shield = new Item("Shield", 2);
        Item healthPoison = new Item("Sword", 3);

        inventory.AddItem(sword, 2);
        Console.WriteLine(inventory.Weight);
        
        inventory.AddItem(shield, 4);
        Console.WriteLine(inventory.Weight);
        
        inventory.AddItem(healthPoison, -3);
        Console.WriteLine(inventory.Weight);

        inventory.RemoveItem(shield);
        Console.WriteLine(inventory.Weight);

        int countSwords = inventory.CountItem(sword);
        Console.WriteLine(countSwords);
    }
}
