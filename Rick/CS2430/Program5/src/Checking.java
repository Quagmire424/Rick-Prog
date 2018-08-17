
/**

 @author Timothy Allen and Nick Kvigne
 */
public class Checking extends Account
{

   private static final int FEE = 25;
   private static final double APY = .0005;
   private static final double MIN_BAL = 1500;
   private boolean directDeposit;

   public Checking(String name, String phone, boolean direct)
   {
      super(name,phone);
      directDeposit = direct;
   }

   public void applyInterestAndFee()
   {
      
   }

   public String toString()
   {
      String extra = "";
      if (directDeposit == true)
         extra = " direct deposit account";
      
      return "Checking *** " + accNumber + " *** " + holder.toString()
            + " (" + openOn.toString() + ")  balance: $" 
            + balance + extra;
   }
   
  
}
