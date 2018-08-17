/**
This class reads commands and manipulates the shopping bag.
Takes input of grocery items, adds and removes items from the bag, 
prints items in the bag, and checks out the items in the bag.
@author Nick Kvigne 
*/
import java.util.Scanner;

public class Shopping 
{
   ShoppingBag mybag;
   Scanner stdin;
   /**
   This method takes in input and calls the proper command on the shopping
   bag.  Commands include Q, A, R, P, and C.  These can be upper
   or lower case.
   */
   public void run()
   {
      stdin = new Scanner(System.in);
      mybag = new ShoppingBag();
      System.out.println("Let's start shopping!");
      String command = stdin.next();
      while ( !command.equalsIgnoreCase("Q"))
      {
         if (command.equalsIgnoreCase("A"))
            add();
         else if (command.equalsIgnoreCase ("R"))
            remove();
         else if (command.equalsIgnoreCase ("P"))
            print();  
         else if (command.equalsIgnoreCase ("C"))
            checkout();
         else
         {  
            System.out.println("Invalid command!");
            stdin.nextLine();//read the rest of the line and discard it
         }           
         command = stdin.next();          
      }
      System.out.println("Thanks for shopping with us!");
       
   } //run()
   /**
   Adds new item into the bag.  If the bag is full, an error message is 
   printed.  Otherwise, the item is added and a confirmation message is
   printed.
   */
   private void add()
   {
      if (mybag.isFull()) 
      {
         System.out.println("Unable to add, the bag is full!");
         stdin.nextLine();
      }   
      else
      {   
         String item = stdin.next();
         mybag.add(new GroceryItem(item, stdin.nextDouble()));
         System.out.println(item + " added to the bag.");
      }   
   } 
   /**
   Removes the item that is commanded to.  A message is printed out to tell
   user whether or not the item has been removed.
   */
   private void remove()
   {
      String item = stdin.next();
      boolean removed = mybag.remove
         (new GroceryItem(item, stdin.nextDouble()));
     
      if ( removed )
         System.out.println("Item removed successfully.");
      else
         System.out.println("Unable to remove, " 
               + "this item is not in the bag.");
   }
   /**
   Prints all the items in the bag.  If the bag is empty, an error message
   is printed.  Otherwise, a message is shown telling what is in the bag,
   followed by each item and its price.
   */
   private void print()
   {
      if  (mybag.isEmpty())
         System.out.println("Unable to print, the shopping bag is empty.");
      
      else
      {
         System.out.println("You have the following items in the bag: ");
         mybag.print();
      }
   } 
   /**
   List all items in the cart, remove all items in the cart and display the 
   amount paid.
   */
   private void checkout()
   {
      if (mybag.isEmpty())
         System.out.println("Unable to check out, "
               + "the shopping bag is empty.");
      else
      {  
         System.out.println("Checking out the following items: ");
         mybag.print();
         System.out.println("Amount paid: " + Math.round(mybag.totalAmount())
               + " dollars.");
         mybag = new ShoppingBag();
      }
   }
} //Shopping class
