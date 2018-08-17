/**
 This class creates a general queue and holds the methods that can
 make changes to that queue.
 @author Timothy Allen and Nick Kvigne
 */
public class Queue <E>
{
   private E [] elements;
   private int front, rear, count;

   /**
   Constructor that creates an instance of the queue.
   @param capacity how large the queue is made
   */
   public Queue(int capacity)
   {
      elements = (E[]) new Object[capacity];
      front = rear = count = 0;
   }

   /**
   A method to add an Object to the rear of the queue.
   @param x 
   */
   public void enqueue(E x)
   {
      elements[rear] = x;
      rear = (rear + 1) % elements.length;
      count++;
   }

   /**
   A method to remove the Object from the front of the queue.
   @return object removed from front
   */
   public Object dequeue()
   {
      Object x = elements[front];
      front = (front + 1) % elements.length;
      count--;
      return x;
   }

   /**
   A method to check to see if the queue is empty.
   @return true if empty, false if not
   */
   public boolean isEmpty()
   {
      return count == 0;
   }

   /**
   A method to check to see if the queue is full.
   @return true if full, false if not
   */
   public boolean isFull()
   {
      return count == elements.length;
   }

   /**
   A method to clear out the queue and reset the line.
   */
   public void clear()
   {
      count = 0;
      front = 0;
      rear = 0;
   }

   /**
   A method to return how many Objects in the queue.
   @return count
   */
   public int size()
   {
      return count;
   }

}