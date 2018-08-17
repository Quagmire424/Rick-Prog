
/**
 Checking account subclass

 @author Timothy Allen and Nick Kvigne
 */
public class Checking extends Account
{

   private static final int FEE = 25;
   private static final double APY = .0005;
   private static final double MIN_BAL = 1500;
   private boolean directDeposit;

   /**
    Default constructor for checking account

    @param name, owner of account
    @param phone, phone number associated with account
    @param direct, if the account has direct deposit
    */
   public Checking(String name, String phone, boolean direct)
   {
      super(name, phone);
      directDeposit = direct;
   }
   
   /**
   
   @param name
   @param phone
   @param date
   @param newBal
   @param direct 
   */
   public Checking(String name, String phone, String date, Double newBal, boolean direct )
   {
      super(name, phone, date, newBal);
      directDeposit = direct;
   }

   /**
    Apply interest and fee for checking account
    */
   public void applyInterestAndFee()
   {
      double newBal = 0;
      double interest = ((balance * APY) / MONTH_PER_YEAR);;
      
      if (balance >= MIN_BAL || directDeposit == true)
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
    Returns string of checking account info

    @return String of checking account info
    */
   public String toString()
   {
      String extra = "";
      if (directDeposit == true)
      {
         extra = " direct deposit account";
      }

      return "Checking***" + accNumber + "***" + holder.toString()
            + " (opened on " + openOn.toString() + ")  balance: $"
            + balance + extra;
   }
}
