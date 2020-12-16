CREATE DATABASE QuanLyRapPhim
GO

USE QuanLyRapPhim
GO

-- Phim
-- Phong
-- DSPhim
-- Account
-- Bill
-- BillInfo

CREATE TABLE Phong 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Phòng trống',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'tangaiquoc',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 123,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE DSPhim 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Phim 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.DSPhim(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idPhong INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idPhong) REFERENCES dbo.Phong(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idPhim INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id)
)
GO
INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    PassWord,
    Type
)
VALUES
(   N'tangaiquoc123', -- UserName - nvarchar(100)
    N'Quoc Tang', -- DisplayName - nvarchar(100)
    N'123', -- PassWord - nvarchar(1000)
    0    -- Type - int
    )
	INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    PassWord,
    Type
)
VALUES
(   N'staff', -- UserName - nvarchar(100)
    N'Staff', -- DisplayName - nvarchar(100)
    N'123', -- PassWord - nvarchar(1000)
    0    -- Type - int
    )
SELECT	* FROM dbo.Account
go
SELECT COUNT(*) FROM dbo.Account WHERE UserName= N'tangaiquoc123' AND PassWord = N'123';
GO

CREATE PROC USP_Account
@userName NVARCHAR(100)
AS
BEGIN
SELECT *FROM dbo.Account WHERE UserName = @userName
END
GO
EXEC dbo.USP_Account @userName = N'tangaiquoc123' -- nvarchar(100)
GO


DECLARE @i INT =2
WHILE @i<=10
BEGIN
	INSERT dbo.Phong(name) VALUES (N'Phòng' + CAST (@i AS NVARCHAR(100)))
	SET @i=@i+1;
END
GO

SELECT * FROM dbo.Phong
TRUNCATE TABLE dbo.Phong

SELECT * FROM dbo.Phim1

CREATE TABLE Phim1
(
	ID INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	theloai NVARCHAR(100),
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.DSPhim(id)
)

CREATE TABLE DoanhThu
(
	idDT INT IDENTITY PRIMARY KEY,
	nameDT NVARCHAR(100),
	DT NVARCHAR(100),
	BanDuoc FLOAT,
	SuatChieu FLOAT
)
SELECT * FROM dbo.DoanhThu

select * from dbo.Account where tentk