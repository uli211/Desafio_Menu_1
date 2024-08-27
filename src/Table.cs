using System.Collections;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        public int Number { get; }
        public bool IsOccupied { get; private set; }
        private ArrayList order = new ArrayList();

        public Table(int number)
        {
            Number = number;
            IsOccupied = false;
        }

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
            order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in order)
            {
                total += dish.Price;
            }
            return total;
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}