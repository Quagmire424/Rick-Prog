
            Grade: 60/60

------------------------------------------------
-- Name    : Thomas Hubl
--
-- UserName: hublt
--
-- Course  : CS 3630
--           Test 2
--
-- Section : 2 (10 AM)
--
-- Date    : May-4-2016
------------------------------------------------

Prompt
Prompt Test 2
Prompt

Prompt 2 points on submission
Prompt
Prompt 2 points on style
Prompt

Column Tel_No    Heading "TEL NO"
Column "AVERAGE" Format $9,999.99
Column Rent      Format $9,999.99

Prompt (2 points)
Prompt 1. Drop Table UWP_Viewing even the table may not exist.
prompt

Drop table UWP_Viewing;

Pause
Prompt (4 points)
Prompt 2. Create table UWP_Viewing.
Prompt

Create Table UWP_Viewing (
	Rno        char(4) References UWP_Renter,
	Pno        char(4) References UWP_Property,
	VDate      date,
	TheComment Varchar2(50),
	Constraint PK_UWPViewing
		Primary Key(Rno, Pno, VDate));

--    Rno          String of 4 chars
--   Pno          String of 4 chars
--   VDate      Date
--   TheComment   String up to 50 chars
--
--   Primary Key   Rno, Pno, VDate
--   Foreign Key   Rno References UWP_Renter
--   Foreign Key   Pno References UWP_Property
--




Pause
Prompt (2 points)
Prompt 3. Show table schema of UWP_Viewing.
Prompt

desc UWP_Viewing

pause
Prompt (5 points)
Prompt 4. Insert records into table UWP_Viewing.
Prompt    The data may not be correct, and you may receive some error messages.
Prompt    You must insert all five records without changing the data.
Prompt    You just need to make sure your code is correct.
Prompt    You also need to make sure the records are saved back to the server.
Prompt
--   Rno    Pno        Vdate       TheComment
--   R001   P100      05-13-06     Too Large
--   R001   P300      05-14-06
--   R101   P300      05-15-15     Not good
--   R001   P303      05-16-16     Trouble maker
--   R001   P300                   Null value?


----------------------------------------------------------------
-- This changes the default date format to match Qi's inputs
alter session  set NLS_DATE_FORMAT='mm-dd-yy';
----------------------------------------------------------------

Insert into UWP_Viewing
	Values('R001', 'P100', '05-13-06', 'Too Large');

Insert into UWP_Viewing
	Values('R001', 'P300', '05-14-06', null);

Insert into UWP_Viewing
	Values('R101', 'P300', '05-15-15', 'Not good');

Insert into UWP_Viewing
	Values('R001', 'P303', '05-16-16', 'Trouble maker');

Insert into UWP_Viewing
	Values('R001', 'P300', null, 'Null value?');

commit;

pause
Prompt (2 points)
Prompt 5. Select all records from table UWP_Viewing
Prompt

Select *
From UWP_Viewing;

Pause
Prompt
Prompt (8 points)
Prompt 6.  List Pno, City, Rooms and Rent of all properties whose rent is in the
Prompt     range of 750 - 1200, inclusive, sorted on rooms in ascending order and
Prompt     then on pno in descending order
Prompt

Select pno, city, rooms, rent
From UWP_Property
Where rent between 750 and 1200
Order by rooms asc, pno desc;

pause
Prompt
Prompt (8 points)
Prompt 7.  Retrieve Pno, Rooms and Rent for all properties in
Prompt     Platteville that are currently NOT leased out, sorted on Pno.
Prompt     The same query should work at any time.
Prompt

Select Pno, Rooms, Rent
From      (Select *
		   From   UWP_Property
		   where  city = 'Platteville')
Where     pno not in (Select pr.pno
				      from   UWP_Property pr
                      --This join was unnecessary since I
                      --only needed pno and city (both in lease)
				      join   UWP_Lease ls
				      on     pr.pno = ls.pno
				      where  sysdate between Start_Date and End_Date)
Order by pno;



pause
Prompt
Prompt (8 points)
Prompt 8.  For each city that has at least three properties, list the city
Prompt     and the count of properties in the city, and the average rent
Prompt     of all properties in the city, sorted by average.
Prompt     Use "Average" as the heading for the average rent and
Prompt     "Number of Properties" for the count.
Prompt     The average must be in the currency format
Prompt     (exactly two decimal digits starting with a $).
Prompt

Select   city, count(*) as "NUMBER OF PROPERTIES", avg(rent) as "AVERAGE"
From     UWP_Property
Group By city
Having   count(*) >= 3
Order by "AVERAGE";

pause
Prompt
Prompt (8 points)
Prompt 9. For each renter, list Name and the count of leases the renter
Prompt    has on properties in Platteville, sorted by renter name.
Prompt    For a renter who has no such leases, a zero should be displayed.
Prompt    Use "Number of Leases" for count.
Prompt

Select    name, count(l.rno) as "NUMBER OF LEASES"
From      UWP_Renter r
left join (Select    ls.*
           from      UWP_Lease ls
		   left join UWP_Property p
		   on        ls.pno = p.pno
		   where     p.city = 'Platteville') l
on        r.rno = l.rno
Group by  r.rno, r.name
Order by  r.name;




pause
Prompt
Prompt (8 points)
Prompt 10. List the details of all renters who do not have a lease on any
Prompt     propetry in Platteville during April 2006 and whose phone number
Prompt     is not available, sorted by Rno.
Prompt

Select *
from   UWP_Renter
where  tel_no is null
  and  rno not in (Select rno
				   from   UWP_Lease
				   natural join UWP_Property
				   where city = 'Platteville'
				   and   start_date <= '04-01-2006'
				   and   end_date   >= '04-30-2006')
Order by rno;



pause
Prompt
Prompt (1 point)
Prompt 11. Clear all column formatting
Prompt

Clear Columns
