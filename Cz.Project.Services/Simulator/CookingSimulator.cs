using Cz.Project.Domain;
using Cz.Project.Dto.Enums;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cz.Project.Services.Simulator
{
    public class CookingSimulator : ICookingSimulator
    {
        private List<ICookingNotifier> _observers = new List<ICookingNotifier>();
        private ConcurrentBag<Tuple<Order, DateTime>> CookingOrders = new ConcurrentBag<Tuple<Order, DateTime>>();
        Task simulatorTask;
        bool endTask = false;

        public static CookingSimulator Instance { get; private set; }

        private CookingSimulator() { }

        public static CookingSimulator GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CookingSimulator();

                Instance.SetCookingProcessOrders();
            }

            return Instance;
        }

        public void StartProcess()
        {
            if (simulatorTask == null)
                Instance.simulatorTask = Task.Factory.StartNew(() => StartSimulator());
        }

        private Task StartSimulator()
        {
            while (!this.endTask)
            {
                var cookingOrders = new ConcurrentBag<Tuple<Order, DateTime>>();

                foreach (var orderAndDate in CookingOrders)
                {
                    if (DateTime.Now > orderAndDate.Item2)
                        OrderReady(orderAndDate.Item1);
                    else
                        cookingOrders.Add(orderAndDate);
                }

                this.CookingOrders = cookingOrders;
                Thread.Sleep(2000);
            }

            return Task.CompletedTask;
        }

        public void Attach(ICookingNotifier observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(ICookingNotifier observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void OrderReady(Order order)
        {
            new OrderService().ChangeOrderStatus(order.Id, StatusCodeEnum.WaitingForDeliver);
            this.Notify();
        }

        public void CheckNewOrders()
        {
            this.SetCookingProcessOrders();
        }

        private DateTime SimulateCookingTime()
        {
            var random = new Random();
            return DateTime.Now.AddSeconds(random.Next(15, 20));
        }

        private void SetCookingProcessOrders()
        {
            this.CookingOrders.Clear();
            var orders = new OrderService().GetByStatus(StatusCodeEnum.InCookingProcess);

            foreach (var order in orders)
            {
                this.CookingOrders.Add(new Tuple<Order, DateTime>(order, this.SimulateCookingTime()));
            }
        }
    }
}
