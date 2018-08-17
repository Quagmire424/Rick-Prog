/**
Creates a grocery item with a name and price.
This class also has a test to see if two items are equal, can return
the name and price in a specific format, and return the item's price.
@author Nick Kvigne 
*/
public class GroceryItem 
{
   private String name;
   private double price;
   /**
   Constructor.  Creates a new grocery item with the input name and price.
   @param n Grocery name
   @param p Price
   */
   public GroceryItem(String n, double p)
   {
      name = n;
      price = p;
   }    
   /**
   Two grocery items are equal if they have the same name and same price.
   @param obj
   @return true if they are equal, false otherwise.
   */
   public boolean equals(Object obj)
   {
      if (obj instanceof GroceryItem) 
      {
         GroceryItem g = (GroceryItem) obj;
         return name.equals(g.name) && price == g.price; 
      } 
      return false;
   }      
   /**
   Return the name and price of the item as a String.
   @return name::price as a string.
   */
   public String toString()
   {
      return name + "::" + price;
   }
   /**
   Return the price of the grocery item.
   @return price
   */
   public double getPrice()
   {
      return price;
   }
}
