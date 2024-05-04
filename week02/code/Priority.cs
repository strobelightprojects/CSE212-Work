public static class Priority
{
    public static void Test()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities
        // Expected Result: Items should be added to the queue in order
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Matt", 1);
        //Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Tim", 3);
        //Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Jake", 2);
        //Console.WriteLine(priorityQueue);

        Console.WriteLine("After Enqueue: " + priorityQueue);

        Console.WriteLine("---------");

        // Defect(s) Found: Items are added to the priority queue in order works fine

        // Test 2
        // Scenario: Dequeue items with different priorities
        // Expected Result: Items should be dequeued in the correct order of priority
        Console.WriteLine("Test 2");

        Console.WriteLine("Dequeued Item: " + priorityQueue.Dequeue());
        Console.WriteLine("After Dequeue: " + priorityQueue);

        Console.WriteLine("---------");

        // Defect(s) Found: Selected the right item to dequeue based on priority queue but didn't dequeue it

        // Test 3
        // Scenario: Enqueue multiple items with the same priority and dequeue
        // Expected Result: Items should be dequeued in the order they were enqueued
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jake", 2);
        priorityQueue.Enqueue("Matt", 2);

        Console.WriteLine("After Adding Items with Same Priority: " + priorityQueue);

        Console.WriteLine("Dequeued Item: " + priorityQueue.Dequeue());
        Console.WriteLine("After Dequeue: " + priorityQueue);

        Console.WriteLine("---------");
        // Defect(s) Found: It seems to selects the right item to be dequeued but doesn't actually dequeue it. 

        // Test 4
        // Scenario: Try to dequeue from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        Console.WriteLine("Dequeued Item: " + priorityQueue.Dequeue());

        Console.WriteLine("---------");
        // Defect(s) Found: none displays the error message 
    }
}