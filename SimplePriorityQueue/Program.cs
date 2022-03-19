using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePriorityQueue {
    class Program {
        public class ExampleData : IComparable<ExampleData> {
            public string Name { get; set; }
            public float Priority { get; set; }

            //higher priority first
            public int CompareTo(ExampleData other) {
                return Priority.CompareTo(other.Priority);
            }

            //implement to update the priority of an existing object
            public override bool Equals(object obj) {
                return obj is ExampleData data &&
                       Name.Equals(data.Name);
            }
            public override int GetHashCode() {
                return Name.GetHashCode();
            }

            public override string ToString() {
                return "{ Name: " + Name + ", Priority: " + Priority.ToString() + " }";
            }
        }

        static void Main(string[] args) {
            PriorityQueue<ExampleData> priorityQueue = new PriorityQueue<ExampleData>();
            ExampleData toUpdate = new ExampleData() { Name = "Peter", Priority = 0.5f };
            priorityQueue.Add(new ExampleData() { Name = "Josh", Priority = 1.0f });
            priorityQueue.Add(new ExampleData() { Name = "Joe", Priority = 2.5f });
            priorityQueue.Add(new ExampleData() { Name = "Mark", Priority = 2.5f });
            priorityQueue.Add(toUpdate);

            Console.WriteLine("Queue contains " + priorityQueue.Count + " elements");
            Console.WriteLine("Poll " + priorityQueue.Poll());
            Console.WriteLine("Peek " + priorityQueue.Peek());
            Console.WriteLine("Queue contains " + priorityQueue.Count + " elements");

            toUpdate.Priority = 5.0f;
            priorityQueue.Update(toUpdate);
            Console.WriteLine("Poll " + priorityQueue.Poll());
            Console.Read();
        }
    }
}
