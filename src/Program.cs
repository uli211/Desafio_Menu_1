using Ucu.Poo.Restaurant;

class Program
{
    static void Main(string[] args)
    {
        // Crear platillos.
        Dish pasta = new Dish("Pasta", 12.99, true);
        Dish steak = new Dish("Steak", 25.50, false);

        // Crear el menú y agregar platillos.
        Menu menu = new Menu();
        menu.AddDish(pasta);
        menu.AddDish(steak);

        // Mostrar el menú.
        Console.WriteLine("Menú del restaurante:");
        menu.ShowMenu();

        // Crear una mesa y un mozo.
        Table table1 = new Table(1);
        Waiter waiter1 = new Waiter("Juan");

        // Asignar la mesa al mozo y ocuparla.
        waiter1.AssignTable(table1);
        table1.Occupy();

        // Tomar pedidos.
        waiter1.TakeOrder(table1, pasta);
        waiter1.TakeOrder(table1, steak);

        // Mostrar la orden de la mesa.
        table1.ShowOrder();

        // Liberar la mesa y mostrar el estado.
        table1.Free();
        Console.WriteLine("Mesa liberada.");
        Console.WriteLine($"Mesa {table1.Number} ocupada: {table1.IsOccupied}");
    }
}