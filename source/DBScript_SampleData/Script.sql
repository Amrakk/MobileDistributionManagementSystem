

create database MobileDistributionManagement
go
use MobileDistributionManagement;
go

-- Create Role table
CREATE TABLE Role (
    role_id INT PRIMARY KEY,
    role_name VARCHAR(50)
);

INSERT INTO Role (role_id, role_name)
VALUES
(1, 'Administrator'),
(2, 'Accountant'),
(3, 'Reseller');

GO
-- Create Profile table
CREATE TABLE Profile (
    profile_id INT IDENTITY(10000, 1) PRIMARY KEY,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50),
    email VARCHAR(50),
    phone VARCHAR(20),
    role_id INT FOREIGN KEY REFERENCES Role(role_id)
);

INSERT INTO Profile (first_name, last_name, email, phone, role_id)
VALUES
('Duy', 'Nguyen', 'duynguyen@example.com', '0902529803', 1),
('Adam', 'Lee', 'adamlee@example.com', '555-666-6666', 1),
('Jane', 'Doe', 'janedoe@example.com', '555-555-5555', 2),
('Will', 'Johnson', 'willjohnson@example.com', '555-777-7777', 2),
('Michael', 'Jackson', 'michaeljackson@example.com', '555-888-8888', 2),
('Kobe', 'Bryant', 'kobebryant@example.com', '555-999-9999', 2),
('Stephen', 'Curry', 'stephencurry@example.com', '555-000-0000', 2),
('Bob', 'Smith', 'bobsmith@example.com', '555-123-4567', 3),
('Jame', 'King', 'jameking@example.com', '555-123-4567', 3),
('John', 'Smith', 'johnsmith@example.com', '555-111-1111', 3),
('Emily', 'Johnson', 'emilyjohnson@example.com', '555-222-2222', 3),
('Michael', 'Williams', 'michaelwilliams@example.com', '555-333-3333', 3),
('Sara', 'Davis', 'saradavis@example.com', '555-444-4444', 3),
('Andrew', 'Brown', 'andrewbrown@example.com', '555-555-5555', 3);


GO
-- Create Account table
CREATE TABLE Account (
    account_id INT FOREIGN KEY REFERENCES Profile(profile_id) PRIMARY KEY,
    username VARCHAR(50),
    password VARCHAR(100),
	is_activated BIT DEFAULT 0,
    created_date DATETIME
);

-- Insert data into Account table
INSERT INTO Account (account_id, username, password, is_activated, created_date)
VALUES
(10000, 'admin', '123456', 1, '2022-01-01 10:00:00'),
(10001, 'admin1', '123456', 1, '2022-01-02 11:00:00'),
(10002, 'accountant', '123456', 1, '2022-01-09 12:00:00'),
(10003, 'accountant1', '123456', 0, '2022-01-10 12:00:00'),
(10004, 'accountant2', '123456', 1,'2022-01-11 12:00:00'),
(10005, 'accountant3', '123456', 0, '2022-01-12 12:00:00'),
(10006, 'accountant4', '123456', 0, '2022-01-09 12:00:00'),
(10007, 'reseller', '123456', 1, '2022-01-03 12:00:00'),
(10008, 'reseller1', '123456', 1, '2022-01-03 12:00:00'),
(10009, 'reseller2', '123456', 0, '2022-01-04 12:00:00'),
(10010, 'reseller3', '123456', 0, '2022-01-05 12:00:00');

GO
-- Create Reseller table
CREATE TABLE Reseller (
	reseller_id INT FOREIGN KEY REFERENCES Profile(profile_id) PRIMARY KEY,
    reseller_name NVARCHAR(100),
    address NVARCHAR(100),
);

-- Insert data into Reseller table
INSERT INTO Reseller (reseller_id, reseller_name, address)
VALUES
(10007, 'Reseller A', '123 Oak St, Cali USA'),
(10008, 'Reseller B', '456 Maple St, New York USA'),
(10009, 'Reseller C', '789 Pine St, Texas USA'),
(10010, 'Reseller D', '234 Elm St, Dallas USA');


GO
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

GO
-- Create Good_Received_Note table
CREATE TABLE Goods_Received_Note (
    received_id INT IDENTITY(50000, 1) PRIMARY KEY,
    received_date DATETIME,
    received_from VARCHAR(50),
    total_quantity INT,
    total_cost INT
);

INSERT INTO Goods_Received_Note (received_date, received_from, total_quantity, total_cost)
VALUES
('2023-04-01', 'Supplier A', 35, 9500),
('2023-04-02', 'Supplier B', 10, 3500),
('2023-04-03', 'Supplier C', 25, 5000),
('2023-04-04', 'Supplier D', 18, 4950);

GO
CREATE TABLE Received_Item (
    received_id INT FOREIGN KEY REFERENCES Goods_Received_Note(received_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT,
    cost_per_unit INT,
	CONSTRAINT PK_Received_Item PRIMARY KEY (received_id, product_id)
);

-- Insert data into Received_Item table
INSERT INTO Received_Item (received_id, product_id, quantity, cost_per_unit)
VALUES
(50000, 30000, 20, 250),
(50000, 30001, 15, 300),
(50001, 30003, 10, 350),
(50002, 30005, 25, 200),
(50003, 30008, 18, 275);


GO
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

GO
-- Create Order table
CREATE TABLE Order_Note (
    order_id INT IDENTITY(100000, 1) PRIMARY KEY,
    order_date DATETIME,
    reseller_id INT FOREIGN KEY REFERENCES Reseller(reseller_id),
    status_id INT FOREIGN KEY REFERENCES Status(status_id),
    total_price DECIMAL(18,2),
    payment_method VARCHAR(50)
);

INSERT INTO Order_Note (order_date, reseller_id, status_id, total_price, payment_method)
VALUES
('2023-05-01', 10007, 1, 4395.00, 'Credit/Debit Card'),
('2023-05-02', 10008, 2, 749.00, 'Digital Wallet'),
('2023-05-03', 10009, 1, 3196.00, 'Buy now pay later'),
('2023-05-04', 10010, 3, 4995.00, 'Credit/Deibt Card');


GO
-- Create Order_Item table
CREATE TABLE Order_Item (
    order_id INT FOREIGN KEY REFERENCES Order_Note(order_id),
    product_id INT FOREIGN KEY REFERENCES Product(product_id),
    quantity INT,
	CONSTRAINT PK_Order_Item PRIMARY KEY (order_id, product_id)
);

-- Insert data into Order_Item table
INSERT INTO Order_Item (order_id, product_id, quantity)
VALUES
    (100000, 30001, 2),
    (100000, 30003, 3),
    (100001, 30000, 1),
    (100002, 30005, 4),
    (100003, 30007, 5);

GO
-- Create Goods_Delivery_Note table
CREATE TABLE Delivery_Note (
    delivery_id INT FOREIGN KEY REFERENCES Order_Note(order_id) PRIMARY KEY,
    delivery_date DATETIME,
    delivery_method VARCHAR(50)
);
INSERT INTO Delivery_Note (delivery_id, delivery_date, delivery_method)
VALUES
    (100000, '2023-05-06', 'Standard shipping'),
    (100001, '2023-05-07', 'Express shipping'),
    (100002, '2023-05-08', 'Third-party service'),
    (100003, '2023-05-09', 'Express shipping');

