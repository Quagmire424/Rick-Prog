/**
 Account owner's name and phone number
 @author Timothy Allen and Nick Kvigne
 */
public class Profile 
{
   private String name;
   private String phone;
   
   /**
   Default constructor
   @param n, name of account owner
   @param p, phone number associated with account
   */
   public Profile (String n, String p)
   {
      name = n;
      phone = p;
   }
   
   /**
   Return string containing account owner's name and phone number
   @return String, containing name and phone
   */
   public String toString()
   {
      return name + ": " + phone;
   }
   
   /**
   Checks to see if two profiles have the same name and phone number
   @param obj, profile to be checked
   @return true, if passed profile already exist
   @return false, if passed profile doesn't match any other profile
   */
   public boolean equals (Object obj)
   {
      if (obj instanceof Profile)
      {
         Profile p = (Profile) obj;
         return (name.equals(p.name) && phone.equals(p.phone));
      }
      
      return false;
   }
}
