CREATE DATABASE FishingFleet;
drop database FishingFleet; 

CREATE TABLE tblUSER(	
	Full_Name VARCHAR(20) NOT NULL,
	User_Name VARCHAR(20) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	Phone VARCHAR(13) NOT NULL,
	Pet_Name VARCHAR(20) NOT NULL, 
	CONSTRAINT user_pk PRIMARY KEY(User_Name)
);

CREATE TABLE Quotas (
  Species VARCHAR(35) PRIMARY KEY,
  Quota_Limit_kg DECIMAL(10, 2)
);

CREATE TABLE Boats (
  Boat_Id VARCHAR(10) PRIMARY KEY,
  Name VARCHAR(35),
  License_Number VARCHAR(10),
  Max_Load_Size DECIMAL(10, 2),
  Species1 VARCHAR(35),
  Species2 VARCHAR(35),
  Species3 VARCHAR(35),
  Species4 VARCHAR(35)
);

CREATE TABLE Catches (
  Catch_Id INT IDENTITY(1,1) PRIMARY KEY,
  Boat_Id VARCHAR(10) REFERENCES Boats(Boat_Id),
  Species VARCHAR(35) REFERENCES Quotas(Species),
  Weight_kg DECIMAL(10, 2),
  Catch_date VARCHAR(50)
);

drop table Boats;
drop table tblUSER;
drop table Quotas;
drop table Catches;
drop table FishSpecies;

SELECT * FROM Boats;
SELECT * FROM Catches;
SELECT * FROM Quotas;
SELECT * FROM FishSpecies;
SELECT * FROM tblUSER;

/*'Hamza','hamza','987654321',12345678979,'cat'*/
