namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private ArrayList order = new ArrayList();
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}