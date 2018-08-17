
/**
This class handles the queue of Customers and manipulations to it.
 @author Timothy Allen and Nick Kvigne
 */
public class Simulation
{

   private static final int MAX_CUSTOMER = 5; // capacity of line
   private Queue<Customer> q = new Queue<>(MAX_CUSTOMER);
   private int clock;
   private Customer being_served = null; // customer being served

   private int finished; // # of customers finished
   private int nowait; // # of customers that didn't wait
   private int waited; // # of customers that did wait
   private int totalwait; // total wait time of customers that waited
   private Customer newCust;
   
   /**
   This method creates a new customer and adds it to the queue if someone
   is already being served.
   */
   public void arrive()
   {
      newCust = (Customer) newCustomer();

      if (being_served == null)
      {
         being_served = newCust;
         nowait++;
      }
      else
      {
         q.enqueue(newCust);
      }
   }

   /**
   This method tells if the line is full.
   @return true if full, false otherwise
   */
   public boolean lineFull()
   {
      if (q.isFull())
      {
         return true;
      }
      return false;
   }

   /**
   This method handles a customer leaving, after being served.  
   */
   public void leave()
   {
      
      if (!q.isEmpty())
      {
         being_served = (Customer) q.dequeue();
         waited++;
         totalwait += clock - being_served.getTimestamp();
         finished++;
      }
      else
      {
         finished++;
         being_served = null;
      }
      
   }

   /**
   This method tells if the line is empty.
   @return true if empty, false otherwise
   */
   public boolean lineEmpty()
   {
      if (q.isEmpty())
      {
         return true;
      }

      return false;
   }

   /**
   This method updates the clock from the given time.
   @param time added to existing clock
   */
   public void updateClock(int time)
   {
      clock += time;
   }
   
   /**
   A getter method that returns the clock.
   @return 
   */
   public int getClock()
   {
      return clock;
   }

   /**
   A method that returns the size of the queue.
   @return size of queue
   */
   public int size()
   {
      return q.size();
   }

   /**
   A method that returns the proper information about the customer being 
   served.
   @return String of information about customer being served 
   */
   public String currentCust()
   {
      return being_served.toString();
   }

   /**
   A getter method that returns how many customers finished.
   @return finished
   */
   public int getFinished()
   {
      return finished;
   }

   /**
   A getter method that returns how many customers didn't wait.
   @return nowait
   */
   public int getNoWait()
   {
      return nowait;
   }

   /**
   A getter method that returns how many customers did wait.
   @return waited
   */
   public int getWaited()
   {
      return waited;
   }

   /**
   A getter method that returns how long all customers waited as a total.
   @return totalwait
   */
   public int getTotalWait()
   {
      return totalwait;
   }
   
   /**
   A method to check if the store is completely empty
   @return true if no one is served and line is empty, false otherwise
   */
   public boolean storeEmpty()
   {
      if(being_served == null && q.isEmpty())
      {
         return true;
      }
      return false;
   }
   
   /**
   A method that calculates the average wait time as a double.
   @return average wait
   */
   public double average()
   {
      return (double) totalwait / waited;
   }
   
   /**
   A method that creates and returns a new customer.
   @return new customer
   */
   public Object newCustomer()
   {
      Customer newCust = new Customer(clock);
      return newCust;
   }
   
   /**
   A getter method that returns the customer number.
   @return customer number
   */
   public int currentCustNum()
   {
      return being_served.getCustomerNo();
   }
   
   /**
   
   @param args 
   */
   public static void main (String [] args)
   {
      
   }
}
