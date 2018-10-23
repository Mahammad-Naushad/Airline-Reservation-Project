# Airline-Reservation-Project
ASP.net and Entity Framework Project

Question:

Create using ASP.NET and Database connectivity through Entity 

1. User account
The registered user can directly do the booking of flights and if there is a new user he may register or he only sees the flight details. 
But for the reservation of ticket he must register first.

2. Creation of new user account
When there is a new customer he should fill the form containing field like Name, Address, andContact No. , Gender, Email_ id, Age and also User_Id and Password.

3. Checking Availability
To check the available flight the user should input the origin city and destination city, date of  journey.

4. Reservation of Flight
After providing all information the system will ask user for confirmation. After confirming the information the seats get reserved.

5. Canceling / Rescheduling of Ticket
The user has the option to cancel the ticket before payment is done.
After payment and allocation of seats if he cancels the ticket he will get only 50% refund.
For rescheduling the ticket if the user does rescheduling after seat allocation he will lose 25% of the charges

To cancel the reservation the customer should provide the details about Ticket no and flight no
Create a Cardinfo table which has cardno, cvvno, exp date and balance. Check if the card details are valid and sufficient balance is available in card else handle with appropriate exception. Exp date and Transaction date should be validated. If transaction of payment is successful then the ticket  amount  collected should be deducted from balance
If the passenger cancels or reschedules the ticket , the amount of refund of 50% should get updated to card  balance
