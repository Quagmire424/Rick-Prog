
/**
 
 @author Timothy Allen and Nick Kvigne
 */


import java.util.Calendar;

public class Date 
{
   private int  day;
   private int  month;
   private int  year;
   
   public Date()
   {
      Calendar c = Calendar.getInstance();
      this.day = c.get(Calendar.DAY_OF_MONTH);
      this.month = c.get(Calendar.MONTH) + 1;
      this.year = c.get(Calendar.YEAR);
   }

   /**
    Copy constructor
    */
   public Date(Date d)
   {
      day = d.day;
      month = d.month;
      year = d.year;
   }

//   /**
//    Checks to see if an entered date is valid. Makes sure that an entered
//    month is valid, then calls validDayRange().
//
//    @return true, if date is valid.
//    @return false, if date is not valid.
//    */
//   public boolean isValid()
//   {
//      if (month < Month.JAN || month > Month.DEC)
//      {
//         return false;
//      }
//
//      if (validDayRange() == false)
//      {
//         return false;
//      }
//
//      return true;
//   }
//
//   /**
//    Checks to make sure given day is possible, given the entered month. Calls
//    validLeapYear() if a date of Feb. 29 is entered.
//
//    @return true, if date range is valid.
//    @return false, if date range is invalid.
//    */
//   public boolean validDayRange()
//   {
//      if (month == Month.JAN || month == Month.MAR || month == Month.MAY
//            || month == Month.JUL || month == Month.AUG || month == Month.AUG
//            || month == Month.OCT || month == Month.DEC)
//      {
//         if (day < 1 || day > Month.DAYS_ODD)
//         {
//            return false;
//         }
//      }
//
//      if (month == Month.APR || month == Month.JUN || month == Month.SEP
//            || month == Month.NOV)
//      {
//         if (day < 1 || day > Month.DAYS_EVEN)
//         {
//            return false;
//         }
//      }
//
//      if (month == Month.FEB)
//      {
//         if (day < 1 || day >= Month.DAYS_EVEN)
//         {
//            return false;
//         }
//
//         if (day > Month.DAYS_FEB)
//         {
//            if (validLeapYear() == false)
//            {
//               return false;
//            }
//         }
//      }
//      return true;
//   }
//
//   /**
//    Checks if a given year is a leap year.
//
//    @return true, if year is a leap year.
//    @return false, if year is not a leap year.
//    */
//   public boolean validLeapYear()
//   {
//      if (year % Month.QUADRENNIAL != 0)
//      {
//         return false;
//      }
//      if (year % Month.CENTENNIAL == 0
//            && year % Month.QUATERCENTENNIAL != 0)
//      {
//         return false;
//      }
//
//      return true;
//   }

   /**
    Returns the month, day, and year as a String.

    @return month/day/year, as a string.
    */
   @Override
   public String toString()
   {
      return month + "/" + day + "/" + year;
   }

   /**
    Two entered dates are equal if they have the same date.

    @param obj
    @return true if they are equal, false otherwise.
    */
   @Override
   public boolean equals(Object obj)
   {
      if (obj instanceof Date)
      {
         Date d = (Date) obj;
         return (day == d.day) && (month == d.month) && (year == d.year);
      }
      return false;
   }
}
