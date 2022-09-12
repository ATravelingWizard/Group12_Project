USE Skyfall
GO

CREATE TABLE Seat
(
	Seat_Code	int	IDENTITY(1,1)PRIMARY KEY,
	Seat_Placement	varchar(10)
);

CREATE TABLE Baggage
(
	Baggage_Code	int	IDENTITY(1,1)PRIMARY KEY,
	Weight	decimal
);

CREATE TABLE Destinations
(
	Destination_ID varchar(3) PRIMARY KEY,
	Destination_Name varchar(30)
);

CREATE TABLE Flight
(
	Flight_Code varchar(30) PRIMARY KEY,
	Destination_ID varchar(3) FOREIGN KEY REFERENCES Destinations(Destination_ID),
	Departure_Time datetime,
	Arrival_Time datetime,
	Total_Baggage_Weight decimal,
	Seats_Available int
);

CREATE TABLE Passengers
(
	Passenger_Code	varchar(15)	PRIMARY KEY,
	Baggage_Code	int	FOREIGN KEY REFERENCES Baggage(Baggage_Code),
	Seat_Code	int	FOREIGN KEY REFERENCES Seat(Seat_Code),
	First_Name	varchar(30),
	Last_Name	varchar(30),
	Contact_Email	varchar(30)
);

CREATE TABLE Passengers_on_flight
(
	Passenger_Code	varchar(15) NOT NULL,
	Flight_Code	varchar(30) NOT NULL,
	CONSTRAINT PK_Passengers_On_Flight PRIMARY KEY (Passenger_Code, Flight_Code),
	FOREIGN KEY (Passenger_Code) REFERENCES Passengers(Passenger_Code),
	FOREIGN KEY (Flight_Code) REFERENCES Flight(Flight_Code)
);