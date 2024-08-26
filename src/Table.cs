namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public int Number { get; }
    public bool IsOccupied { get; private set; }
    private ArrayList order = new ArrayList();

    // Constructor para inicializar la mesa con un número.
    public Table(int number)
    {
        this.Number = number;
        this.IsOccupied = false;
    }

    // Método para marcar la mesa como ocupada.
    public void Occupy()
    {
        this.IsOccupied = true;
    }

    // Método para liberar la mesa y vaciar los pedidos.
    public void Free()
    {
        this.IsOccupied = false;
        this.order.Clear();
    }

    // Método para agregar un platillo a la orden.
    public void AddToOrder(Dish dish)
    {
        if (this.IsOccupied)
        {
            this.order.Add(dish);
        }
    }

    // Método para determinar si la mesa tiene pedidos.
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }

    // Método para mostrar la orden actual.
    public void ShowOrder()
    {
        Console.WriteLine($"Mesa {Number}:");
        foreach (Dish dish in order)
        {
            Console.WriteLine(dish.ToString());
        }
    }
}