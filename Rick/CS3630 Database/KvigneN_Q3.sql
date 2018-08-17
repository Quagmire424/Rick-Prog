---------------------------------------------------------------------------------
-- Name       : Nick Kvigne
--
-- UserName   : KvigneN
--
-- Course     : CS363 
--
-- Section    : 10 AM
--
-- Description: Quiz 3
--
-- Date       : April 21, 2017

--Grade: 22/25
---------------------------------------------------------------------------------

prompt
prompt CS 3630 Quiz 3 
prompt Name    : Nick Kvigne
prompt UserName: KvigneN 
Prompt 

prompt
prompt 1. 
prompt Set column format 
Prompt 

set echo off
set feedback off

-- Column ClientNo is displayed as string of length 10 with heading "Client No"
-- Column DOB is displayed as string of length 12 with heading "Birth Day"
-- Column FirstName is displayed as string of length 10 with heading "First Name"
-- Column LastName is displayed as string of length 10 with heading "Last Name"
-- Column StaffNo is displayed as string of length 8 with heading "Staff No"
-- Column Count(*) is displayed with heading "Count"
-- Column State is displayed as string of length 6 with heading "State"
Col ClientNo Format a10 Heading 'Client No'
col DOB format a12 heading 'Birth Day'
col FirstName format a10 heading 'First Name'
col LastName format a10 heading 'Last Name'
col StaffNo format a8 heading 'Staff No'
col Count(*) format a5 heading 'Count'
col State format a6 heading 'State'


pause

prompt
prompt 2.
prompt List ClientNo, FirstName, LastName and DOB of all 
prompt clients, sorted on DOB in descending order,
prompt and then on last name in ascending order.
prompt DOB must be in the format mm/dd/yyyy, e.g., 12/04/1997.
prompt


Select ClientNo, FirstName, LastName, To_Char(DOB, 'mm/dd/yyyy')"Birth Day"
From Clients
Order by DOB desc, LastName;

-- Sample output
-- Client No  First Name Last Name  Birth Day                                      
-- ---------- ---------- ---------- ------------                                   
-- P0091      Mike       Rowe       11/08/1997                                     
-- P0051      Joe        Clifton    04/09/1995                                     



pause

prompt
prompt 3.
prompt List ClientNo, firstName and lastName of clients
prompt whose last name begins with a character Y or whose ZipCode is missing.
prompt 


Select ClientNo, FirstName, LastName
From Clients
Where LastName like 'Y%' 
      or
	  ZipCode is null;
	  
	  
-- Sample output
-- Client No  First Name Last Name                                                 
-- ---------- ---------- ----------                                                
-- P0091      Qi         Young                                                     
-- P0051      Frank      Rowe                                                      


pause

prompt
prompt 4.
prompt For each instructor and each class type (Starter, Local, HighWay), 
prompt list staffNo, class Type, and the number of classes the instructor 
prompt has for the specified type of class on April 11 2017,
prompt sorted by staffNo and then class type.
prompt


Select staffNo, Type, count(TimeStart)"Count"
From DrivingClasses
Where ClassDate = '11-Apr-17'
Group by staffNo, Type
Order by staffNo, Type;

-- Sample output
-- Staff No TYPE         COUNT                                                     
-- -------- ------- ----------                                                     
-- S01      Local            3                                                     
-- S02      HighWay          2                                                     
-- S02      Starter          5                                                     



pause

prompt
prompt 5.
prompt For each instructor who has at least one class 
prompt between April 11, 2017 and April 13, 2017 (inclusive),
prompt list the StaffNo and the number of such classes.
prompt

Select staffNo, count(TimeStart)"Count"
From DrivingClasses
Where (ClassDate >= '11-Apr-17' or ClassDate <= '13-Apr-17')
Group by staffNo
Having count(*) > 0;

-- Sample output
-- Staff No      Count                                                             
-- -------- ----------                                                             
-- S21               3                                                             
-- S12               9                                                             

--incorrect answer: -3

pause

prompt
prompt 6.
prompt For each instructor who has more than four classes
prompt in the current month, list the StaffNo and the number
prompt of classes the instructor has in the current month.
prompt The same query should work for any month of any year
prompt such as April 2017 and May 2017.
prompt

Select staffNo, count(TimeStart)"Count"
From DrivingClasses
Where To_Char(ClassDate,'mm') = To_Char(SysDate,'mm')
Group by staffNo
Having count(*) > 4;

-- Sample output
-- Staff No      Count                                                             
-- -------- ----------                                                             
-- S12               9                                                             



pause

prompt
prompt 7.
prompt Remove all column format
prompt 

clear col

