using OrderProgram.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OrderProgram.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItens> Items { get; set; } = new List<OrderItens>();
        public Client Client { get; set; }

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status,Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItens(OrderItens items)
        {
            Items.Add(items);
        }
        public void RemoveItens(OrderItens items)
        {
            Items.Remove(items);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItens item in Items)
            {
                sum += item.SubTot();
            }
            return sum;

        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString());
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Itens: ");
            foreach(OrderItens orderitems in Items)
            {
                sb.AppendLine(orderitems.ToString());
            }
            sb.AppendLine("Total: $" + Total());
            return sb.ToString();
        }
    }
}
