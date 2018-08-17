/**
 
 @author Timothy Allen and Nick Kvigne
 */
public class MoneyMarket extends Account
{
   private static final int FEE = 12;
   private static final double APY = .0065;
   private static final double MIN_BAL = 2500;
   private static final int WITHDRAW_LIMIT = 6;
   private int withdrawls;
   
   public MoneyMarket(String name, String phone)
   {
      super(name,phone);
   }
   
   public  void applyInterestAndFee()
   {
   }
   
   public String toString()
   {
         return "Money Market *** " + accNumber + " *** " + holder.toString()
               + " (" + openOn.toString()
               + ")  balance: $" + balance;
   }

}
