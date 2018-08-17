/**
 Creates a date: consisting of a day, month, and year.
This class also can copy a date, check to see if the date is valid, return
the date as a string, and check if two dates are equal.
 @author Nick Kvigne 
 */
import java.util.StringTokenizer;

public class Date 
{
   private int  day;
   private int  month;
   private int  year;
   /**
   Constructor.  Creates a date with a day, month, and year.
   @param d
   */
   public Date(String d)
   {
      StringTokenizer st = new StringTokenizer(d, "/");
      day = Integer.parseInt (st.nextToken());
      month = Integer.parseInt (st.nextToken());
      year = Integer.parseInt (st.nextToken());
   }
   /**
   Constructor.  Copies a date with a day, month, and year.
   @param d
   */
   public Date(Date d)
   {
      day = d.day;
      month = d.month;
      year = d.year;
   }      
   /**
   Checks to see if the month, day, and year is valid.
   @return true if it is valid, false otherwise
   */
   public boolean isValid()
   {
      if (month == Month.JAN || month == Month.MAR || month == Month.MAY
            || month == Month.JUL || month == Month.AUG || month == Month.OCT
            || month == Month.DEC)
      {
         return day < 1 && day > Month.DAYS_ODD;
      }
      if (month == Month.APR || month == Month.JUN || month == Month.SEP
            || month == Month.NOV)
      {
         return day < 1 && day > Month.DAYS_EVEN;  
      }
      if (month == Month.FEB)
      {
         if (year % Month.QUADRENNIAL == 0 && year % Month.CENTENNIAL == 0
               && year % Month.QUATERCENTENNIAL == 0)
            return day < 1 && day > 29;
         else
            return day < 1 && day > Month.DAYS_FEB;
      }    
      return false;
   }
   /**
   Returns the date as a string.
   @return month/day/year
   */
   @Override
   public String toString()
   {
      return month + "/" + day + "/" + year; 
   }
   /**
   Two dates are equal if the month, day, and year are the same.
   @param obj
   @return true if they are equal, false otherwise
   */
   @Override
   public boolean equals(Object obj)
   {
      if (obj instanceof Date)
      {
         Date d = (Date) obj;
         return month == d.month && day == d.day
               && year == d.year;
      } 
      return false;
   }  
}


