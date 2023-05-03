drop database MobileDistributionManagement

create database MobileDistributionManagement
go
use MobileDistributionManagement;
go

-- Create Role table
CREATE TABLE Role (
    role_id INT PRIMARY KEY,
    role_name VARCHAR(50)
);

-- Create Profile table
CREATE TABLE Profile (
    profile_id INT IDENTITY(10000, 1) PRIMARY KEY,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50),
    email VARCHAR(50),
    phone VARCHAR(20),
    role_id INT FOREIGN KEY REFERENCES Role(role_id)
);

-- Create Account table
CREATE TABLE Account (
    account_id INT FOREIGN KEY REFERENCES Profile(profile_id) PRIMARY KEY,
    username VARCHAR(50),
    password VARCHAR(100),
	is_activated BIT DEFAULT 0,
    created_date DATETIME
);

-- Create Reseller table
CREATE TABLE Reseller (
	reseller_id INT FOREIGN KEY REFERENCES Profile(profile_id) PRIMARY KEY,
    reseller_name NVARCHAR(100),
    address NVARCHAR(100),
);

-------- Insert table
-- Insert data into Role table
INSERT INTO Role (role_id, role_name)
VALUES
(1, 'Administrator'),
(2, 'Accountant'),
(3, 'Reseller');

-- Insert data into Profile table
INSERT INTO Profile (first_name, last_name, email, phone, role_id)
VALUES
('Duy', 'Nguyen', 'duynguyen@example.com', '0902529803', 1),
('Jane', 'Doe', 'janedoe@example.com', '555-555-5555', 2),
('Bob', 'Smith', 'bobsmith@example.com', '555-123-4567', 3),
('Jame', 'King', 'jameking@example.com', '555-123-4567', 3);

-- Insert data into Account table
INSERT INTO Account (account_id, username, password, created_date)
VALUES
(10000, 'admin', '$2a$10$xylW4Lb15pNtiPjG8.huXOBmnXOhsPeD9V4H5mKTdR3etAvzpNVbu', '2022-01-01 10:00:00'),
(10001, 'accountant', 'm123456', '2022-01-02 11:00:00'),
(10002, 'reseller', 's123456', '2022-01-03 12:00:00'),
(10003, 'reseller1', 's123456', '2022-01-03 12:00:00');
GO
-- Insert data into Reseller table
INSERT INTO Reseller (reseller_id, reseller_name, address)
VALUES
(10002, 'Reseller A', '456 Broad St, Anytown USA'),
(10003, 'Reseller B', '789 Elm St, Anytown USA');


-------------------------------------------------

-- Create Product table
CREATE TABLE Product (
    product_id INT IDENTITY(30000, 1) PRIMARY KEY,
    product_name VARCHAR(50),
    model VARCHAR(50),
    product_description VARCHAR(255),
    product_price INT,
    product_quantity INT
);

INSERT INTO Product (product_name, model, product_description, product_price, product_quantity)
VALUES
('iPhone XR', 'XR', '6.1-inch Liquid Retina display', 749, 59),
('iPhone XS', 'XS', '5.8-inch Super Retina display', 999, 68),
('iPhone 11', '11', '6.1-inch Liquid Retina display', 699, 41),
('iPhone 12', '12', '6.1-inch Super Retina XDR display', 799, 57),
('iPhone SE', 'SE', '4.7-inch Retina HD display', 399, 75),
('iPhone 13', '13', '6.1-inch Super Retina XDR display', 799, 63),
('iPhone 11 Pro', '11 Pro', '5.8-inch Super Retina XDR display', 999, 82),
('iPhone 12 Pro', '12 Pro', '6.1-inch Super Retina XDR display', 999, 49),
('iPhone 8', '8', '4.7-inch Retina HD display', 449, 52),
('iPhone 13 Pro', '13 Pro', '6.1-inch Super Retina XDR display', 999, 71);

-- Create Good_Received_Note table
CREATE TABLE Goods_Received_Note (
    received_id INT IDENTITY(50000, 1) PRIMARY KEY,
    received_date DATETIME,
    received_from VARCHAR(50),
    total_quantity INT,
    total_cost INT
);

-- Create Received_Item table
CREATE TABLE Received_Item (
    received_id INT FOREIGN KEY REFERENCES Goods_Received_Note(received_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT,
    cost_per_unit INT,
	CONSTRAINT PK_Received_Item PRIMARY KEY (received_id, product_id)
);



-- Create Status table
CREATE TABLE Status (
    status_id INT PRIMARY KEY,
    status_name VARCHAR(50)
);

INSERT INTO Status (status_id, status_name) 
VALUES (1, 'Confirmed'),
       (2, 'Packaging'),
       (3, 'Shipping'),
       (4, 'Delivered'),
       (5, 'Unpaid'),
       (6, 'Paid'),
       (7, 'Completed') ;



-- Create Order table
CREATE TABLE Order_Note (
    order_id INT IDENTITY(100000, 1) PRIMARY KEY,
    order_date DATETIME,
    reseller_id INT FOREIGN KEY REFERENCES Reseller(reseller_id),
    status_id INT FOREIGN KEY REFERENCES Status(status_id),
    total_price DECIMAL(18,2),
    payment_method VARCHAR(50)
);

-- Create Order_Item table
CREATE TABLE Order_Item (
    order_id INT FOREIGN KEY REFERENCES Order_Note(order_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT,
	CONSTRAINT PK_Order_Item PRIMARY KEY (order_id, product_id)
);

-- Create Goods_Delivery_Note table
CREATE TABLE Delivery_Note (
    delivery_id INT FOREIGN KEY REFERENCES Order_Note(order_id) PRIMARY KEY,
    delivery_date DATETIME,
    delivery_method VARCHAR(50)
);






