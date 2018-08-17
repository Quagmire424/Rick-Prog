/**
 This class creates a Customer.
 @author Timothy Allen and Nick Kvigne
 */
public class Customer 
{
   private static int numCustomer = 0;
   private int customerNo;
   private int timeStamp;
   
   /**
   Constructor. Creates a new customer with a customer number and timestamp.
   @param time is when customer came in
   */
   public Customer(int time)
   {
      customerNo = ++numCustomer;
      timeStamp = time;
   }
   
   /**
   A getter method that returns the time the customer arrived.
   @return timeStamp
   */
   public int getTimestamp()
   {
      return timeStamp;
   }
   
   /**
   A method that returns a String containing the customer info.
   @return String of info on customer
   */
   public String toString()
   {
      return "Customer#" + customerNo + " arrived @time " + timeStamp; 
   }
   
   /**
   A getter method that returns the customer number.
   @return customerNo
   */
   public int getCustomerNo()
   {
      return customerNo;
   }

}
