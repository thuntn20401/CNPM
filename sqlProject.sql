

CREATE DATABASE BAKERY
GO

USE BAKERY
GO

CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cate_totalproduct] [int] NULL,
	[cate_name] [nvarchar](50) NOT NULL,
)
GO
SET IDENTITY_INSERT Categories ON
insert into Categories ([id],[cate_totalproduct],[cate_name]) values (1,8,'Trà sữa');
insert into Categories ([id],[cate_totalproduct],[cate_name]) values (2,5,'Kem');
insert into Categories ([id],[cate_totalproduct],[cate_name]) values (3,5,'Bánh');
insert into Categories ([id],[cate_totalproduct],[cate_name]) values (4,7,'Sinh Tố');
insert into Categories ([id],[cate_totalproduct],[cate_name]) values (5,6,'Đồ ăn vặt');

SET IDENTITY_INSERT Categories OFF




CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[categoriesID] [int] NOT NULL,
	[supplierID] [int] NOT NULL,
	[pro_name] [nvarchar](50) NOT NULL,
	[pro_quantity] [int] NOT NULL,
	[pro_firstprice] [float] NULL,
	[pro_price] [float] NULL,
	[pro_description] [nvarchar](100) NULL,
	[pro_nsx] [date] NOT NULL,
	[pro_hsd] [date] NOT NULL,
)
GO

SET IDENTITY_INSERT Product ON
INSERT INTO Product(id,categoriesID,supplierID,pro_name,pro_quantity,pro_firstprice,pro_price,pro_description,pro_nsx,pro_hsd) VALUES
    (1,1,3,'Trà sữa truyền thống',4,15000,20000,'khá ngon','2021-10-25','2021-10-29'),
    (2,1,3,'Trà sữa Matcha',20,20000,25000,'ngon','2021-10-25','2021-10-29'),
    (3,1,3,'Trà sữa Socola ',14,20000,25000,'ngọt, vừa ăn','2021-10-25','2021-10-29'),
    (4,1,3,'Trà sữa Thái',18,18000,22000,'Chất lượnng oke','2021-10-25','2021-10-29'),
    (5,1,3,'Trà sữa Trân Châu',21,20000,25000,'trân châu ngon','2021-10-25','2021-10-29'),
    (6,3,1,'Bánh phô mai',9,50000,70000,'khá ngon','2021-10-25','2021-10-29'),
    (7,3,1,'Bánh kem bo',9,100000,125000,'ngon','2021-10-25','2021-10-29'),
    (8,3,1,'Bánh mứt dâu ',8,100000,125000,'ngọt, vừa ăn','2021-10-25','2021-10-29'),
    (9,3,1,'Bánh bông lan trứng muối',14,45000,65000,'Chất lượnng oke','2021-10-25','2021-10-29'),
    (10,3,1,'Bánh mì bo tái',26,20000,25000,'ngon','2021-10-25','2021-10-29'),
    (11,2,4,'Kem ốc quế',9,25000,30000,'ngon','2021-10-25','2021-10-27'),
    (12,2,4,'Kem chua dẻoo',3,15000,20000,'ngon','2021-10-25','2021-10-27'),
    (13,2,4,'Kem vani cafe',5,20000,25000,'vừa ăn ','2021-10-25','2021-10-27'),
    (14,2,4,'Kem matcha',18,25000,30000,'Chất lượnng oke','2021-10-25','2021-10-27'),
    (15,2,4,'Kem Dâu',24,20000,25000,'ngon','2021-10-25','2021-10-27'),
    (16,4,5,'Sinh tố dâu',10,25000,30000,'khá ngon','2021-10-25','2021-10-27'),
    (17,4,5,'Sinh tố dào',8,25000,30000,'ngon','2021-10-25','2021-10-27'),
    (18,4,5,'Sinh tố phúc ',12,30000,35000,'ngọt, vừa ăn ','2021-10-25','2021-10-27'),
    (19,4,5,'Sinh tố Bo',20,25000,30000,' oke','2021-10-25','2021-10-27'),
    (20,4,5,'Sinh tố chanh leo',30,20000,25000,'ngon','2021-10-25','2021-10-27'),
    (21,5,2,'Bánh trán trộn',10,15000,20000,'ngon','2021-10-25','2021-10-30'),
    (22,5,2,'Tiramisu ',8,45000,50000,'ngon','2021-10-25','2021-10-30'),
    (23,5,2,'Bánh su kem',7,50000,60000,'rất ngon','2021-10-25','2021-10-30'),
    (24,5,2,'Bánh mouse',20,35000,40000,' oke','2021-10-25','2021-10-30');
SET IDENTITY_INSERT Product OFF

CREATE TABLE [dbo].[Supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sup_name] [nvarchar](50) NOT NULL,
	[sup_phone] [char](11) NOT NULL,
	[sup_address] [nvarchar](max) NOT NULL,
)
GO

SET IDENTITY_INSERT Supplier ON
insert into Supplier ([id],[sup_name],[sup_phone],[sup_address]) values (1,'Siêu thị ngành bánh Bakers Mart',0961035435,'Quận 7');
insert into Supplier ([id],[sup_name],[sup_phone],[sup_address]) values (2,'Cửa hành Phường Hà',0839141318,'Quận 1');
insert into Supplier ([id],[sup_name],[sup_phone],[sup_address]) values (3,'Beemart',190063546,'Quận Tân Bình');
insert into Supplier ([id],[sup_name],[sup_phone],[sup_address]) values (4,'Baker land',0909493938,'Quận 3');
insert into Supplier ([id],[sup_name],[sup_phone],[sup_address]) values (5,'ĐVP Market',02873001770,'Quận 3');
SET IDENTITY_INSERT Supplier OFF


CREATE TABLE [dbo].[Transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[us_username] [nvarchar](20) NOT NULL,
	[addressTo] [nvarchar](max) NOT NULL,
	[phoneTo] [char](11) NOT NULL,
	[totalprice] [real] NOT NULL,
	[createdate] [date] NOT NULL,
	[note] [nvarchar](100) NOT NULL,
)
GO

SET IDENTITY_INSERT Transactions ON
INSERT INTO Transactions (us_username,id,addressTo,phoneTo,totalprice,createdate,note) VALUES
    ('cs1',1,'Quận 1','12345678',198000,'2021-11-02','note 1'),
    ('cs1',2,'Trường ÐH SPKT','12223456',250000,'2021-10-02','note 2'),
    ('cs1',3,'KTX D1 Trường ÐH SPKT','12366456',175000,'2021-09-25','note 3'),
    ('cs2',4,'Quận 3','12342256',206000,'2021-11-02','note 4'),
    ('cs3',5,'Thủ Đức','123457896',520000,'2021-11-05','note 5'),
    ('cs4',6,'Gò Vấp','123459845',500000,'2021-10-12','note 6'),
    ('cs5',7,'Bình Thạnh','1234565',60000,'2021-11-02','note 7'),
    ('cs6',8,'Gò Vấp','124353456',75000,'2021-10-21','note 8'),
    ('cs7',9,'Trường ÐH SPKT','1222344456',75000,'2021-10-15','note 9'),
    ('cs8',10,'Trường ÐH SPKT','12366456',60000,'2021-09-27','note 10'),
    ('cs9',11,'Quận 3','1234552256',300000,'2021-11-02','note 10'),
    ('cs10',12,'Thủ Đức','1234574896',100000,'2021-09-05','note 12'),
    ('cs8',13,'Gò Vấp','123452845',390000,'2021-10-22','note 13'),
    ('cs2',14,'Bình Thạnh','123400565',75000,'2021-11-05','note 14'),
    ('cs5',15,'Bình Thạnh','123454565',75000,'2021-09-02','note 15'),
    ('cs1',18,'US','3456789',45000,'2021-11-09','gui tan nha');
SET IDENTITY_INSERT Transactions OFF

CREATE TABLE [dbo].[Users](
	[us_username] [nvarchar](20) NOT NULL,
	[us_password] [nvarchar](20) NOT NULL,
	[us_firstname] [nvarchar](50) NOT NULL,
	[us_lastname] [nvarchar](50) NOT NULL,
	[us_address] [nvarchar](50) NOT NULL,
	[us_birthday] [date] NOT NULL,
	[us_gender] [char](1) NOT NULL,
	[us_phone] [varchar](11) NOT NULL,
	[us_email] [varchar](50) NOT NULL,
	[us_role] [nvarchar](20) NOT NULL,
)

INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('baonguye', '123', 'bao', 'nguyen', 'dong thap', '1/10/01', 'F', '12345678', 'baobao@gmail.com', 'Admin');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs1', 'biden01', 'john', 'biden', 'US', '11/15/69', 'M', '3456789', 'john@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs10', 'hoang123', 'huy', 'hoang', 'ben tre', '3/2/02', 'M', '34567899', 'hoang@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs2', 'ada123', 'alice','ada', 'US', '7/10/01', 'F', '1235678', 'alice@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs3', 'linhphiu', 'phieu', 'linh', 'TP HCM', '6/23/02', 'F', '1236788', 'linh@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs4', 'kio12', 'kio', 'ha', 'korea', '8/25/99', 'M', '12346789', 'kio@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs5', 'phuong2510', 'phuong','vo', 'Khanh hoa', '10/25/99', 'F', '34567899', 'phuong@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs6', 'dungh', 'Dung','Huynh', 'Phú Yên', '3/10/78', 'F', '1234567', 'dung@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs7', 'julia', 'vera','juli', 'US', '7/9/03', 'F', '12356578', 'vera@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs8', 'ky162', 'ky','hoang', 'Ha Noi', '2/16/99', 'M', '1236788', 'ky@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('cs9', 'voson01', 'son','Vo', 'Khanh Hoa', '5/25/99', 'M', '12346789', 'sonvo@gmail.com', 'Customer');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhathu', '123', 'thu','nguyen', 'phu yen', '11/13/01', 'F', '123456789', 'khadieu@gmail.com', 'Admin');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhanvien1', 'tram01', 'tram','bich', 'TP HCM', '4/30/00', 'F', '12235678', 'tram@gmail.com', 'Employee');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhanvien2', 'giahan123', 'han', 'gia', 'TP HCM', '7/9/02', 'F', '12367588', 'hana@gmail.com', 'Employee');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhanvien3', 'mymy1006', 'my', 'nguye', 'phu yen', '6/10/94', 'F', '123456789', 'mymy@gmail.com', 'Employee');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhanvien4', 'binh@', 'binh', 'cong', 'gia lai', '5/8/00', 'M', '122367588', 'binh@gmail.com', 'Employee');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('nhanvien5', 'khanhkh', 'khanh', 'huynh', 'ben tre', '1/25/95', 'M', '1233456789', 'khanh@gmail.com', 'Employee');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('trucpha', '123', 'truc','thanh', 'ben tre', '7/25/01', 'F', '123456788', 'tructhanh@gmail.com', 'Admin');
INSERT INTO Users (us_username, us_password, us_firstname,us_lastname, us_address, us_birthday, us_gender, us_phone, us_email, us_role) VALUES ('tungdiep', '123', 'tung','bao', 'soc trang', '8/31/01', 'M', '12346789', 'baotung@gmail.com', 'Admin');

GO


CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[us_username] [nvarchar](20) NOT NULL,
	[transactionID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[or_quantity] [int] NOT NULL,
	[or_price] [real] NULL,
 )
GO

SET IDENTITY_INSERT Orders ON
INSERT INTO Orders(id,us_username,transactionID,productID,or_quantity,or_price) VALUES
    (1,'cs1',2,5,3,75000),
    (2,'cs1',2,7,1,125000),
    (3,'cs1',2,15,2,50000),
    (4,'cs1',3,13,4,100000),
    (5,'cs1',1,4,9,198000),
    (6,'cs1',3,5,3,75000),
    (7,'cs2',4,12,7,140000),
    (8,'cs2',5,22,2,100000),
    (10,'cs2',4,4,3,66000),
    (11,'cs3',5,11,1,30000),
    (12,'cs3',5,6,1,70000),
    (13,'cs3',5,1,1,20000),
    (14,'cs4',6,8,4,500000),
    (15,'cs5',7,14,2,60000),
    (16,'cs6',8,13,3,75000),
    (17,'cs7',9,5,3,75000),
    (18,'cs8',10,17,2,60000),
    (19,'cs9',11,23,5,300000),
    (20,'cs10',12,15,4,100000),
    (21,'cs8',13,9,6,390000),
    (22,'cs2',14,10,3,75000),
    (23,'cs5',15,2,3,75000),
    (24,'cs1',18,1,1,20000),
    (25,'cs1',18,2,1,25000);
SET IDENTITY_INSERT Orders OFF

------------------Create Primary Key-------------------------
ALTER TABLE [Categories] ADD CONSTRAINT PK_Categories PRIMARY KEY (id);
ALTER TABLE [Users] ADD CONSTRAINT PK_Users PRIMARY KEY (us_username);
ALTER TABLE [Supplier] ADD CONSTRAINT PK_Supplier PRIMARY KEY (id);
ALTER TABLE [Product] ADD CONSTRAINT PK_Product PRIMARY KEY (id);
ALTER TABLE [Transactions] ADD CONSTRAINT PK_Transactions PRIMARY KEY (id);
ALTER TABLE [Orders] ADD CONSTRAINT PK_Orders PRIMARY KEY (id, us_username, transactionID, productID);
------------------Create Foreign Key-------------------------
ALTER TABLE [Product] ADD CONSTRAINT FK_category_Product FOREIGN KEY (categoriesID) REFERENCES Categories(id);
ALTER TABLE [Product] ADD CONSTRAINT FK_supplier_Product FOREIGN KEY (supplierID) REFERENCES Supplier(id);

ALTER TABLE [Transactions] ADD CONSTRAINT FK_Transactions FOREIGN KEY (us_username) REFERENCES Users(us_username);


ALTER TABLE [Orders] ADD CONSTRAINT FK_user_Orders FOREIGN KEY (us_username) REFERENCES Users(us_username);
ALTER TABLE [Orders] ADD CONSTRAINT FK_product_Orders FOREIGN KEY (productID) REFERENCES Product(id);
ALTER TABLE [Orders] ADD CONSTRAINT FK_transaction_Orders FOREIGN KEY (transactionID) REFERENCES Transactions(id);
GO

------------------Create View-------------------------
CREATE VIEW [dbo].[View_BaoCaoDoanhThu] AS
	SELECT id, [Users].us_username, totalprice, createdate
	FROM [dbo].[Users], [dbo].[Transactions]
	WHERE [Users].us_username = [Transactions].us_username
GO

CREATE VIEW [dbo].[View_DanhSachHangDaDat] AS
	SELECT	dbo.[Users].us_username, dbo.[Transactions].id AS transactionID, dbo.[Orders].id 
			AS orderID, dbo.Product.pro_name, dbo.[Orders].or_quantity, dbo.[Orders].or_price
	FROM	dbo.[Users] INNER JOIN dbo.[Orders] 
				ON dbo.[Users].us_username = dbo.[Orders].us_username INNER JOIN
			dbo.Product 
				ON dbo.[Orders].productID = dbo.Product.id INNER JOIN
			dbo.[Transactions] 
				ON dbo.[Orders].transactionID = dbo.[Transactions].id
GO

CREATE VIEW [dbo].[View_ThongKeSanPhamTheoDanhMuc] AS 
	SELECT cate_name, sup_name, pro_name, pro_quantity, pro_firstprice, pro_price, pro_nsx, pro_hsd, pro_description
	FROM [dbo].[Product], [dbo].[Categories], [dbo].[Supplier]
	WHERE Categories.id = Product.categoriesID AND Supplier.id = Product.supplierID
GO
------------------Create Trigger-------------------------

--------------------Procedure----------------------------

CREATE PROC [dbo].[sp_ChangePassword]
@username nvarchar(20),
@password_old nvarchar(20),
@password_new nvarchar(20),
@confirmPass nvarchar(20)
AS
BEGIN
	DECLARE @us_password nvarchar(20), @status nvarchar(100)
	
	IF EXISTS(SELECT * FROM [dbo].[User	] WHERE us_username = @username AND us_password = @password_old)
	BEGIN
		IF(@password_old != @password_new)
		BEGIN
			IF(@password_new = @confirmPass)
			BEGIN
				UPDATE [dbo].[Users] SET us_password = @password_new
				WHERE us_username = @username
				SET @status = 'Change password success'
			END
			ELSE
			BEGIN
				SET @status = 'Confirm password incorrect!'
			END
		END
		ELSE
		BEGIN
			SET @status = 'New password must be different from the old password'
		END
			
	END
	ELSE
	BEGIN
		SET @status = 'Password incorrect!'
	END
	SELECT @status as status
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_CheckLogin]
@username nvarchar(20),
@password nvarchar(20)
AS
BEGIN
	DECLARE @status int, @role nvarchar(20)
	IF EXISTS( Select * from [dbo].[Users] WHERE us_username = @username AND us_password = @password)
	BEGIN
		SET @role = (SELECT us_role FROM [dbo].[Users] WHERE us_username = @username)
		SET @status = 1
	END
	ELSE
		SET @status = 0
	SELECT @status as status, @role as role
END
GO

CREATE PROC [dbo].[sp_DeleteOrder]
@id int
AS
BEGIN
	DELETE [dbo].[Orders]
	WHERE id = @id
END
GO


CREATE PROC [dbo].[sp_DeleteProduct]
@id int
AS
BEGIN
	DELETE [dbo].[Product]
	WHERE id = @id
END
GO

CREATE PROC [dbo].[sp_DeleteTransaction]
@id int
AS
BEGIN
	DELETE [dbo].[Orders] WHERE transactionID = @id
	DELETE [dbo].[Transactions] WHERE  id = @id;
END
GO

CREATE PROC [dbo].[sp_DeleteUser]
@username nvarchar(20)
AS
BEGIN
	DECLARE @sql1 nvarchar(MAX), @sql2 nvarchar(MAX)
	DELETE [dbo].[Users] 
	WHERE us_username = @username
	SET @sql1 = 'DROP USER ' + @username+ '';
	SET @sql2 = 'DROP LOGIN ' + @username+ '';
	EXEC(@sql1);
	EXEC(@sql2);
END
GO

CREATE PROC [dbo].[sp_getAllProduct]
AS
BEGIN
	SELECT [Product].id as id, pro_name, cate_name, sup_name, pro_quantity, pro_firstprice, pro_price,
			pro_nsx, pro_hsd, pro_description
	FROM [dbo].[Product], [dbo].[Categories], [dbo].[Supplier]
		WHERE [Product].categoriesID = [Categories].id AND [Product].supplierID = [Supplier].id
	
END
GO

CREATE PROC [dbo].[sp_getOrderDetail]
@username varchar(20),
@transactionID int
AS
BEGIN
	SELECT orderID, pro_name, or_quantity, or_price FROM View_DanhSachHangDaDat WHERE us_username = @username and transactionID = @transactionID
END
GO

CREATE PROC [dbo].[sp_getProduct]
@id int
AS
BEGIN
	SELECT * FROM [dbo].[Product] WHERE id = @id;
END
GO

CREATE PROC [dbo].[sp_getTransactionByUser] 
@username nvarchar(20)
AS
BEGIN
	SELECT * FROM [dbo].[Transactions]
	WHERE us_username = @username
END
GO

CREATE PROC [dbo].[sp_getTransactionByUserForDate]
@username nvarchar(20),
@datefrom varchar(20),
@dateto varchar(20)
AS
BEGIN
	SELECT * FROM [dbo].[Transactions]
	WHERE us_username = @username AND createdate >= @datefrom and createdate <= @dateto
END
GO

CREATE PROC [dbo].[sp_InfoUser]
@username nvarchar(20)
AS
BEGIN
	SELECT * FROM [dbo].[Users]
	WHERE us_username = @username
END
GO

CREATE PROC [dbo].[sp_InsertOrder]
@username nvarchar(20),
@transactionID int,
@productID int,
@quantity int
AS
BEGIN
	INSERT INTO [dbo].[Orders] (us_username, transactionID, productID, or_quantity)
	VALUES(@username, @transactionID, @productID, @quantity)
END
GO

CREATE PROC [dbo].[sp_InsertProduct]
@categoriesID int,
@supplierID int,
@pro_name nvarchar(50),
@pro_quantity int,
@pro_firstprice float,
@pro_price float,
@pro_nsx  date,
@pro_hsd date,
@pro_description nvarchar(100)
AS
BEGIN
	DECLARE @cateID int, @supID int
	--SELECT @cateID = id FROM [dbo].[Categories] WHERE cate_name = @categories_name
	--SELECT @supID = id FROM [dbo].[Supplier] WHERE sup_name = @supplier_name
	INSERT INTO [dbo].[Product] (categoriesID, supplierID, pro_name, pro_quantity, pro_firstprice, pro_price, pro_description, pro_nsx, pro_hsd)
	VALUES(@categoriesID, @supplierID, @pro_name, @pro_quantity, 
		  @pro_firstprice, @pro_price, @pro_description, @pro_nsx, @pro_hsd)
END
GO

CREATE PROC [dbo].[sp_InsertTransaction]
@username nvarchar(20),
@address nvarchar(MAX),
@phone char(11),
@createdate date,
@note nvarchar(100)
AS
BEGIN
	INSERT INTO [dbo].[Transactions] (us_username, addressTo, phoneTo, createdate, note)
	VALUES(@username, @address, @phone, @createdate, @note)
END
GO

CREATE PROC [dbo].[sp_InsertUser]
@username nvarchar(20),
@password nvarchar(20),
@firstname nvarchar(50),
@lastname nvarchar(50),
@address nvarchar(50),
@birthday date,
@gender char(1),
@phone varchar(11),
@email varchar(50),
@role nvarchar(20) = 'Customer'
AS
BEGIN
	INSERT INTO [dbo].[Users] 
	VALUES(@username, @password, @firstname, @lastname, @address, @birthday, @gender, @phone, @email, @role)
	
END
GO

CREATE PROC [dbo].[sp_Permission]
@username nvarchar(20),
@password nvarchar(20),
@role nvarchar(20)
AS
BEGIN
	DECLARE @sql nvarchar(MAX)
	IF(@role = 'Customer')
	BEGIN
		SET @sql= ' CREATE LOGIN ['+@username+'] WITH PASSWORD= '''+@password+''',
					DEFAULT_DATABASE=[DIEPFAMILY],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
					CREATE USER ['+@username+'] FOR LOGIN['+@username+'];
					ALTER ROLE [db_datareader] ADD MEMBER ['+@username+'];
					ALTER ROLE [db_datawriter] ADD MEMBER ['+@username+']';
		EXEC(@sql);
		PRINT 'EXEC CUSTOMER'
	END
	ELSE
	IF(@role = 'Admin')
	BEGIN
		SET @sql =' CREATE LOGIN ['+ @username+ '] WITH PASSWORD= '''+@password+''',
					DEFAULT_DATABASE=[DIEPFAMILY],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
					ALTER SERVER ROLE [securityadmin] ADD MEMBER ['+@username+'];
					CREATE USER ['+@username+'] FOR LOGIN['+@username+'];
					ALTER ROLE [db_owner] ADD MEMBER ['+@username+']';
		EXEC(@sql);
		PRINT 'EXEC ADMIN'
	END
	ELSE
	IF(@role = 'Employee')
	BEGIN
		SET @sql = 'CREATE LOGIN ['+@username+'] WITH PASSWORD= '''+@password+''', 
					DEFAULT_DATABASE=[DIEPFAMILY],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
					CREATE USER['+@username+'] FOR LOGIN[' +@username+'];
					ALTER ROLE [db_owner] ADD MEMBER ['+@username+']';
		EXEC(@sql);
		PRINT 'EXEC EMPLOYEE'
	END

END
GO

CREATE PROC [dbo].[sp_Register]
@username varchar(20),
@password varchar(20),
@confirmpassword varchar(20)
AS
BEGIN
	
	BEGIN
		exec sp_InsertUser @username, @password, '','','','','','','', 'Customer'
	END
END
GO

CREATE PROC [dbo].[sp_TimKiemSanPhamTheoTen]
@name nvarchar(50)
AS
BEGIN
	SELECT Product.id, pro_name, pro_quantity, pro_price, sup_name, cate_name, pro_nsx, pro_hsd, pro_description
	FROM [dbo].[Product], [dbo].[Supplier], [dbo].[Categories]
	WHERE pro_name like '%'+@name+'%'	AND [Product].categoriesID = [Categories].id AND [Product].supplierID = [Supplier].id
END
GO

CREATE PROC [dbo].[sp_UpdateOrder]
@id int,
@quantity int
AS
BEGIN
	UPDATE [dbo].[Orders]
	SET	or_quantity = @quantity
	WHERE id = @id
END
GO

CREATE PROC [dbo].[sp_UpdateProduct]
@id int,
@categoriesID int,
@supplierID int,
@name nvarchar(50),
@quantity int,
@firstprice real,
@price real,
@nsx  date,
@hsd date,
@description nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[Product]
	SET categoriesID = @categoriesID,
		supplierID = @supplierID,
		pro_name = @name,
		pro_quantity = @quantity,
		pro_firstprice = @firstprice,
		pro_price = @price,
		pro_nsx = @nsx,
		pro_hsd = @hsd,
		pro_description = @description
	WHERE id = @id
END
GO

CREATE PROC [dbo].[sp_UpdateUser] 
@username nvarchar(20),
@password nvarchar(20),
@firstname nvarchar(50),
@lastname nvarchar(50),
@address nvarchar(50),
@birthday date,
@gender char(1),
@phone varchar(11),
@email varchar(50),
@role nvarchar(20)
AS
BEGIN
	DECLARE @sql1 nvarchar(MAX), @sql2 nvarchar(MAX)
	UPDATE [dbo].[Users] 
	SET
		us_firstname = @firstname,
		us_lastname = @lastname, 
		us_address = @address, 
		us_birthday = @birthday, 
		us_gender = @gender, 
		us_phone = @phone, 
		us_email = @email, 
		us_role = @role
	WHERE us_username = @username

	SET @sql1 = 'DROP USER ' + @username +'';
	SET @sql2 = 'DROP LOGIN ' + @username + '';
	EXEC(@sql1);
	EXEC(@sql2);
	EXEC sp_Permission @username, @password, @role
END
GO
