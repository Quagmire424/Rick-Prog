/**
 Savings account subclass
 @author Timothy Allen and Nick Kvigne
 */
public class  Savings extends Account
{
   private static final int FEE = 5;
   private static final double APY = .0025;
   private static final double SPECIAL_INTERESTRATE = .0035;
   private static final double MIN_BAL = 300;
   private boolean special;
   
   /**
   Default constructor 
   @param name, name of account owner
   @param phone, phone number associated with account
   @param specialSav, if account is a special savings account or not 
   */
   public Savings(String name, String phone, boolean specialSav)
   {
      super(name,phone);
      special = specialSav;
   }
   
   /**
   
   @param name
   @param phone
   @param date
   @param newBal
   @param specialSav 
   */
   public Savings(String name, String phone, String date, Double newBal, boolean specialSav )
   {
      super(name, phone, date, newBal);
      special = specialSav;
   }

   /**
   Apply interest and account fee
   */
   public  void applyInterestAndFee()
   {
      double newBal = 0;
      double interest = ((balance * APY) / MONTH_PER_YEAR);;
      
      if (special == true)
      {
         interest = ((balance * SPECIAL_INTERESTRATE) / MONTH_PER_YEAR );
      }
      
      if(balance >= MIN_BAL)
      {
         newBal = balance + interest;
      }
      else
      {
         newBal = balance + interest - FEE;
      }

      balance = newBal;
   }
   
   /**
   Returns string of savings account info
   @return String, info on savings account
   */
   public String toString()
   {
      String extra = "";
         if (special == true)
            extra = " special savings account";

         return "Savings***" + accNumber + "***" + holder.toString()
               + " (opened on " + openOn.toString() 
               + ")  balance: $" + balance + extra;
   }
}
