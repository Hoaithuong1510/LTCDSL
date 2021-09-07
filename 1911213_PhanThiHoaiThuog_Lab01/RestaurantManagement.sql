/* Học phần: Lập trình cơ sở dữ liệu
   Người thực hiện: Phan Thị Hoài Thương
   MSSV: 1911213
   Ngày: 31/08/2021
*/
------------------------------------------------
CREATE DATABASE RestaunrantManagement
use RestaunrantManagement

create table [Table]
(
	ID int primary key identity(1,1),
	Name nvarchar(1000) NULL,
	Status int,
	Capacity int NULL
)
SELECT * FROM [Table]

create table Category
(
	ID int primary key identity(1,1),
	Name nvarchar(1000) default N'Chưa đặt tên',
	Type int
)
SELECT * FROM Category

create table Food 
(
	ID int primary key identity(1,1),
	Name nvarchar(1000) default N'Chưa đặt tên',
	Unit nvarchar(100),
	FoodCategoryID int references Category(ID),
	Price int default 0,
	Notes nvarchar(3000) NULL
)
SELECT * FROM Food

create table Bills
(
	ID int primary key identity(1,1),
	Name nvarchar(1000) default N'Hóa đơn thanh toán',
	TableID int references [Table](ID),
	Amount int default 0,
	Discount float NULL default 0,
	Tax float NULL default 0,
	Status bit default 0,
	Account nvarchar(100) references Account(AccountName),
	CheckoutDate smalldatetime default GETDATE()
)
SELECT * FROM Bills

create table BillDetails
(
	ID int primary key identity(1,1),
	InbillID int references Bills(ID),
	FoodID int references Food(ID),
	Quantity int default 0
)
SELECT * FROM BillDetails

create table Account
(
	AccountName nvarchar(100) primary key,
	Password nvarchar(200),
	FullName nvarchar(1000),
	Email nvarchar(1000) NULL,
	Tell nvarchar(200),
	DateCreated smalldatetime default GETDATE()
)
SELECT * FROM Account

create table Role 
(
	ID int primary key identity(1,1),
	Rolename nvarchar(1000),
	Path nvarchar(3000) NULL,
	Notes nvarchar(3000) NULL
)
SELECT * FROM Role

create table RoleAccount
(
	AccountName nvarchar(100) references Account(AccountName),
	RoleID int references Role(ID),
	Actived bit,
	Notes nvarchar(3000) NULL,
	primary key (AccountName, RoleID)
)
GO
SELECT * FROM RoleAccount

-- INSERT --
insert into Category values (N'Khai vị', 1);
insert into Category values (N'Hải sản', 1);
insert into Category values (N'Gà', 1);
insert into Category values (N'Cơm', 1);
insert into Category values (N'Thịt', 1);
insert into Category values (N'Rau', 1);
insert into Category values (N'Canh', 1);
insert into Category values (N'Lẩu', 1);
insert into Category values (N'Bia', 0);
insert into Category values (N'Nước ngọt', 0);
insert into Category values (N'Cà phê', 0);
insert into Category values (N'Trà đá', 0);
SELECT * FROM Category

insert into Food values (N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL);
insert into Food values	(N'Cơm chiên Dương Châu', N'Đĩa nhỏ', 4, 40000, N'3 người ăn');
insert into Food values (N'Cơm chiên Dương Châu', N'Đĩa lớn', 4, 45000, N'5 người ăn');
insert into Food values (N'Ếch thui rơm', N'Đĩa', 2, 75000, NULL);
insert into Food values (N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL);
insert into Food values (N'Càng cua hấp', N'Đĩa', 2, 100000, NULL);
insert into Food values (N'Canh cải', N'Tô', 7, 20000, NULL);
insert into Food values (N'Gà nướng muối ớt', N'Con', 3, 180000, NULL);
insert into Food values (N'Bia 333', N'Chai', 9, 12000, NULL);
insert into Food values (N'Bia Heniken', N'Chai', 9, 20000, NULL);
insert into Food values (N'Súp cua', N'Tô', 1, 15000, NULL);
insert into Food values (N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá');
SELECT * FROM Food;

insert into [Table] values ('01', 0, 4);
insert into [Table] values ('02', 0, 4);
insert into [Table] values ('03', 0, 4);
insert into [Table] values ('04', 2, 6);
insert into [Table] values ('05', 0, 8);
SELECT * FROM [Table];

insert into Account values ('lgcong', 'legiacong', N'Lê Gia Công', 'conglg@dlu.edu.vn', NULL, NULL);		
insert into Account values ('tdquy', 'thaiduyquy', N'Thái Duy Quý', 'quytd@dlu.edu.vn', NULL, NULL);
insert into Account values ('ttplinh', 'tranthiphuonglinh', N'Trần Thị Phương Linh', 'linihttp@dlu.edu.vn', NULL, NULL);
insert into Account values ('pttnga', 'phanthithanhnga', N'Phan Thị Thanh Nga', 'ngaptt@dlu.edu.vn', NULL, NULL);
SELECT * FROM Account;

insert into Role values (N'Administator', NULL, NULL);
insert into Role values (N'Kế toán', NULL, NULL);
insert into Role values (N'Nhân viên thanh toán', NULL, NULL);
insert into Role values (N'Nhân viên phục vụ', NULL, NULL);
SELECT * FROM Role;

insert into RoleAccount values (1, 'lgcong', 1, NULL);
insert into RoleAccount values (1, 'pttnga', 1, NULL);
insert into RoleAccount values (1, 'tdquy', 1, NULL);
insert into RoleAccount values (1, 'ttplinh', 1, NULL);
insert into RoleAccount values (3, 'lgcong', 0, NULL);
insert into RoleAccount values (3, 'pttnga', 0, NULL);
insert into RoleAccount values (3, 'tdquy', 1, NULL);
insert into RoleAccount values (3, 'ttplinh', 1, NULL);
SELECT * FROM RoleAccount;

insert into Bills values (4, 150000, 0.05, 0, 0, NULL, 'tdquy');
insert into Bills values (3, 200000, NULL, NULL, 1, NULL, 'pttnga');
SELECT * FROM Bills;

insert into BillDetails values (1, 3, 2);
insert into BillDetails values (1, 4, 1);
insert into BillDetails values (1, 5, 3);
insert into BillDetails values (1, 6, 2);
insert into BillDetails values (2, 7, 2);
insert into BillDetails values (2, 5, 5);
SELECT * FROM BillDetails;

-- Thủ tục thêm dữ liệu vào bảng Category
CREATE PROCEDURE Category_Insert
(
 @Name NVARCHAR(1000),
 @Type INT
)
AS
BEGIN
  -- Kiểm tra tồn tại Name: Lệnh này có thể không cần thiết trong một số bảng
  IF (NOT EXISTS (SELECT Name FROM dbo.Category WHERE Name = @Name))
      INSERT INTO dbo.Category (Name,Type)
	                  VALUES (@Name,@Type)
END
GO
DECLARE @id int =0;
EXEC Category_Insert 'Ốc',2
-- Thủ tục cập nhật dữ liệu trong bảng Category
CREATE PROCEDURE Category_Update
(
 @ID INT,
 @Name NVARCHAR(1000),
 @Type INT
)
AS
BEGIN
     UPDATE dbo.Category
	 SET [Name] = @Name,
	     [Type] = @Type
	 WHERE ID = @ID
END
GO

-- Thủ tục xoá mẫu tin trong bảng Category
CREATE PROCEDURE Category_Delete
(
 @ID INT
)
AS
BEGIN
     DELETE FROM dbo.Category
	 WHERE ID = @ID
END
GO

-- Thủ tục thêm dữ liệu vào bảng Food
CREATE PROCEDURE Food_Insert
(
 @ID INT,
 @Name NVARCHAR(1000),
 @Unit NVARCHAR(1000),
 @Price INT,
 @CategoryID INT, 
 @Notes nvarchar(3000)
)
AS
BEGIN
      INSERT INTO dbo.Food(Name,Unit,Price,FoodCategoryID,Notes)
	                  VALUES (@Name,@Unit,@Price)
					  SET @ID = @@IDENTITY
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng Food
CREATE PROCEDURE Food_Update
(
 @ID INT,
 @Name NVARCHAR(1000),
 @Unit NVARCHAR(100),
 @FoodCategoryID INT,
 @Price INT,
 @Notes NVARCHAR(3000)
)
AS
BEGIN
     UPDATE dbo.Food
	 SET [Name] = @Name,
	     [Unit] = @Unit,
	     [FoodCategoryID] = @FoodCategoryID,
		 [Price] = @Price,
		 [Notes] = @Notes
	 WHERE ID = @ID
END
GO

-- Thủ tục xoá mẫu tin trong bảng Food
CREATE PROCEDURE Food_Delete
(
 @ID INT
)
AS
BEGIN
     DELETE FROM dbo.Food
	 WHERE ID = @ID
END
GO

-- Thủ tục thêm dữ liệu vào bảng Table
CREATE PROCEDURE Table_Insert
(
 @ID INT,
 @Name NVARCHAR(1000),
 @Status INT,
 @Capacity INT
)
AS
BEGIN
      INSERT INTO [Table](Name,Status, Capacity)
	                  VALUES (@Name,@Status,@Capacity)
					  SET @ID = @@IDENTITY
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng Table
CREATE PROCEDURE Table_Update
(
 @ID INT,
 @Name NVARCHAR(1000),
 @Status INT,
 @Capacity INT
)
AS
BEGIN
     UPDATE [Table]
	 SET [Name] = @Name,
	     [Status] = @Status,
		 [Capacity] = @Capacity
	 WHERE ID = @ID
END
GO

-- Thủ tục xoá mẫu tin trong bảng Table
CREATE PROCEDURE Table_Delete
(
 @ID INT
)
AS
BEGIN
     DELETE FROM [Table]
	 WHERE ID = @ID
END
GO

-- Thủ tục thêm dữ liệu vào bảng Bills
CREATE PROCEDURE Bills_Insert
(
 @ID INT,
 @Name NVARCHAR(1000),
 @TableID INT,
 @Amount INT,
 @Discount FLOAT, 
 @Tax FLOAT, 
 @Status BIT, 
 @ChekoutDate SMALLDATETIME,
 @Account NVARCHAR(100)
)
AS
BEGIN
      INSERT INTO [Bills](Name,TableID,Amount,Discount,Tax,Status,CheckoutDate,Account)
	                  VALUES (@Name,@TableID,@Amount,@Discount,@Tax,@Status,@ChekoutDate,@Account)
					  SET @ID = @@IDENTITY
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng Bills
CREATE PROCEDURE Bills_Update
(
 @ID INT,
 @Name NVARCHAR(1000),
 @TableID INT,
 @Amount INT,
 @Discount FLOAT, 
 @Tax FLOAT, 
 @Status BIT, 
 @ChekoutDate SMALLDATETIME,
 @Account NVARCHAR(100)
)
AS
BEGIN
     UPDATE [Bills]
	 SET [Name] = @Name,
	     [TableID] = @TableID,
		 [Amount] = @Amount,
		 [Discount] = @Discount,
		 [Tax] = @Tax,
		 [Status] = @Status,
		 [CheckoutDate] = @ChekoutDate,
		 [Account] = @Account
	 WHERE ID = @ID
END
GO

-- Thủ tục xoá mẫu tin trong bảng Bills
CREATE PROCEDURE Bills_Delete
(
 @ID INT
)
AS
BEGIN
     DELETE FROM [Bills]
	 WHERE ID = @ID
END
GO

-- Thủ tục thêm dữ liệu vào bảng BillDetails
CREATE PROCEDURE BillDetails_Insert
(
 @ID INT,
 @InbillID INT,
 @FoodID INT, 
 @Quantity INT
)
AS
BEGIN
      INSERT INTO [BillDetails](BillID,FoodID,Quantity)
	                  VALUES (@InbillID,@FoodID,@Quantity)
					  SET @ID = @@IDENTITY
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng BillDetails
CREATE PROCEDURE BillDetails_Update
(
 @ID INT,
 @InbillID INT,
 @FoodID INT, 
 @Quantity INT
)
AS
BEGIN
     UPDATE [BillDetails]
	 SET [BillID] = @InbillID,
	     [FoodID] = @FoodID,
		 [Quantity] = @Quantity
	     
	 WHERE ID = @ID
END
GO

-- Thủ tục xoá mẫu tin trong bảng BillDetails
CREATE PROCEDURE BillDetails_Delete
(
 @ID INT
)
AS
BEGIN
     DELETE FROM [BillDetails]
	 WHERE ID = @ID
END
GO


-- Thủ tục thêm dữ liệu vào bảng Account
CREATE PROCEDURE Account_Insert
(
 @AccountName NVARCHAR(100),
 @Password NVARCHAR(200),
 @FullName NVARCHAR(1000),
 @Email NVARCHAR(1000)
)
AS
BEGIN
  IF (NOT EXISTS (SELECT AccountName FROM dbo.Account WHERE AccountName = @AccountName))
      INSERT INTO dbo.Account(AccountName,Password,FullName,Email)
	                  VALUES (@AccountName,@Password,@FullName,@Email)
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng Account
CREATE PROCEDURE Account_Update
(
 @AccountName NVARCHAR(100),
 @Password NVARCHAR(200)
)
AS
BEGIN
     UPDATE dbo.Account
	 SET [AccountName] = @AccountName,
		 [Password] = @Password
	 WHERE AccountName = @AccountName
END
GO

-- Thủ tục xoá mẫu tin trong bảng Account
CREATE PROCEDURE Account_Delete
(
  @AccountName NVARCHAR(100)
)
AS
BEGIN
     DELETE FROM dbo.Account
	 WHERE AccountName = @AccountName
END
GO

-- Thủ tục thêm dữ liệu vào bảng RoleAccount
CREATE PROCEDURE RoleAccount_Insert
(
 @Actived BIT, 
 @Notes NVARCHAR(3000)
)
AS
BEGIN
      INSERT INTO dbo.RoleAccount(Actived,Notes)
	                  VALUES (@Actived,@Notes)
END
GO

-- Thủ tục cập nhật dữ liệu trong bảng RoleAccount
CREATE PROCEDURE RoleAccount_Update
(
 @AccountName NVARCHAR(100),
 @RoleID INT,
 @Actived BIT,
 @Notes NVARCHAR(3000)
)
AS
BEGIN
     UPDATE dbo.RoleAccount
	 SET [Actived] = @Actived,
	     [Notes] = @Notes
	 WHERE AccountName = @AccountName 
	 AND RoleID = @RoleID
END
GO

-- Thủ tục xoá mẫu tin trong bảng Account
CREATE PROCEDURE RoleAccount_Delete
(
  @AccountName NVARCHAR(100),
  @RoleID INT
)
AS
BEGIN
     DELETE FROM dbo.RoleAccount
	 WHERE AccountName = @AccountName 
	 AND RoleID = @RoleID
END
GO

 -- Thủ tục lấy tất cả mẫu tin theo tên bảng
 CREATE PROCEDURE [dbo].[_GetAll]
(
   @TableName NVARCHAR(200)
)
 AS
 BEGIN
      -- Khai báo chuỗi và gán chuỗi
	  DECLARE @Sql NVARCHAR(1000)
	  SET @Sql = 'Select * from'+@TableName
	  EXEC (@Sql)
END
GO

DROP PROC dbo._GetAll
EXEC dbo._GetAll 'Category'

-- Thủ tục lấy hết dữ liệu trong bảng theo ID
CREATE PROCEDURE [dbo].[_GetID]
(
   @Table NVARCHAR(200),
   @ID INT
)
AS
BEGIN
	  DECLARE @Sql NVARCHAR(1000)
	  SET @Sql = 'Select * from'+@Table+' WHERE '+@Table+'.ID = '+CAST(@ID AS NVARCHAR(10))
	  EXEC (@Sql)
END
GO

DROP PROC dbo._GETID
EXEC dbo._GETID 'BillDetails',1

CREATE PROCEDURE _DELETEID
(
   @Table NVARCHAR(200),
   @ID INT
)
AS
BEGIN
	DECLARE @SQL NVARCHAR(1000)
	SET @SQL = 'DELETE FROM '+@Table+' WHERE '+@Table+'.id='+CAST(@ID AS NVARCHAR(10))
	EXEC(@SQL)
END
GO

SELECT * FROM Category

EXEC dbo._DELETEID 'Category',0


