using System;
using Ucu.Poo.Restaurant;

class Program
{
    static void Main(string[] args)
    {
        // Crear algunos platillos
        Dish dish1 = new Dish("Pizza Margherita", 8.50, true);
        Dish dish2 = new Dish("Spaghetti Carbonara", 7.75, false);
        Dish dish3 = new Dish("Lasagna", 9.25, false);

        // Crear un menú y agregar platillos
        Menu menu = new Menu();
        menu.AddDish(dish1);
        menu.AddDish(dish2);
        menu.AddDish(dish3);

        // Crear una mesa
        Table table1 = new Table(1);
        table1.Occupy();

        // Agregar platillos a la orden de la mesa
        table1.AddToOrder(dish1);
        table1.AddToOrder(dish2);

        // Crear un mozo y asignar una mesa
        Waiter waiter1 = new Waiter("John Doe");
        waiter1.AssignTable(table1);

        // Tomar una orden para la mesa
        waiter1.TakeOrder(table1, dish3);

        // Obtener y mostrar el total de la orden
        double total = table1.GetTotal();
        Console.WriteLine($"Total de la orden en la mesa {table1.Number}: ${total}");

        // Liberar la mesa y mostrar si está ocupada
        table1.Free();
        Console.WriteLine($"La mesa {table1.Number} está ocupada: {table1.IsOccupied}");
    }
}