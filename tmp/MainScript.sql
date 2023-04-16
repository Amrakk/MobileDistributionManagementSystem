

create database MobileDistributionManagementSoftware
go
use MobileDistributionManagementSoftware;
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
    password VARCHAR(50),
	isActivated BIT DEFAULT 0,
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
('Bob', 'Smith', 'bobsmith@example.com', '555-123-4567', 3);

-- Insert data into Account table
INSERT INTO Account (account_id, username, password, created_date)
VALUES
(10000, 'admin', '123456', '2022-01-01 10:00:00'),
(10001, 'accountant', 'm123456', '2022-01-02 11:00:00'),
(10002, 'reseller', 's123456', '2022-01-03 12:00:00');

-- Insert data into Reseller table
INSERT INTO Reseller (reseller_id, reseller_name, address)
VALUES
(10000, 'Reseller A', '123 Main St, Anytown USA'),
(10001, 'Reseller B', '456 Broad St, Anytown USA'),
(10002, 'Reseller C', '789 Elm St, Anytown USA');












-- Create Product table
CREATE TABLE Product (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    brand VARCHAR(50),
    model VARCHAR(50),
    product_description VARCHAR(255),
    product_price DECIMAL(18,2),
    product_quantity INT
);

-- Create Status table
CREATE TABLE Status (
    status_id INT PRIMARY KEY,
    status_name VARCHAR(50)
);

-- Create Order table
CREATE TABLE Order_Note (
    order_id INT PRIMARY KEY,
    status_id INT FOREIGN KEY REFERENCES Status(status_id),
    reseller_id INT FOREIGN KEY REFERENCES Reseller(reseller_id),
    order_date DATETIME,
    total_price DECIMAL(18,2),
    payment_method VARCHAR(50)
);

-- Create Order_Item table
CREATE TABLE Order_Item (
    order_item_id INT PRIMARY KEY,
    order_id INT FOREIGN KEY REFERENCES Order_Note(order_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT
);

-- Create Good_Received_Note table
CREATE TABLE Goods_Received_Note (
    received_id INT PRIMARY KEY,
    received_date DATETIME,
    received_from VARCHAR(50),
    total_quantity INT,
    total_cost DECIMAL(18,2)
);

-- Create Received_Item table
CREATE TABLE Received_Item (
    received_item_id INT PRIMARY KEY,
    received_id INT FOREIGN KEY REFERENCES Goods_Received_Note(received_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT,
    cost_per_unit DECIMAL(18,2)
);

-- Create Goods_Delivery_Note table
CREATE TABLE Goods_Delivery_Note (
    delivery_note_id INT PRIMARY KEY,
    delivery_date DATETIME,
    order_id INT FOREIGN KEY REFERENCES Order_Note(order_id)
);

-- Create Delivery_Item table
CREATE TABLE Delivery_Item (
    delivery_item_id INT PRIMARY KEY,
    delivery_note_id INT FOREIGN KEY REFERENCES Goods_Delivery_Note(delivery_note_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT
);

-- Insert data into Role table
INSERT INTO Role (role_id, role_name) VALUES 
    (1, 'admin'), 
    (2, 'accountant'), 
    (3, 'reseller');

-- Insert data into Profile table
INSERT INTO Profile (profile_id, first_name, last_name, email, phone, role_id) VALUES 
    (1, 'Duy', 'Nguyen', 'hoangduy12823@gmail.com', '0902529803', 3), 
    (2, 'Accountant 1', 'Lastname', 'accountant1@example.com', '1234567890', 2), 
    (3, 'Accountant 2', 'Lastname', 'accountant2@example.com', '1234567890', 2), 
    (4, 'Accountant 3', 'Lastname', 'accountant3@example.com', '1234567890', 2), 
    (5, 'Accountant 4', 'Lastname', 'accountant4@example.com', '1234567890', 2), 
    (6, 'Accountant 5', 'Lastname', 'accountant5@example.com', '1234567890', 2), 
    (7, 'Reseller 1', 'Lastname', 'reseller1@example.com', '1234567890', 3), 
    (8, 'Reseller 2', 'Lastname', 'reseller2@example.com', '1234567890', 3), 
    (9, 'Reseller 3', 'Lastname', 'reseller3@example.com', '1234567890', 3), 
    (10, 'Reseller 4', 'Lastname', 'reseller4@example.com', '1234567890', 3), 
    (11, 'Reseller 5', 'Lastname', 'reseller5@example.com', '1234567890', 3);

-- Insert data into Account table
INSERT INTO Account (account_id, profile_id, username, password, created_date) VALUES 
    (1, 1, 'admin', '123456', GETDATE()), 
    (2, 2, 'accountant1', '123456', GETDATE()), 
    (3, 3, 'accountant2', '123456', GETDATE()), 
    (4, 4, 'accountant3', '123456', GETDATE()), 
    (5, 5, 'accountant4', '123456', GETDATE()), 
    (6, 6, 'accountant5', '123456', GETDATE()), 
    (7, 7, 'reseller1', '123456', GETDATE()), 
    (8, 8, 'reseller2', '123456', GETDATE()), 
    (9, 9, 'reseller3', '123456', GETDATE()), 
    (10, 10, 'reseller4', '123456', GETDATE()), 
    (11, 11, 'reseller5', '123456', GETDATE());

-- Insert data into Product table
INSERT INTO Product (product_id, product_name, brand, model, product_description, product_price, product_quantity) 
VALUES (1, 'iPhone 13 Pro Max', 'Apple', '13 Pro Max', 'The latest iPhone model', 1299.00, 100),
       (2, 'Galaxy S21 Ultra', 'Samsung', 'S21 Ultra', 'The latest Galaxy model', 1199.00, 75),
       (3, 'Pixel 6 Pro', 'Google', 'Pixel 6 Pro', 'The latest Pixel model', 999.00, 50),
       (4, 'OnePlus 10 Pro', 'OnePlus', '10 Pro', 'The latest OnePlus model', 899.00, 25),
       (5, 'Mi 12 Ultra', 'Xiaomi', 'Mi 12 Ultra', 'The latest Xiaomi model', 1099.00, 80);

-- Insert data into Status table
INSERT INTO Status (status_id, status_name) 
VALUES (1, 'Confirmed'),
       (2, 'Packaging'),
       (3, 'Shipping'),
       (4, 'Delivered'),
       (5, 'Unpaid'),
       (6, 'Paid'),
       (7, 'Completed');
