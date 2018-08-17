
/**

 @author Timothy Allen and Nick Kvigne
 */
public class BankDatabase
{

   private static final int GROW_SIZE = 2;
   private static final int NOT_FOUND = -1;
   private Account[] bank;
   private int num;

   public BankDatabase()
   {
      bank = new Account[GROW_SIZE];
      num = 0;
   }

   private int find(Account a)
   {
      for (int i = 0; i < num; i++)
      {
         if (a.equals(bank[i]))
         {
            return i;
         }
      }

      return NOT_FOUND;
   }

   private int find(int accno)
   {
      for (int i = 0; i < num; i++)
      {
         if (accno == bank[i].accNumber)
         {
            return i;
         }
      }
      return NOT_FOUND;

   }

   private void grow()
   {
      Account temp[] = new Account[bank.length + GROW_SIZE];

      for (int i = 0; i < num; i++)
      {
         temp[i] = bank[i];
      }

      bank = temp;
   }

   public boolean add(Account a)
   {
      if (contains(a))
      {
         return false;
      }
      
      if (num == bank.length)
      {
         grow();
      }
      
      bank[num++] = a;
      return true;
   }

   public boolean remove(Account a)
   {
      int index = find(a);

      if (index == NOT_FOUND)
      {
         return false;
      }

      bank[index] = bank[--num];
      bank[num] = null;

      return true;

   }

   public boolean contains(Account a)
   {
      int index = find(a);

      if (index == NOT_FOUND)
      {
         return false;
      }

      return true;
   }

   public String toString()
   {
      String line = "";
      for (int i = 0; i < num; i++)
      {
         line += bank[i].toString() + "\n";
         
      }
      return line;
   }

   public boolean isEmpty()
   {
      if (num == 0)
      {
         return true;
      }

      return false;
   }

   public int size()
   {
      return num;
   }
}
