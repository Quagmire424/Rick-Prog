/**
This class creates a shopping bag of groceries.  This class can also find
items in the bag, check to see if the bag is full or empty, add/remove
items, figure the total amount of all the items, and print all the items
in the bag.
@author Nick Kvigne 
*/
public class ShoppingBag 
{
   final static int MAX_ITEM = 8; 
   final static int NOT_FOUND = -1;
   GroceryItem [] bag;
   int numItems;
   /**
   Default constructor to create an empty shopping cart.
   */
   public ShoppingBag()
   {
      bag = new GroceryItem[MAX_ITEM];
      numItems = 0;
   } 
   /**
   Finds and returns index of item in bag.  Returns -1 if item is not in bag. 
   @param item 
   @return index of item if in bag, otherwise NOT_FOUND. 
   */
   private int find(GroceryItem item)
   {
      for (int i = 0; i < numItems; i++)  
      {
         if(item.equals(bag[i]))
            return i;
      }  
      return NOT_FOUND;
   }
   /**
   Checks to see if the bag is empty. 
   @return true if the bag is empty, false otherwise.  
   */
   public boolean isEmpty()
   {
      return numItems == 0;
   }
   /**
   Checks to see if the bag is full. 
   @return true if the bag is full, false otherwise.  
   */
   public boolean isFull()
   {
     return numItems == MAX_ITEM;  
   }
   /**
   Adds the given item into the bag. 
   @param item  
   */
   public void add(GroceryItem item)
   {
      bag[numItems++] = item;
   }
   /**
   Removes given item from the bag.  The index of the item is found, the 
   last item is moved to that index, then the index of the moved item is 
   set to null.
   @param item 
   @return false if item is not in bag, true if item is in bag and removed.  
   */
   public boolean remove(GroceryItem item)
   {
      int pos = find(item);
      if(pos == -1)
         return false;
      bag[pos] = bag[--numItems];
      bag[numItems] = null;
      return true;
   }
   /**
   Calculates and returns total of all item prices in bag. 
   */
   public double totalAmount()
   {
      double total = 0;
      for(int i = 0; i < numItems; i++)
         total += bag[i].getPrice();
      return total;
   }
   /**
    Output all items in the cart.
   */
   public void print()
   {
      for (int i = 0; i < numItems; i++)
      //call the toString() method in the GroceryItem class  
         System.out.println(bag[i].toString());
   }
}
