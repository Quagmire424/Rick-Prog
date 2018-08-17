/**
 
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
   
   public Account (String name, String phone)
   {
      accNumber = ++numAccount;
      balance = 0;
      openOn = new Date();
      holder = new Profile (name,phone);
   }
   
   public abstract void applyInterestAndFee();
   
   public abstract String toString();
   
   public boolean equals (Object obj)
   {
      if (obj instanceof Account)
      {
         Account a = (Account) obj;
         return (holder.equals(a.holder));
      }
      return false;
   }
   
   public double getBalance()
   {
      return balance;
   }
   
   public String getDate()
   {
      return openOn.toString();
   }
   
   public int getAccNum()
   {
      return accNumber;
   }
}
