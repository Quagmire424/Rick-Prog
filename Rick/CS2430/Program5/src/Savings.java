/**
 
 @author Timothy Allen and Nick Kvigne
 */
public class  Savings extends Account
{
   private static final int FEE = 5;
   private static final double APY = .0025;
   private static final double MIN_BAL = 300;
   private boolean special;
   
   public Savings(String name, String phone, boolean specialSav)
   {
      super(name,phone);
      special = specialSav;
   }

   public  void applyInterestAndFee()
   {
   }
   
   public String toString()
   {
      String extra = "";
         if (special == true)
            extra = " special savings account";

         return "Saving *** " + accNumber + " *** " + holder.toString()
               + " (" + openOn.toString() 
               + ")  balance: $" + balance + extra;
   }

}
