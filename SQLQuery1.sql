CREATE database Quietattic;

USE Quietattic;









INSERT into "Customer"
VALUES (552, 'Saman', 'No-12 Gabadaweediya, Matara', 'saman1990@gmail.com', 0766585590)



CREATE TABLE "Staff" (
		Employee_ID INT NOT NULL PRIMARY KEY,
		Emp_Name VARCHAR (50),
		Emp_Address VARCHAR (100),
		Email VARCHAR (50),
		Cont_No INT
);

CREATE TABLE "Customer_Staff" (
		Cus_ID INT NOT NULL,
		Employee_ID INT NOT NULL,
		PRIMARY KEY (Cus_ID, Employee_ID),
		FOREIGN KEY (Cus_ID) REFERENCES "Customer" (Cus_ID),
		FOREIGN KEY (Employee_ID) REFERENCES "Staff" (Employee_ID)
);

CREATE TABLE "Staff_Production" (
		Employee_ID INT NOT NULL,
		Production_ID INT NOT NULL,
		PRIMARY KEY (Employee_ID, Production_ID),
		FOREIGN KEY (Employee_ID) REFERENCES "Staff" (Employee_ID),
		FOREIGN KEY (Production_ID) REFERENCES "Production" (Production_ID)
);

CREATE TABLE "Customer" (
		Cus_ID INT NOT NULL PRIMARY KEY,
		Cus_Name VARCHAR (50),
		Cus_Address VARCHAR (100),
		Email VARCHAR (50),
		Cont_No INT
);

CREATE TABLE "Customer_Contact" (
		Cus_ID INT NOT NULL PRIMARY KEY,
		Customer_Contact INT,
		FOREIGN KEY (Cus_ID) REFERENCES Customer (Cus_ID)
);



CREATE TABLE Order_Staff (
    Order_ID INT NOT NULL, 
    Employee_ID INT NOT NULL,
    PRIMARY KEY (Order_ID, Employee_ID),
    FOREIGN KEY (Order_ID) REFERENCES "Order" (Order_ID),
    FOREIGN KEY (Employee_ID) REFERENCES "Staff" (Employee_ID)
);

CREATE TABLE "Order" (
		Order_ID INT NOT NULL PRIMARY KEY,
		Order_type VARCHAR (50)
);

ALTER TABLE "Order"
ADD Cus_ID INT;


CREATE TABLE "Payment" (
		Payment_ID INT NOT NULL PRIMARY KEY,
		Pay_type VARCHAR (50),
		Pay_Date DateTime
);



ALTER TABLE "Payment"
ADD Cus_ID INT;








CREATE TABLE "Production" (
		Production_ID INT NOT NULL PRIMARY KEY,
		Product_Name VARCHAR (50),
		Category VARCHAR (100)
);

ALTER TABLE "Production"
ADD Location_ID INT;

ALTER TABLE "Production"
ADD Direcotr_ID INT;


CREATE TABLE "Actor_Production" (
    Actor_ID INT NOT NULL, 
    Production_ID INT NOT NULL,
    PRIMARY KEY (Actor_ID, Production_ID),
    FOREIGN KEY (Actor_ID) REFERENCES "Actor" (Actor_ID),
    FOREIGN KEY (Production_ID) REFERENCES "Production" (Production_ID)
);

CREATE TABLE "Actor"(
		Actor_ID INT NOT NULL PRIMARY KEY,
		Actor_Name VARCHAR (50),
		Actor_Address VARCHAR (100),
		Salary INT,
		Cont_No INT
);

CREATE TABLE Actor_Contact (
		Actor_ID INT NOT NULL PRIMARY KEY,
		Actor_Contact INT,
		FOREIGN KEY (Actor_ID) REFERENCES Actor (Actor_ID)
);

CREATE TABLE "Director"(
		Director_ID INT NOT NULL PRIMARY KEY,
		Director_Name VARCHAR (50),
		Director_Address VARCHAR (100),
		Email VARCHAR (50),
		Cont_No INT
);

CREATE TABLE "Director_Contact" (
		Director_ID INT NOT NULL PRIMARY KEY,
		Director_Contact INT,
		FOREIGN KEY (Director_ID) REFERENCES Director (Director_ID)
);

CREATE TABLE "Location" (
		Location_ID INT NOT NULL PRIMARY KEY,
		Loc_Name VARCHAR (50)
);

CREATE TABLE "Property" (
		Property_ID INT NOT NULL PRIMARY KEY,
		Prop_Name VARCHAR (50),
		Prop_Type VARCHAR (50)
);

CREATE TABLE Location_Property (
    Location_ID INT NOT NULL, 
    Property_ID INT NOT NULL,
    PRIMARY KEY (Location_ID, Property_ID),
    FOREIGN KEY (Location_ID) REFERENCES "Location" (Location_ID),
    FOREIGN KEY (Property_ID) REFERENCES "Property" (Property_ID)
);

CREATE TABLE Login (
    User_Name VARCHAR(50) NOT NULL PRIMARY KEY,
    Password  VARCHAR(50),
    Login_Type VARCHAR(50)
);