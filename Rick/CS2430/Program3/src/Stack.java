/**
 This class creates a general stack. 
 @author Nick Kvigne
 */
public class Stack 
{
   private Object [] elements;
   private int top;
   
   /**
   Constructor.  Creates a new stack with a given size.
   @param size 
   */
   public Stack(int size)
   {
      elements = new Object[size];
      top = 0;
   }
   
   /**
   Adds the given object to the top of the stack, adding 1 to top.
   @param obj 
   */
   public void push (Object obj)
   {
      elements[top++] = obj;
   }
   
   /**
   Returns the top element of the stack and subtracts 1 from top.
   @return 
   */
   public Object pop()
   {
      return elements[--top];
   }
   
   /**
   Sets top equal to 0, clearing the stack.
   */
   public void clear()
   {
      top = 0;
   }
   
   /**
   Checks if the stack is empty by checking if top equals 0.
   @return 
   */
   public boolean isEmpty()
   {
      return top == 0;
   }
}
