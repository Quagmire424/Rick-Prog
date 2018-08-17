
/**
 Growable bank database that holds accounts
 @author Timothy Allen and Nick Kvigne
 */
public class BankDatabase
{
   private static final int GROW_SIZE = 2;
   private static final int NOT_FOUND = -1;
   private Account[] bank;
   private int num;

   /**
    Default constructor, to create a new bankDatabase
    */
   public BankDatabase()
   {
      bank = new Account[GROW_SIZE];
      num = 0;
   }

   /**
   Finds if an account is in database based off of the account
   @param a, passed account object.
   @return index of account if found, NOT_FOUND if not in list
   */
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

   /**
   Finds if an account is in database based off of the account number
   @param accno passed account number
   @return index of account if found, NOT_FOUND if not in list
   */
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

   /**
    Grows the size of database list array if it is full.
    */
   private void grow()
   {
      Account temp[] = new Account[bank.length + GROW_SIZE];

      for (int i = 0; i < num; i++)
      {
         temp[i] = bank[i];
      }

      bank = temp;
   }

   /**
   Adds an account to database if it isn't already in database.
   @param a account to be added
   @return true if added, false if already in database
   */
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

   /**
   Removes an account from the database if it is in the database
   @param a account to be removed
   @return true if removed, false if not found in database
   */
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

   /**
   Checks to see if database contains given account
   @param a account that is being found in database
   @return true if a is in database, false if not
   */
   public boolean contains(Account a)
   {
      int index = find(a);

      if (index == NOT_FOUND)
      {
         return false;
      }

      return true;
   }

   /**
    Returns a string containing accounts in database
    @return line, string containing accounts
    */
   public String toString()
   {
      String line = "";

      for (int i = 0; i < num; i++)
      {
         line += bank[i].toString() + "\n";
      }

      return line;
   }

   /**
   Checks to see if database is empty
   @return true if database is empty, false otherwise
   */
   public boolean isEmpty()
   {
      if (num == 0)
      {
         return true;
      }

      return false;
   }

   /**
   Current size of the database
   @return num, which is size of database
   */
   public int size()
   {
      return num;
   }

   /**
   Removes an account from the database and moves the rest up in the list
   @param accno account number to be removed
   @return true if removed, false if not found in the database
   */
   public boolean remove(int accno)
   {
      int index = find(accno);

      if (index == NOT_FOUND)
      {
         return false;
      }

      for (int i = index; i < num; i++)
      {
         bank[i] = bank[i + 1];
      }
      bank[num] = null;
      num--;

      return true;
   }

   /**
   Deposits amount into the account
   @param accno number of account in database
   @param amount amount to be deposited
   @return 
   */
   public Account deposit(int accno, int amount)
   {
      bank[find(accno)].credit(amount);
      return bank[find(accno)];
   }

   /**
   Withdraws money from the account
   @param accno number of account in database
   @param amount amount to be withdrawn
   @return account which was withdrawn from
   */
   public Account withdraw(int accno, int amount)
   {
      Account temp = bank[find(accno)];
      temp.debit(amount);
      if (temp instanceof MoneyMarket)
      {
         MoneyMarket m = (MoneyMarket) temp;
         m.incWith();
      }
      return temp;
   }

   /**
   Applies interest and fees to all accounts in database
   */
   public void runInterest()
   {
      for (int i = 0; i < num; i++)
      {
         bank[i].applyInterestAndFee();
      }
   }

   /**
   Getter method to get the open date of an account
   @param i index of account
   @return date of indexed account
   */
   public Date getStartDate(int i)
   {
      return bank[i].getOpenDate();
   }
   
   /**
   Getter method to get the balance of an account
   @param accno account number being accessed
   @return balance of specified account
   */
   public double getAcctBal(int accno)
   {
      return bank[find(accno)].getBalance();
   }
   
   /**
   Getter method to get the account information as a string
   @param i index of account
   @return indexed account information as a string
   */
   public String toStringDate (int i)
   {
      return bank[i].toString();
   }

}
