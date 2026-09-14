using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items with different priorities and dequeue them.
    // Expected Result: The item with the highest priority should be returned first,
    // followed by the next highest priority.
    // Defect(s) Found: Not tested yet.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("High Priority", 3);
        priorityQueue.Enqueue("Medium Priority", 2);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();
        var third = priorityQueue.Dequeue();

        Assert.AreEqual("High Priority", first);
        Assert.AreEqual("Medium Priority", second);
        Assert.AreEqual("Low Priority", third);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority and dequeue them.
    // Expected Result: Items with the same priority should be returned in the
    // same order that they were added to the queue.
    // Defect(s) Found: Not tested yet.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();
        var third = priorityQueue.Dequeue();

        Assert.AreEqual("First", first);
        Assert.AreEqual("Second", second);
        Assert.AreEqual("Third", third);
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue.
    // Expected Result: An InvalidOperationException should be thrown with
    // the message "The queue is empty."
    // Defect(s) Found: Not tested yet.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    [TestMethod]
    // Scenario: Add an item to the queue and then dequeue it.
    // Expected Result: The item that was added should be returned.
    // Defect(s) Found: Not tested yet.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Customer", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Customer", result);
    }

    // Add more test cases as needed below.
}