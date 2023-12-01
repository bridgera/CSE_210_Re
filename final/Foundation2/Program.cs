using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1048 Liman Road", "Rigby", "ID", "US");
        Costumer costumer = new Costumer("Bridger", address);

    // ORDER 1
        Order order1 = new Order(costumer);
        order1.AddProduct("Slsy Folding Bed Cot with 3.3 Inch Mattress", "1192920", 58.99, 2);
        order1.AddProduct("Invicta Pro Diver Two-tone Black Dial Men's Watch", "26973", 44.98, 1);
        order1.AddProduct("Spalding, Adult Men's 30-Pack No-Show Socks", "926117", 9.98, 4);

        order1.DisplayInfo();

    // ORDER 2
        Order order2 = new Order(costumer);
        order2.AddProduct("Roc Inflatable Stand Up Paddle Board with Premium sup Accessories", "73789234", 199.99, 2);
        order2.AddProduct("SANOPY 10' x 10' Straight Leg Pop-up Canopy Tent", "345546", 89.49, 1);
        order2.AddProduct("Segmart Golf Rangefinder, 900 Yards 7X", "4432997", 56.99, 1);

        order2.DisplayInfo();
    }
}