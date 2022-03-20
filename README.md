# SimplePriorityQueue
Simple priority queue data structure with support for update operations designed for pathfinding algorithm.  

## Sample code

```C#
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
```
