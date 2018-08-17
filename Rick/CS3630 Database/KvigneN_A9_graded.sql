------------------------------------------------
-- Name       : Nick Kvigne
-- UserName   : KvigneN
-- Date       : April 26, 2017
-- Course     : CS 3630 Section 2
-- Description: More In Depth Queries

--Grade: 17/20
------------------------------------------------
Col Hotel_No Format a8 Heading 'Hotel No'
Col Room_No Format a7 Heading 'Room No'
Col Guest_No Format a8 Heading 'Guest No'
Col Guest_Name Format a20 Heading 'Guest Name'
Col Address Format a40 Heading 'Address'
Col Date_From Format a9 Heading 'Date From'
Col Date_To Format a9 Heading 'Date To'
Col RType Format a9 Heading 'Room Type'
Col Price Format $999.99 Heading 'Price'
Col Max(Date_from) Format a13 Heading 'Max Date From'
Col Avg(Price) Format $999.99 Heading 'Average Price'
Col Max(Price) Format $999.99 Heading 'Highest Price'
Col Min(Price) Format $999.99 Heading 'Lowest Price'

Prompt
Prompt Assignment 9
Prompt
Prompt Name: Nick Kvigne
Prompt

Prompt 
Prompt 1.
Prompt List all rooms (all details) of hotel Glasgow,
Prompt sorted by hotel number and then price. 
Prompt

Select Room.*
From Room
Join Hotel
on Room.Hotel_No = Hotel.Hotel_No
where Hotel.Name = 'Glasgow'
Order by Room.Hotel_No, Price;
pause

Prompt
Prompt 2.
Prompt List all double or family rooms (all details) 
Prompt of hotel Glasgow with a price below 50 per 
Prompt night sorted in ascending order of price.
Prompt


Select Room.*
From Room
Join Hotel
on Room.Hotel_No = Hotel.Hotel_No
Where (RType = 'Double' or RType = 'Family')
and price < 50
and Hotel.Name = 'Glasgow'
Order by Price asc;
pause

Prompt
Prompt 3.
Prompt For each hotel that has at least 6 bookings,
Prompt list the hotel name, hotel number and the 
Prompt number of bookings, sorted by the number 
Prompt of bookings in ascending order. 
Prompt

Select H.Name, H.Hotel_No, Count(*)"Bookings"
From Hotel H
Join booking B
on H.Hotel_No = B.Hotel_No
Group by H.Name,H.Hotel_No
Having count(*) > 5
Order by Count(*) asc;
pause

Prompt
Prompt 4.
Prompt For each hotel, list the hotel name, 
Prompt hotel number and the number of bookings 
Prompt during the current month of the current year. 
Prompt A zero should be displayed for hotels that dont 
Prompt have any bookings during the current month, 
Prompt and the query should work for any month of any year. 
Prompt

Select H.name,H.Hotel_No, count(B.Hotel_No)"Bookings"
From Hotel H
left Join Booking B
on H.Hotel_No = B.Hotel_No
and Date_From <= Last_Day(sysDate)
and Date_To > Last_Day(add_months(sysDate,-1))
Group by H.name, H.Hotel_No;
pause

Prompt
Prompt 5.
Prompt List all guests (all details) currently staying 
Prompt at hotel Grosvenor in London, sorted on Guest_no. 
Prompt The query should work for any day. 
Prompt


Select unique Guest.*
From Guest 
Join Booking 
on Booking.Guest_No = Guest.Guest_No 
and Date_From <= To_Char(SysDate)
and Date_To >= To_Char(SysDate)
Join Hotel 
on Booking.Hotel_No = Hotel.Hotel_No
and Hotel.name = 'Grosvenor'
and Hotel.address like '%London%'
order by Guest.Guest_no;
pause

Prompt
Prompt 6.
Prompt For each hotel that does not have any bookings, 
Prompt display the hotel details, sorted on Hotel_No. 
Prompt

Select H.*
From Hotel H
left Join Booking B
on H.Hotel_No = B.Hotel_No
Where B.Hotel_No is null
Order by H.Hotel_No;
pause

Prompt
Prompt 7.
Prompt List the rooms (all details) that are currently 
Prompt unoccupied at hotel Grosvenor in London. 
Prompt The query should produce correct results today 
Prompt and any day in the future. 
Prompt

Select distinct Room.*
From Hotel
Join Room 
on Room.Hotel_No = Hotel.Hotel_No
join booking 
on Hotel.hotel_No = booking.Hotel_No
Where Date_To <= SYSDATE
and Hotel.name = 'Grosvenor'
and Hotel.Address like '%London%';
pause
--Incorrect result: -1

Prompt
Prompt 8.
Prompt For each hotel in London, list the hotel number,
Prompt hotel name, and number of Family rooms 
Prompt with a price below 180. 
Prompt

Select Distinct H.Hotel_No, H.name,
	(select count(*)
	from Room
	where Room.Rtype = 'Family'
	and Room.Price < 180
	and h.Hotel_No = Room.Hotel_No)
	"Number of Family Rooms"
From Hotel H
join Room
on Room.Hotel_No = H.Hotel_No
and h.address like '%London%';
pause


Prompt
Prompt 9.
Prompt List the guest number, guest name and the number
Prompt of bookings for the current year, sorted by guest_no.
Prompt Display a zero for guests who dont have any bookings
Prompt for the current year, 
Prompt and the query should work for any year. 
Prompt


Select G.Guest_No, G.Guest_Name, Count(B.Guest_No)"Bookings"
From Guest G
left Join Booking B
on (G.Guest_No = B.Guest_No and (to_char(Date_From, 'yyyy') = to_char(sysDate,'yyyy')
or to_char(Date_To,'yyyy') = to_char(sysDate,'yyyy')
or to_number(to_char(Date_From,'yyyy'))< to_number(to_char(sysDate,'yyyy'))
and to_number(to_char(Date_To,'yyyy')) > to_number(to_char(sysDate,'yyyy'))))
Group by G.Guest_No, G.Guest_Name
Order by G.Guest_No;
pause

Prompt
Prompt 10.
Prompt For each hotel that has at least one booking, 
Prompt list the Hotel number, Hotel name, and the most commonly booked
Prompt room type for the hotel (the number of bookings is the largest)
Prompt with the count of bookings for that room type. 
Prompt

--Select H.hotel_No, name,
--     (select max(count(*))
--       From Room R
--	   Where r.hotel_No = h.hotel_No 
--	   Group by h.Hotel_No) "Bookings"
--From hotel H;

--Run time error/no answer: -2



clear col


