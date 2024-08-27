using System.Collections.Generic; // Importar el espacio de nombres correcto

namespace Ucu.Poo.Restaurant
{
    public class Waiter
    {
        public string Name { get; private set; }
        private List<Table> assignedTables = new List<Table>(); // Cambiar a List<Table>

        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (this.assignedTables.Contains(table))
            {
                table.AddToOrder(dish);
            }
        }

        public double GetTotal(Table table)
        {
            if (this.assignedTables.Contains(table))
            {
                return table.GetTotal();
            }
            return 0;
        }
    }
}