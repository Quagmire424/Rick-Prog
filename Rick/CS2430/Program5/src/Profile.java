/**
 
 @author Timothy Allen and Nick Kvigne
 */
public class Profile 
{
   private String name;
   private String phone;
   
   public Profile (String n, String p)
   {
      name = n;
      phone = p;
   }
   
   public String toString()
   {
      return name + ": " + phone;
   }
   
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
