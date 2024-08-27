using System.Collections.Generic; // Importar el espacio de nombres correcto

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        public int Number { get; private set; }
        public bool IsOccupied { get; private set; }
        private Order order;

        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        public void Occupy()
        {
            this.IsOccupied = true;
            this.order = new Order();
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order = null;
        }

        public void AddToOrder(Dish dish)
        {
            if (this.order != null)
            {
                this.order.AddDish(dish);
            }
        }

        public double GetTotal()
        {
            if (this.order != null)
            {
                return this.order.GetTotal();
            }
            return 0;
        }

        public bool HasOrders()
        {
            return this.order != null && this.order.GetTotal() > 0;
        }
    }
}