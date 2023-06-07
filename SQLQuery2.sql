
GO

/****** Object:  Table [dbo].[Sign_Up]    Script Date: 8/2/2022 2:55:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SIGNUP_UP](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[user_name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[phone_no] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[type] [varchar](50)  NULL
) ON [PRIMARY]
GO

CREATE PROCEDURE SP_INSERT_SIGNUP  
@Username varchar(50),  
@email varchar(50),  
@password varchar(50),  
@phone_no varchar(50),  
@address varchar(50),  
@type varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into SIGNUP_UP (user_name,email,password,phone_no,address,type) 
           Values (@Username,@email, @password,@phone_no,@address,@type)  
  
END  
GO  

CREATE PROCEDURE SP_INSERT_USIGNUP  
@Username varchar(50),  
@email varchar(50),  
@password varchar(50),  
@phone_no varchar(50),  
@address varchar(50)

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into SIGNUP_UP(user_name,email,password,phone_no,address,type) 
           Values (@Username,@email, @password,@phone_no,@address,'user')  
  
END  
GO  



CREATE PROCEDURE SP_LOGIN 

@email varchar(50),  
@password varchar(50) 
  
  
AS  
BEGIN  
    
    SET NOCOUNT ON;  
  
    select * from SIGNUP_UP where email=@email AND password=@password
           
  
END  
GO  

CREATE TABLE [dbo].[aircraft](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[aircraft_name] [varchar](50) NOT NULL,
	[aircraft_no] [int] NOT NULL
	

) ON [PRIMARY]
GO




CREATE PROCEDURE SP_INSERT_AIRCRAFT
@aircraft_name  varchar(50),  
@aircraft_numeric INT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into aircraft(aircraft_name,aircraft_no) 
           Values (@aircraft_name,@aircraft_numeric)  
  
END  
GO  


CREATE PROCEDURE SP_DELETE_AIRCRAFT

@id INT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    delete from aircraft where id= @id
END  
GO  







CREATE PROCEDURE SP_UPDATE_AIRCRAFT
@id INT,
@aircraft_name  varchar(50),  
@aircraft_numeric INT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    update aircraft set aircraft_name=@aircraft_name,aircraft_no=@aircraft_numeric where id =@id
END  
GO  



CREATE PROCEDURE FETCH_UPDATE_AIRCRAFT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM aircraft
END  
GO  

CREATE TABLE [dbo].[flight](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[airline_name] [varchar](50) NOT NULL,
	[origin] [varchar](50) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[Departure] [varchar](50) NOT NULL,
	[arrival] [varchar](50) NOT NULL,
	[no_of_stop] [varchar](50) NOT NULL,
	[Fare] [varchar](50) NOT NULL
	
) ON [PRIMARY]
GO



CREATE PROCEDURE SP_INSERT_FLIGHT
@airline_name  varchar(50),  
@origin varchar(50), 
@Destination varchar(50),
@Departure varchar(50),
@arrival varchar(50),
@no_of_stop varchar(50),
@Fare varchar(50)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into flight(airline_name,origin,Destination,Departure,arrival,no_of_stop,Fare) 
           Values (@airline_name,@origin,@Destination,@Departure,@arrival,@no_of_stop,@Fare)  
  
END  
GO



CREATE PROCEDURE SP_UPDATE_FLIGHT
@id INT,
@airline_name  varchar(50),  
@origin varchar(50), 
@Destination varchar(50),
@Departure varchar(50),
@arrival varchar(50),
@no_of_stop varchar(50),
@Fare varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    update flight set airline_name=@airline_name,origin=@origin,DestinatioN=@Destination,Departure=@Departure,arrival=@arrival,no_of_stop=@no_of_stop,Fare=@Fare where id =@id
END  
GO  

CREATE PROCEDURE SP_DELETE_FLIGHT
@id INT

  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    DELETE FROM flight WHERE id=@id
END  
GO  

CREATE PROCEDURE SP_FETCH_FLIGHT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM flight
END  
GO 





CREATE PROCEDURE SP_FETCH_AIRCRAFT

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM aircraft
END  
GO  

CREATE TABLE [dbo].[Customer_Inqueries](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[FullName] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone_no] [varchar](50) NOT NULL,
	[message] [varchar](50) NOT NULL,
	
) ON [PRIMARY]
GO




CREATE PROCEDURE SP_FETCH_FLIGHT_BY_CONDITION
@origin varchar(50),
@destination varchar(50),
@airline_name varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM flight where origin=@origin and Destination=@destination and airline_name=@airline_name
END  
GO




CREATE PROCEDURE SP_FETCH_Customer_Inqueries

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Customer_Inqueries
END  
GO  

CREATE PROCEDURE SP_INSERT_Customer_inquiries
@fullname  varchar(50),  
@email varchar(50), 
@phone_no varchar(50),
@message varchar(50)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into Customer_Inqueries(FullName,email,phone_no,message) 
           Values (@fullname,@email,@phone_no,@message)  
  
END  
GO



CREATE PROCEDURE SP_FETCH_USER

  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    select * from SIGNUP_UP where type = 'user'

  
END  
GO


CREATE PROCEDURE SP_DELETE_FLIGHT
@id INT

  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    DELETE FROM flight WHERE id=@id
END  
GO  


CREATE PROCEDURE SP_FETCH_USER_BY_CONDITION
@id INT
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM SIGNUP_UP where id=@id and type='user'
END  
GO



CREATE PROCEDURE SP_DELETE_USER
@id INT

AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    DELETE FROM SIGNUP_UP WHERE id=@id AND type='user'
END  
GO  




CREATE TABLE [dbo].[ Payment_Details](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[card_owner] [varchar](50) NOT NULL,
	[Card_Number] [varchar](50) NOT NULL,
	[CVV] [varchar](50) NOT NULL,
	[ Card_Type] [varchar](50) NOT NULL,
	[ Expiration_Month] [varchar](50) NOT NULL,
	[ Expiration_Year] [varchar](50) NOT NULL,
	
) ON [PRIMARY]
GO



CREATE PROCEDURE SP_INSERT_PaymentDetails
@card_owner  varchar(50),  
@card_number varchar(50), 
@cvv varchar(50),
@card_type varchar(50),
@expiration_month varchar(50),
@expiration_year varchar(50)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into [ Payment_Details](card_owner,Card_Number,CVV,[ Card_Type],[ Expiration_Month],[ Expiration_Year]) 
           Values (@card_owner,@card_number,@cvv,@card_type,@expiration_month,@expiration_year)  
  
END  
GO


CREATE TABLE [dbo].[Book_flight](
[id] [int] IDENTITY(1,1) PRIMARY KEY,
[airline_name] [varchar](50) NOT NULL,
	[origin] [varchar](50) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[Departure] [varchar](50) NOT NULL,
	[arrival] [varchar](50) NOT NULL,
	[no_of_stop] [varchar](50) NOT NULL,
	[Fare] [varchar](50) NOT NULL,
	[Passenger_name] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[DOB] [varchar](50) NOT NULL,
	
	[Phone] [varchar](50) NOT NULL,

	
	[Nic] [varchar](50) NOT NULL,
	
	[Class] [varchar](50) NOT NULL,
	[user_id] [varchar](50) NOT NULL



	

	
	
) ON [PRIMARY]
GO



CREATE PROCEDURE SP_INSERT_Booking

  @airline_name  varchar(50),  
@origin varchar(50), 
@Destination varchar(50),
@Departure varchar(50),
@arrival varchar(50),
@no_of_stop varchar(50),
@Fare varchar(50),

@passenger_name varchar(50),
@Age varchar(50),
@gender varchar(50),
@Dob varchar(50),
@phone varchar(50),
@nic varchar(50),
@class varchar(50),
@u_id varchar(50)




AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
  INSERT INTO [dbo].[Book_flight]
           ([airline_name]
           ,[origin]
           ,[Destination]
           ,[Departure]
           ,[arrival]
           ,[no_of_stop]
           ,[Fare]
           ,[Passenger_name]
           ,[Age]
           ,[Gender]
           ,[DOB]
           ,[Phone]
           ,[Nic]
           ,[Class]
		   ,[user_id])
     VALUES(@airline_name,@origin,@Destination,@Departure,@arrival,@no_of_stop,@Fare,@passenger_name,@Age,@gender,@Dob,@phone,@nic,@class,@u_id) 
  
END  
GO




CREATE PROCEDURE SP_FETCH_RESERVATION
@id varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Book_flight  where user_id= @id
END  
GO



CREATE PROCEDURE SP_FETCH_RESERVATION_BY_CONDITION
@id INT
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Book_flight where id=@id
END  
GO



CREATE PROCEDURE SP_FETCH_ALL_RESERVATION
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Book_flight
END  
GO




CREATE PROCEDURE SP_DELETE_RESERVATION
@id INT

  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    DELETE FROM Book_flight WHERE id=@id
END  
GO  



CREATE PROCEDURE SP_UPDATE_RESERVATION
@id INT,
@Passenger_name  varchar(50),  
@Age varchar(50), 
@Gender varchar(50),
@DOB varchar(50),
@Phone varchar(50),
@Nic varchar(50),
@Class varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    update Book_flight set Passenger_name=@Passenger_name,Age=@Age,Gender=@Gender,DOB=@DOB,Phone=@Phone,Nic=@Nic,Class=@Class where id =@id
END  
GO  



CREATE PROCEDURE SP_FETCH_RESERVATION
@id varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Book_flight  where id= @id
END  
GO

CREATE PROCEDURE SP_INSERT_PaymentDetails2
@card_owner  varchar(50),  
@card_number varchar(50), 
@cvv varchar(50),
@card_type varchar(50),
@expiration_month varchar(50),
@expiration_year varchar(50)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into [ Payment_Details](card_owner,Card_Number,CVV,[ Card_Type],[ Expiration_Month],[ Expiration_Year]) 
           Values (@card_owner,@card_number,@cvv,@card_type,@expiration_month,@expiration_year)  
  
END  
GO



CREATE TABLE [dbo].[Refund_Payment](
[id] [int] IDENTITY(1,1) PRIMARY KEY,

	[Passenger_name] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[DOB] [varchar](50) NOT NULL,
	
	[Phone] [varchar](50) NOT NULL,

	
	[Nic] [varchar](50) NOT NULL,
	
	[Class] [varchar](50) NOT NULL



	

	
	
) ON [PRIMARY]
GO




CREATE PROCEDURE SP_INSERT_Refund

 

@passenger_name varchar(50),
@Age varchar(50),
@gender varchar(50),
@Dob varchar(50),
@phone varchar(50),
@nic varchar(50),
@class varchar(50)




AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
  INSERT INTO [dbo].[Refund_Payment]
           (
           [Passenger_name]
           ,[Age]
           ,[Gender]
           ,[DOB]
           ,[Phone]
           ,[Nic]
           ,[Class])
		   
     VALUES(@passenger_name,@Age,@gender,@Dob,@phone,@nic,@class) 
  
END  
GO


CREATE PROCEDURE SP_FETCH_Refundd

  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Refund_Payment 
END  
GO


CREATE PROCEDURE SP_FETCH_Refund2
@id varchar(50)
  
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    SELECT * FROM Refund_Payment  where id = @id
END  
GO