/**
 Money Market account subclass
 @author Timothy Allen and Nick Kvigne
 */

public class MoneyMarket extends Account
{
   private static final int FEE = 12;
   private static final double APY = .0065;
   private static final double MIN_BAL = 2500;
   private static final int WITHDRAW_LIMIT = 6;
   private int withdrawls;
   
   /**
   Default constructor
   @param name, name on account
   @param phone, phone number on account
   */
   public MoneyMarket(String name, String phone)
   {
      super(name,phone);
   }
   
   /**
   
   @param name
   @param phone
   @param date
   @param newBal
   @param withdraw 
   */
   public MoneyMarket(String name, String phone, String date, Double newBal, int withdraw )
   {
      super(name, phone, date, newBal);
      withdrawls = withdraw;
   }
   
   /**
   apply interest and fee for account
   */
   public  void applyInterestAndFee()
   {
      double newBal = 0;
      double interest = ((balance * APY) / MONTH_PER_YEAR);
      
      if (balance < MIN_BAL || withdrawls > WITHDRAW_LIMIT)
      {
         newBal = balance + interest - FEE;
      }
      else
      {
         newBal = balance + interest;
      }

      balance = newBal;
   }
   
   /**
   
   */
   public void incWith()
   {
      withdrawls++;
   }
   
   /**
   Returns string of money market account info
   @return String, money market account info
   */
   public String toString()
   {
         return "Money Market***" + accNumber + "***" + holder.toString()
               + " (opened on " + openOn.toString()
               + ")  balance: $" + balance + " Withdrawls: " + withdrawls;
   }
   
}
