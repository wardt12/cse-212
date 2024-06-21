public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        // Test Case 1: Enqueue items and check the queue
        Console.WriteLine("Test 1: Enqueue and check queue");
        priorityQueue.Enqueue("Task 1", 1);
        priorityQueue.Enqueue("Task 2", 1);
        priorityQueue.Enqueue("Task 3", 2);
        priorityQueue.Enqueue("Task 4", 3);
        Console.WriteLine($"Queue after enqueue: {priorityQueue}");
        Console.WriteLine();

        // Enqueue items with different priorities verify that the queue reflects the correct order after enqueueing.

         // Test Case 2: Dequeue items in priority order
        Console.WriteLine("Test 2: Dequeue items in priority order");
        try {
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // This should throw exception
        }
        catch (InvalidOperationException e) {
            Console.WriteLine($"Error message: {e.Message}");
        }
        Console.WriteLine($"Queue after dequeue: {priorityQueue}");
        Console.WriteLine();

        //Test 2: Enqueue items then dequeue them to verify that items are removed in priority order. 

        // Test Case 3: Attempt to dequeue from an empty queue
        Console.WriteLine("Test 3: Attempt to dequeue from an empty queue");
        try {
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // This should throw exception
        }
        catch (InvalidOperationException e) {
            Console.WriteLine($"Error message: {e.Message}");
        }
        Console.WriteLine();

        //Test 3: Attempt to dequeue from an initially empty queue to ensure that the correct exception is thrown.

         // Test Case 4: Enqueue items with ties in priority and verify FIFO order
        Console.WriteLine("Test 4: Enqueue items with ties in priority and verify FIFO order");
        priorityQueue.Enqueue("Task A", 2);
        priorityQueue.Enqueue("Task B", 3);
        priorityQueue.Enqueue("Task C", 3);
        Console.WriteLine($"Queue after enqueue: {priorityQueue}");
        try {
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
        }
        catch (InvalidOperationException e) {
            Console.WriteLine($"Error message: {e.Message}");
        }
        Console.WriteLine($"Queue after dequeue: {priorityQueue}");
        Console.WriteLine();

        Console.WriteLine("---------");

        // Test 4: Enqueue items with ties in priority (same priority for some items) and verify that they are dequeued in FIFO order among items with the same priority.

        
    }
}
