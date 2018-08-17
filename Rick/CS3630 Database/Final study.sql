

-- ClientNo     : string of length 9 with heading "Client No"
Col ClientNo Format a9 Heading 'Client No'

pause

prompt
prompt 3. (7 points) 
prompt List ClientNo, first name, last name, DOB of all clients
prompt of Platteville, WI, sorted by DOB.
prompt DOB must be displayed in format mm-dd-yyyy such as 05-14-1980.
prompt

Select ClientNo, FirstName,LastName, To_Char(DOB, 'mm-dd-yyyy') as "Birth Day"
From Clients
where city = 'Platteville'
Order by DOB;

pause

prompt
prompt 4. (7 points) 
prompt List StaffNo, ClientNo, class date, start time, end time and class type
prompt of all classes this month. 
prompt Sort the result by class date, start time and then end time.
prompt The clas date should be in format such as May 12 2014, 
prompt and both start and end times should be in format such as 10:30 AM.
prompt The query should produce correct answers on any day in the future.

Select StaffNo,ClientNo,To_Char(ClassDate, 'Month dd yyyy')as "Class Date",To_Char(TimeStart,'HH:MI AM')as "Start Time",To_Char(TimeEnd,'HH:MI AM') as "End Time",CType
From DrivingClasses
where To_Char(ClassDate, 'mm yyyy') = To_Char(SysDate, 'mm yyyy');

pause

Prompt
Prompt 5. (7 points) 
Prompt For each class type with more than 5 classes, 
Prompt list the clas type, number of classes of the type,  
prompt and the earliest class date for the type.
Prompt Use "Earliest Class Date" as the heading for the earliest class date,
prompt "No. of classes" for the count.
Prompt Sort the result by the earliest class date, then the count in descinding order.
Prompt

Select CType
From DrivingClasses;



pause

Prompt
prompt 6. (7 points) 
prompt For each client, who was born before 1970 and has no class last year and before,
prompt list ClientNo, first name, last name, and DOB, sorted by ClientNo.
prompt The same query should work for any year.
prompt     

Select C.ClientNo,C.FirstName,C.LastName,C.DOB
From Clients C
join DrivingClasses D
on C.ClientNo = D.ClientNo
where To_Char(C.DOB,'yyyy')<'1970'
and Not To_Char(D.ClassDate,'yyyy') < To_Char(D.ClassDate,'yyyy')-1;

pause

Prompt
Prompt 7. (8 points) 
Prompt For each client, who does not have any classes by staff 'S02', 
Prompt list first name, last name and the total number of classes the client has,
prompt sorted by ClientNo. 
Prompt For a client without any classes, a zero must be displayed. 
Prompt Use "No. of Classes" for the count.
Prompt

Select C.FirstName, C.LastName, count(*) "No. of Classes"
From Clients C
Join DrivingClasses D
on C.ClientNo = D.ClientNo
where not D.StaffNo = 'S02'
Group By C.FirstName, C.LastName;

pause

Prompt
Prompt 8. (8 points) 
prompt For each pair of client and instructor, list ClientNo, StaffNo, 
prompt "No. of Local Classes" taken by the client from by the instructor,
prompt "No. of Highway Classes" taken by the client from by the instructor,
prompt sorted by ClientNo and StaffNo.
Prompt

Select ClientNo,StaffNo,CType
From DrivingClasses;

Prompt
prompt 9. (2 points) Clear all column formatting
Prompt

Clear col
