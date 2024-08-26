namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string Name { get; }
    private ArrayList assignedTables = new ArrayList();

    // Constructor para inicializar el nombre del mozo.
    public Waiter(string name)
    {
        this.Name = name;
    }

    // Método para asignar una mesa al mozo.
    public void AssignTable(Table table)
    {
        this.assignedTables.Add(table);
    }

    // Método para tomar un pedido y agregarlo a la orden de la mesa.
    public void TakeOrder(Table table, Dish dish)
    {
        if (this.assignedTables.Contains(table))
        {
            table.AddToOrder(dish);
        }
    }

    // Método para mostrar las mesas asignadas al mozo.
    public void ShowAssignedTables()
    {
        Console.WriteLine($"Mesas asignadas al mozo {Name}:");
        foreach (Table table in assignedTables)
        {
            Console.WriteLine($"Mesa {table.Number}");
        }
    }
}