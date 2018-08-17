
/**
 Creates basic account
 @author Timothy Allen and Nick Kvigne
 */
public abstract class Account
{

   private static int numAccount = 1000;
   protected final int PERCENTAGE = 100;
   protected final int MONTH_PER_YEAR = 12;
   protected Profile holder;
   protected int accNumber;
   protected double balance;
   protected Date openOn;

   /**
   Constructor. Creates a new account with an account number, balance,
    open date, account holder.
   @param name, owner of account
   @param phone, phone number associated with account
   */
   public Account(String name, String phone)
   {
      accNumber = ++numAccount;
      balance = 0;
      openOn = new Date();
      holder = new Profile(name, phone);
   }
   
   /**
   Constructor. Creates a new account with a account number, given balance,
   given open date, account holder.
   @param name owner of account
   @param phone phone number associated with account
   @param date date opened
   @param newBal balance with the account
   */
   public Account(String name, String phone, String date, Double newBal)
   {
      accNumber = ++numAccount;
      balance = newBal;
      openOn = new Date (date);
      holder = new Profile(name, phone);
   }
   

   /**
    abstract, apply interest rate and account fee
    */
   public abstract void applyInterestAndFee();

   /**
    abstract, account info
    */
   public abstract String toString();

   /**
   Checks to see if two accounts are the same
   @param obj Account checked for equality
   @return true if accounts equal, false otherwise
   */
   public boolean equals(Object obj)
   {
      if (obj instanceof Account)
      {
         Account a = (Account) obj;
         return (holder.equals(a.holder));
      }
      return false;
   }
   
   /**
   Subtract an amount from the balance
   @param amount, amount to be subtracted 
   */
   public void debit(double amount)
   {
     balance -= amount; 
   }
   
   /**
   Add an amount to the balance
   @param amount, amount to be added 
   */
   public void credit(double amount)
   {
      balance += amount;
   }

   /**
    Getter method for account balance
    @return balance of the account
    */
   public double getBalance()
   {
      return balance;
   }

   /**
    Getter method for account open date
    @return openOn string of the open date of the account
    */
   public String getDate()
   {
      return openOn.toString();
   }

   /**
    Getter method for account number
    @return accNumber unique number of account
    */
   public int getAccNum()
   {
      return accNumber;
   }
   
   /**
   Getter method for the open date as a date
   @return openOn as a Date
   */
   public Date getOpenDate()
   {
      return openOn;
   }
   
   
}
