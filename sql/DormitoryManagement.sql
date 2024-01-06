-- TẠO DATABASE
CREATE DATABASE BD8888;
GO

-- CHỌN DATABASE 
USE BD8888;
GO
-- BẢNG NHÂN VIÊN
CREATE TABLE Staffs(
	StaffID INT IDENTITY(10000,1) PRIMARY KEY NOT NULL,
	StaffPersonalID NVARCHAR(12) NOT NULL,
	StaffName NVARCHAR(50) NOT NULL,
	StaffPhone NVARCHAR(10) NOT NULL,
	StaffEmail NVARCHAR(50) NOT NULL,
	StaffAddress NVARCHAR(50) NOT NULL,
	StaffSalary INT NOT NULL,
	StaffImage IMAGE,
);
GO

-- BẢNG TÀI KHOẢN NHÂN VIÊN
CREATE TABLE Accounts(
	AccountID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	StaffEmail NVARCHAR(50) NOT NULL,
	AccountPassword NVARCHAR(20) NOT NULL,
	StaffID INT NOT NULL,
	FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID),
);
GO

-- BẢNG KHOA
CREATE TABLE Departments(
	DepartmentID NVARCHAR(20) PRIMARY KEY NOT NULL,
	DepartmentName NVARCHAR(50) NOT NULL
);
GO
-- BẢNG NGÀNH
CREATE TABLE Majors(
	MajorID NVARCHAR(20) PRIMARY KEY NOT NULL,
	MajorName NVARCHAR(50) NOT NULL,
	DepartmentID NVARCHAR(20) NOT NULL,
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
GO

-- BẢNG CHUYÊN NGÀNH
CREATE TABLE Specializations(
	SpecializationID NVARCHAR(20) PRIMARY KEY NOT NULL,
	SpecializationName NVARCHAR(50) NOT NULL,
	MajorID NVARCHAR(20) NOT NULL,
	FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
);
GO

-- BẢNG LỚP
CREATE TABLE Classrooms(
	ClassID NVARCHAR(20) PRIMARY KEY NOT NULL,
	ClassName NVARCHAR(20) NOT NULL,
	SpecializationID NVARCHAR(20) NOT NULL,
	MajorID NVARCHAR(20) NOT NULL,
	FOREIGN KEY (SpecializationID) REFERENCES Specializations(SpecializationID),
	FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
);
GO

-- BẢNG SINH VIÊN
CREATE TABLE Students(
	StudentID NVARCHAR(20) PRIMARY KEY NOT NULL,
	ClassID NVARCHAR(20) NOT NULL,
	StudentName NVARCHAR(50) NOT NULL,
	StudentGender NVARCHAR(5) NOT NULL,
	StudentDOB DATE NOT NULL,
	StudentPersonalID NVARCHAR(12) NOT NULL,
	StudentEmail NVARCHAR(50) NOT NULL,
	StudentPhone NVARCHAR(10) NOT NULL,
	StudentAddress NVARCHAR(50) NOT NULL,
	StudentLived BIT,
	StudentImage IMAGE,
	FOREIGN KEY (ClassID) REFERENCES Classrooms(ClassID)
);
GO

-- BẢNG KHU PHÒNG
CREATE TABLE Areas(
	AreaID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	AreaName NVARCHAR(10) NOT NULL
);
GO

-- BẢNG LOẠI PHÒNG
CREATE TABLE RoomTypes(
	RoomTypeID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	RoomTypeName NVARCHAR(20) NOT NULL,
	RoomTypePrice INT NOT NULL, 
	RoomCapacity INT NOT NULL
);
GO

-- BẢNG PHÒNG
CREATE TABLE Rooms(
	RoomID INT IDENTITY(10000, 1) PRIMARY KEY NOT NULL,
	RoomName NVARCHAR(20) NOT NULL,
	RoomStatus NVARCHAR(20) NOT NULL,
	AreaID INT NOT NULL,
	RoomTypeID INT NOT NULL,
	FOREIGN KEY (AreaID) REFERENCES Areas(AreaID),
	FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(RoomTypeID)
);
GO

-- BẢNG HỢP ĐỒNG
CREATE TABLE Contracts(
	ContractID INT IDENTITY(10000, 1) PRIMARY KEY NOT NULL,
	StudentID NVARCHAR(20) NOT NULL,
	StaffID INT NOT NULL,
	AreaID INT NOT NULL,
	ContractState BIT,
	ContractDeposit INT NOT NULL,
	RoomID INT NOT NULL,
	RoomTypeID INT NOT NULL,
	CheckInDate DATE NOT NULL,
	CheckOutDate DATE NOT NULL,
	FOREIGN KEY (AreaID) REFERENCES Areas(AreaID),
	FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
	FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(RoomTypeID),
	FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
	FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);
GO

-- BẢNG DỊCH VỤ
CREATE TABLE Services(
	ServiceID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	ServiceName NVARCHAR(20) NOT NULL,
	ServicePrice INT NOT NULL,
	ServiceUnit NVARCHAR(20) NOT NULL,
);
GO

-- BẢNG SỬ DỤNG DỊCH VỤ
CREATE TABLE Usages(
	UsageID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	ServiceID INT NOT NULL,
	UsageQuantity INT NOT NULL,
	RoomID INT NOT NULL,
	UsageMonth INT NOT NULL,
	UsageYear INT NOT NULL,
	FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);
GO

-- BẢNG HOÁ ĐƠN
CREATE TABLE Bills(
	BillID INT IDENTITY(10000, 1) PRIMARY KEY NOT NULL,
	RoomID INT NOT NULL,
	BillMonth INT NOT NULL,
	BillYear INT NOT NULL,
	BillCreationDate DATE NOT NULL, 
	StaffID INT NOT NULL,
	BillPaid BIT
	FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);
GO

-- Bảng Student Bill
CREATE TABLE StudentBills(
	BillID INT IDENTITY(10000, 1) PRIMARY KEY NOT NULL,
	RoomID INT NOT NULL,
	StudentID NVARCHAR(20) NOT NULL,
	BillMonth INT NOT NULL,
	BillYear INT NOT NULL,
	BillCreationDate DATE NOT NULL,
	StaffID INT NOT NULL,
	BillTotalMoney INT NOT NULL,
	BillPaid BIT 
	FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);
GO

-- Bảng Tháng
CREATE TABLE Months(
	MonthID INT PRIMARY KEY NOT NULL,
	MonthName INT NOT NULL,
);
GO

-- Bảng Năm
CREATE TABLE Years(
	YearID INT PRIMARY KEY NOT NULL,
	YearName INT NOT NULL,
);
GO

-- Bảng Thời hạn hợp đồng
CREATE TABLE DateContract(
	DateContractID INT PRIMARY KEY NOT NULL,
	DateContractName INT NOT NULL,
)
----------------------------------------------------------------------------------------
--Insert Data To Months
INSERT INTO Months (MonthID, MonthName)
VALUES
('1', '1'),
('2', '2'),
('3', '3'),
('4', '4'),
('5', '5'),
('6', '6'),
('7', '7'),
('8', '8'),
('9', '9'),
('10', '10'),
('11', '11'),
('12', '12');
GO

--Insert data into Years
DECLARE @Year INT = 2020;

WHILE @Year <= 2035
BEGIN
    INSERT INTO Years (YearID, YearName)
    VALUES
    (CAST(@Year AS VARCHAR(4)), CAST(@Year AS VARCHAR(4)));

    SET @Year = @Year + 1;
END;

-- Insert data to DateContract
INSERT INTO DateContract (DateContractID, DateContractName)
VALUES
(6, 6),
(12, 12),
(18, 18),
(24, 24)
GO

-- INSERT DATA TO Departments
INSERT INTO Departments (DepartmentID , DepartmentName)
VALUES
('FIT', N'Công nghệ thông tin'),
('FE', N'Kinh tế'),
('MI', N'Cơ khí'),
('CI', N'Công trình');
GO

-- INSERT DATA TO Majors
INSERT INTO Majors (MajorID, MajorName, DepartmentID)
VALUES
('7480201', N'Công nghệ thông tin', 'FIT'),
('7480104', N'Hệ thống thông tin', 'FIT'),
('7340101', N'Quản trị kinh doanh', 'FE'),
('7340122', N'Thương mại điện tử', 'FE'),
('7340201', N'Tài chính – Ngân hàng', 'FE'),
('7340301', N'Kế toán', 'FE'),
('7510201', N'Công nghệ kỹ thuật Cơ khí', 'MI'),
('7510102', N'Công nghệ kỹ thuật công trình xây dựng', 'CI');
GO

-- INSERT DATA TO Specializations
INSERT INTO Specializations(SpecializationID, SpecializationName, MajorID)
VALUES
('IT1', N'Công nghệ thông tin', '7480201'),
('IT2', N'Hệ thống thông tin', '7480104'),
('QTKD1', N'Quản trị doanh nghiệp', '7340101'),
('QTKD2', N'Quản trị Marketing', '7340101'),
('TCNH1', N'Tài chính doanh nghiệp', '7340201'),
('TCNH2', N'Hải quan và Logistics', '7340201'),
('TMDT', N'Thương mại điện tử', '7340122'),
('KT', N'Kế toán doanh nghiệp', '7340301'),
('CNKTCK1', N'CNKTCK Tàu thủy và thiết bị nổi', '7510201'),
('CNKTCK2', N'CNKTCK Đầu máy -toa xe và tàu điện Metro', '7510201'),
('CNKTCK3', N'CNKTCK Máy xây dựng', '7510201'),
('CNKTCTXD1', N'Công nghệ kỹ thuật CTXD DD&CN', '7510102'),
('CNKTCTXD2', N'Xây dựng và quản lý hạ tầng đô thị', '7510102'),
('CNKTCTXD3', N'Kiến trúc nội thất', '7510102');
GO


-- INSERT DATA TO Classrooms
INSERT INTO Classrooms(ClassID, ClassName, SpecializationID, MajorID)
VALUES
('73DCTT20', '73DCTT20', 'IT1', '7480201'),
('73DCTT21', '73DCTT21', 'IT1', '7480201'),
('73DCTT22', '73DCTT22', 'IT1', '7480201'),
('73DCTT23', '73DCTT23', 'IT1', '7480201'),
('73DCTT24', '73DCTT24', 'IT1', '7480201'),
('73DCHT20', '73DCHT20', 'IT2', '7480104'),
('73DCHT21', '73DCHT21', 'IT2', '7480104'),
('73DCHT22', '73DCHT22', 'IT2', '7480104'),
('73DCHT23', '73DCHT23', 'IT2', '7480104'),
('73DCHT24', '73DCHT24', 'IT2', '7480104'),
('73DCQT21', '73DCQT21', 'QTKD1', '7340101'),
('73DCQT22', '73DCQT22', 'QTKD1', '7340101'),
('73DCQT23', '73DCQT23', 'QTKD1', '7340101'),
('73DCQT24', '73DCQT24', 'QTKD1', '7340101'),
('73DCQM21', '73DCQM21', 'QTKD2', '7340101'),
('73DCQM22', '73DCQM22', 'QTKD2', '7340101'),
('73DCQM23', '73DCQM23', 'QTKD2', '7340101'),
('73DCQM24', '73DCQM24', 'QTKD2', '7340101');
GO

-- INSERT INTO Areas
INSERT INTO Areas (AreaName)
VALUES
(N'Khu A'),
(N'Khu B'),
(N'Khu C'),
(N'Khu D'),
(N'Khu E'),
(N'Khu F'),
(N'Khu G');
GO

-- INSERT INTO RoomTypes
INSERT INTO RoomTypes(RoomTypeName, RoomCapacity, RoomTypePrice)
VALUES
(N'Loại 1', 8, 500000),
(N'Loại 2', 6, 700000),
(N'Loại 3', 4, 1000000);
GO

-- INSERT INTO Rooms
INSERT INTO Rooms(RoomName, RoomStatus, AreaID, RoomTypeID)
VALUES
('A101', N'Hoạt động', '1', '1'),
('A102', N'Hoạt động', '1', '1'),
('A103', N'Hoạt động', '1', '1'),
('A201', N'Hoạt động', '1', '1'),
('A202', N'Hoạt động', '1', '1'),
('A203', N'Hoạt động', '1', '1'),
('B101', N'Hoạt động', '2', '2'),
('B102', N'Hoạt động', '2', '2'),
('B103', N'Hoạt động', '2', '2'),
('B201', N'Hoạt động', '2', '2'),
('B202', N'Hoạt động', '2', '2'),
('B203', N'Hoạt động', '2', '2')
GO

--INSERT INTO Services
INSERT INTO Services(ServiceName, ServicePrice, ServiceUnit)
VALUES
( N'Điện sinh hoạt', 2500, N'kWh'),
( N'Nước sinh hoạt', 8000, N'm3'),
( N'Internet', 1000000, N'Tháng'),
( N'Vệ sinh', 1000000, N'Tháng');
GO
-- INSERT INTO USAGES
INSERT INTO Usages(ServiceID, UsageQuantity, RoomID, UsageMonth, UsageYear)
VALUES
('1', '120', '10001', '1', '2024'),
('2', '120', '10001', '1', '2024'),
('3', '1', '10001', '1', '2024'),
('4', '1', '10001', '1', '2024'),
('1', '120', '10002', '1', '2024'),
('2', '150', '10002', '1', '2024'),
('3', '1', '10002', '1', '2024'),
('4', '1', '10002', '1', '2024'),
('1', '111', '10003', '1', '2024'),
('2', '112', '10003', '1', '2024'),
('3', '1', '10003', '1', '2024'),
('4', '1', '10003', '1', '2024')
GO

--INSERT INTO Staffs
INSERT INTO Staffs(StaffName, StaffPhone, StaffEmail, StaffAddress, StaffPersonalID, StaffSalary)
VALUES
(N'Minh Thư', '0835595678', 'minhthu@gmail.com', N'Thanh Hoá', '038204113411', 2500000),
(N'Trịnh Hạnh', '0989898989', 'trinhhanh@gmail.com', N'Chương Mỹ, Hà Nội', '038204000000', 3500000),
(N'Quang Huy', '0989899999', 'quanghuy@gmail.com', N'Dubai, Hà Nội', '038204009999', 1500000),
(N'Hoàng Văn Quân', '0989898888', 'hoangquan@gmail.com', N'Nhà Tù Hoả Lò, Hà Nội', '038204001111', 5000000)
GO

--INSERT INTO Students
INSERT INTO Students(StudentID, ClassID, StudentName, StudentGender, StudentDOB, StudentPersonalID, StudentEmail, StudentPhone, StudentAddress, StudentLived)
VALUES
('73DCTT22428', '73DCTT21', N'Nguyễn Văn Dũng', 'Nam', '2004-07-23', '038204004400', N'vandunxg@gmail.com', '0835595675', N'Hoằng Hoá, Thanh Hoá', 1),
('73DCTT22421', '73DCTT22', N'Nguyễn Thị Mai', N'Nữ', '2002-09-15', '038204001111', N'thimai@gmail.com', '0835591111', N'Chương Mỹ, Hà Nội', 0),
('73DCTT22422', '73DCTT23', N'Trần Văn Hùng', 'Nam', '2003-04-28', '038204002222', N'vandung@gmail.com', '0835598888', N'Chương Mỹ, Hà Nội', 0),
('73DCTT22423', '73DCHT24', N'Lê Thị Hồng', N'Nữ', '2004-11-03', '038204003333', N'thihong@gmail.com', '0835597777', N'Chương Mỹ, Hà Nội', 0),
('73DCTT22424', '73DCQT22', N'Phạm Minh Quân', 'Nam', '2005-06-19', '038204004444', N'minhquan@gmail.com', '0835592121', N'Nhà Tù Hoả Lò, Hà Nội', 0),
('73DCTT22425', '73DCQT22', N'Võ Thị Trang', N'Nữ', '2002-12-08', '038204004444', N'thitrang@gmail.com', '0835592222', N'Nhà Tù Hoả Lò, Hà Nội', 0),
('73DCTT22426', '73DCQM22', N'Hoàng Đức Anh', 'Nam', '2003-08-22', '038204004466', N'ducanh@gmail.com', '0835592112', N'Nhà Tù Hoả Lò, Hà Nội', 1),
('73DCTT22427', '73DCQM22', N'Bùi Thị Linh', N'Nữ', '2004-02-14', '038204004412', N'thilinh@gmail.com', '0835591221', N'Nhà Tù Hoả Lò, Hà Nội', 1),
('73DCTT22411', '73DCTT21', N'Đặng Văn Tuấn', 'Nam', '2005-01-07', '038204007776', N'vantuan@gmail.com', '0835595212', N'Cà Mau', 1),
('73DCTT22429', '73DCTT21', N'Ngô Thị Hoa', N'Nữ', '2002-05-31', '038204008888', N'thihoa@gmail.com', '0835595622', N'Cà Mau', 1),
('73DCTT22432', '73DCTT21', N'Trịnh Minh Tâm', N'Nữ', '2003-10-12', '038204009999', N'minhtam@gmail.com', '0835555555', N'Cà Mau', 0)
GO

INSERT INTO Accounts(StaffEmail, AccountPassword, StaffID)
VALUES
('minhthu@gmail.com', 'dung2004', '10000'),
('trinhhanh@gmail.com', 'dung2004', '10001'),
('quanghuy@gmail.com', 'dung2004', '10002'),
('hoangquan@gmail.com', 'dung2004', '10003')
GO
-----------------------------------------------------------------------------------------------------------------------------------------
GO

-- Get Data Students
CREATE PROC GetStudents
AS
BEGIN
	SELECT 
	StudentID AS N'Mã SV',
	StudentName AS N'Họ tên',
	StudentDOB AS N'Ngày sinh',
	StudentAddress AS N'Địa chỉ',
	StudentGender AS N'Giới tính',
	StudentPhone AS N'SĐT',
	StudentEmail AS N'Email',
	StudentPersonalID AS 'CCCD',
	ClassID AS N'Lớp',
	StudentLived AS 'Từng ở'
	FROM dbo.Students
END;
GO


CREATE PROC SearchStudents
@StudentID NVARCHAR(20)
AS
BEGIN
	SELECT * FROM Students
	WHERE Students.StudentID = @StudentID;
END;
GO

-- Get Speicializations 
CREATE PROC GetSpecializations 
AS
BEGIN
	SELECT * FROM dbo.Specializations
END;
GO

-- Get Classroom 
CREATE PROC GetClassroom 
@SpecializationID NVARCHAR(20)
AS
BEGIN
	SELECT * FROM dbo.Classrooms
	WHERE SpecializationID = @SpecializationID
END;
GO

-- Insert Data Students to Sql
CREATE PROC InsertDataStudents 
 @StudentID NVARCHAR(20), @ClassID NVARCHAR(20) , @StudentName NVARCHAR(50) , @StudentGender NVARCHAR(5) , 
 @StudentDOB DATE , @StudentPersonalID NVARCHAR(12) , @StudentEmail NVARCHAR(50) , @StudentPhone NVARCHAR(10) ,  @StudentAddress NVARCHAR(50) , @StudentLived BIT 
AS
BEGIN
	INSERT INTO dbo.Students
	(
		StudentID,
	    ClassID,
	    StudentName,
	    StudentGender,
	    StudentDOB,
	    StudentPersonalID,
	    StudentEmail,
	    StudentPhone,
	    StudentAddress,
	    StudentLived
	)
	VALUES
	(   @StudentID,
		@ClassID,
		@StudentName,
		@StudentGender,
		@StudentDOB,
		@StudentPersonalID,
		@StudentEmail,
		@StudentPhone,
		@StudentAddress,
		@StudentLived
	    )
END;
GO

-- Update Data Students to Sql
CREATE PROC UpdateDataStudents 
@StudentID NVARCHAR(20) , @ClassID NVARCHAR(20) , @StudentName NVARCHAR(50) , @StudentGender NVARCHAR(5) , 
 @StudentDOB DATE , @StudentPersonalID NVARCHAR(12) , @StudentEmail NVARCHAR(50) , @StudentPhone NVARCHAR(10) ,  @StudentAddress NVARCHAR(50) , @StudentLived BIT 
AS
BEGIN
	UPDATE dbo.Students
	SET
		ClassID = @ClassID,
		StudentName = @StudentName,
		StudentGender = @StudentGender,
		StudentDOB = @StudentDOB,
		StudentPersonalID = @StudentPersonalID,
		StudentEmail = @StudentEmail,
		StudentPhone = @StudentPhone, 
		StudentAddress = @StudentAddress,
		StudentLived = @StudentLived
	WHERE StudentID = @StudentID;
END;
GO
                
-- Delete Data Students to Sql
CREATE PROC DeleteDataStudents 
@StudentID NVARCHAR(20)
AS
BEGIN
	DELETE FROM Students WHERE StudentID = @StudentID
END;
GO

-- Update Contracts When Delete Students
CREATE PROC UpdateContractWhenStudentDeleted
@StudentID NVARCHAR(20)
AS
BEGIN
	UPDATE Contracts
	SET ContractState = '0'
	WHERE Contracts.StudentID = @StudentID
END;
GO
-- Get Room From sql
CREATE PROC GetRooms
AS
BEGIN
	SELECT
		Rooms.*,
		Areas.AreaName,
		RoomTypes.RoomCapacity,
		COUNT(Contracts.ContractID) AS NumberOfContracts
	FROM
		Rooms
	JOIN Areas ON Rooms.AreaID = Areas.AreaID
	JOIN RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
	LEFT JOIN Contracts ON Rooms.RoomID = Contracts.RoomID
	GROUP BY
		Rooms.RoomID, Rooms.RoomName, Rooms.RoomStatus, Rooms.AreaID, Rooms.RoomTypeID, Areas.AreaName, RoomTypes.RoomCapacity;
END;
GO

CREATE PROC GetRoomServices
    @AreaID INT,
    @RoomTypeID INT
AS
BEGIN
    SELECT
        Rooms.RoomID,
        Rooms.RoomName
    FROM
        Rooms
    INNER JOIN
        Areas ON Rooms.AreaID = Areas.AreaID
    INNER JOIN
        RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
    WHERE
        Areas.AreaID = @AreaID
        AND RoomTypes.RoomTypeID = @RoomTypeID;
END;
GO

-- Get RoomTypes From Sql
CREATE PROC GetRoomTypes
AS
BEGIN
	SELECT * FROM RoomTypes
END;
GO

-- Get Areas From Sql
CREATE PROC GetAreas
AS
BEGIN
	SELECT * FROM Areas
END;
GO

-- Get Room From Sql
CREATE PROC GetAddRooms
AS
BEGIN
	SELECT
        Rooms.RoomID,
        Rooms.RoomName,
        Rooms.RoomStatus,
        RoomTypes.RoomTypeName,
        Areas.AreaName,
        RoomTypes.RoomCapacity
    FROM
        Rooms
    JOIN RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
    JOIN Areas ON Rooms.AreaID = Areas.AreaID;
END;
GO

--Insert Rooms To Sql
CREATE PROC InsertRoomsData
@RoomName NVARCHAR(20) , @RoomStatus NVARCHAR(20) ,
@AreaID NVARCHAR(20) , @RoomTypeID NVARCHAR(20)
AS
BEGIN
	INSERT INTO Rooms (RoomName, RoomStatus , AreaID , RoomTypeID)
	VALUES
	( @RoomName , @RoomStatus , @AreaID , @RoomTypeID)
END;
GO



-- Update Rooms To Sql
CREATE PROC UpdateRoomsData
@RoomID NVARCHAR(20) , @RoomStatus NVARCHAR(20) , @RoomTypeID NVARCHAR(20)
AS
BEGIN
	UPDATE Rooms
	SET
		RoomStatus = @RoomStatus,
		RoomTypeID = @RoomTypeID
	WHERE RoomID = @RoomID
END;
GO

-- Sql Get Student Information in Room
CREATE PROCEDURE GetStudentsInRoom
    @RoomID NVARCHAR(20)
AS 
BEGIN
    SELECT Students.StudentName, Students.StudentID
    FROM Students
    INNER JOIN Contracts ON Students.StudentID = Contracts.StudentID
    INNER JOIN Rooms ON Contracts.RoomID = Rooms.RoomID
    WHERE Contracts.RoomID = @RoomID;
END;
GO


CREATE PROC GetRoomBills
@RoomID NVARCHAR(20)
AS
BEGIN
	SELECT *
	FROM Bills
	WHERE RoomID = @RoomID
END;
GO

CREATE PROC GetUsageService
    @RoomID NVARCHAR(20)
AS 
BEGIN
    SELECT Usages.ServiceID, Usages.UsageQuantity, Services.ServicePrice, Services.ServiceName
    FROM Usages
    INNER JOIN Services ON Usages.ServiceID = Services.ServiceID
    WHERE Usages.RoomID = @RoomID;
END;
GO

CREATE PROC GetInforUsageServices
    @RoomID NVARCHAR(20), @Months INT, @Years INT
AS 
BEGIN
    SELECT Services.ServiceName, Usages.UsageQuantity, Usages.UsageQuantity * Services.ServicePrice AS TotalMoney
    FROM Usages
    INNER JOIN Services ON Usages.ServiceID = Services.ServiceID
    WHERE Usages.RoomID = @RoomID AND Usages.UsageMonth = @Months AND Usages.UsageYear = @Years;
END;
GO


CREATE PROCEDURE LoadRoomToCreateBill
    @AreaID INT, @RoomTypeID INT
AS
BEGIN
    SELECT
        Rooms.RoomID,
        Rooms.RoomName
    FROM
        Rooms
    JOIN
        Areas ON Rooms.AreaID = Areas.AreaID AND Areas.AreaID = @AreaID
    JOIN
        RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID AND RoomTypes.RoomTypeID = @RoomTypeID
    LEFT JOIN
        Contracts ON Rooms.RoomID = Contracts.RoomID
    GROUP BY
        Rooms.RoomID, Rooms.RoomName, Rooms.RoomStatus, Rooms.AreaID, Rooms.RoomTypeID, Areas.AreaName, RoomTypes.RoomCapacity
    HAVING
        COUNT(Contracts.ContractID) < RoomTypes.RoomCapacity;
END;
GO	

-- INSERT INTO Contracts
CREATE PROC InsertDataContracts
@StudentID NVARCHAR(20), @RoomID INT , @StaffID INT , @AreaID INT, @RoomTypeID INT,
@ContractState BIT , @CheckInDate DATE , @CheckOutDate DATE ,
@ContractDeposit INT
AS
BEGIN
	INSERT INTO Contracts(StudentID, RoomID, StaffID, AreaID, RoomTypeID, ContractState, CheckInDate, CheckOutDate, ContractDeposit)
	VALUES
	(
		@StudentID,
		@RoomID,
		@StaffID,
		@AreaID,
		@RoomTypeID,
		@ContractState,
		@CheckInDate,
		@CheckOutDate,
		@ContractDeposit
	)
END;
GO


CREATE PROCEDURE GetContractDetails
AS
BEGIN
    -- Truy vấn của bạn với CASE
    SELECT
        Contracts.ContractID AS N'Mã HĐ',
        Contracts.StudentID AS N'Mã SV',
        Contracts.StaffID AS N'Mã NV',
		Areas.AreaName AS N'Khu',
		RoomTypes.RoomTypeName AS N'Loại phòng',
		Rooms.RoomName AS N'Phòng',
        Contracts.CheckInDate AS N'Ngày tạo HĐ',
        Contracts.CheckOutDate AS N'Ngày hết hạn',
        Contracts.ContractDeposit AS N'Tiền cọc'
    FROM
        Contracts
	INNER JOIN
		Rooms ON Rooms.RoomID = Contracts.RoomID
    INNER JOIN
        Areas ON Areas.AreaID = Contracts.AreaID
    INNER JOIN
        RoomTypes ON RoomTypes.RoomTypeID = Contracts.RoomTypeID;
END;
GO

CREATE PROCEDURE SearchContracts
@StudentID NVARCHAR(20)
AS
BEGIN
    -- Truy vấn của bạn với CASE
    SELECT
        Contracts.ContractID,
        Contracts.StudentID,
        Contracts.StaffID,
		Rooms.RoomName,
        Contracts.CheckInDate,
        Contracts.CheckOutDate,
        CASE
            WHEN Contracts.ContractState = 1 THEN N'Còn hiệu lực'
            WHEN Contracts.ContractState = 0 THEN N'Hết hiệu lực'
        END AS ContractState, -- Thêm CASE cho ContractState
        Areas.AreaName,
        RoomTypes.RoomTypeName
    FROM
        Contracts
	INNER JOIN
		Rooms ON Rooms.RoomID = Contracts.RoomID
    INNER JOIN
        Areas ON Areas.AreaID = Contracts.AreaID
    INNER JOIN
        RoomTypes ON RoomTypes.RoomTypeID = Contracts.RoomTypeID
	WHERE Contracts.StudentID = @StudentID;
END;
GO

CREATE PROC GetServices
AS
BEGIN
    SELECT * 
	FROM Services
END;
GO

CREATE PROC InsertUsages
@RoomID INT , @ServiceID INT , @Months INT , @Years INT , @UsageQuantity INT
AS
BEGIN
	INSERT INTO Usages (RoomID , ServiceID, UsageMonth, UsageYear, UsageQuantity)
VALUES
	(
		@RoomID,
		@ServiceID,
		@Months,
		@Years,
		@UsageQuantity
	)
END;
GO

CREATE PROCEDURE GetUsageDetails
AS
BEGIN
    SELECT
        Usages.UsageID AS 'ID',
        Services.ServiceName AS N'Dịch vụ',
        Usages.UsageQuantity AS N'Lượng sử dụng',
        Usages.RoomID AS N'Mã phòng',
        Usages.UsageMonth AS N'Tháng',
        Usages.UsageYear AS N'Năm',
        Usages.UsageQuantity * Services.ServicePrice AS N'Thành tiền'
    FROM
        Usages
    JOIN
        Services ON Services.ServiceID = Usages.ServiceID;
END;
GO

CREATE PROCEDURE SearchUsageDetails
@RoomID NVARCHAR(20), @Months INT , @Years INT
AS
BEGIN
    SELECT
        Usages.UsageID AS 'ID',
        Services.ServiceName AS N'Dịch vụ',
        Usages.UsageQuantity AS N'Lượng sử dụng',
        Usages.RoomID AS N'Mã phòng',
        Usages.UsageMonth AS N'Tháng',
        Usages.UsageYear AS N'Năm',
        Usages.UsageQuantity * Services.ServicePrice AS N'Thành tiền'
    FROM
        Usages
    JOIN
        Services ON Services.ServiceID = Usages.ServiceID
	WHERE Usages.RoomID = @RoomID AND Usages.UsageMonth = @Months AND Usages.UsageYear = @Years;
END;
GO

CREATE PROC UpdateContracts
@ContractID INT, @ContractDeposit INT
AS
BEGIN
	UPDATE Contracts
	SET ContractDeposit = @ContractDeposit
	WHERE ContractID = @ContractID
END;
GO

CREATE PROC UpdateUsages
@UsageID INT, @RoomID INT, @ServiceID INT, @UsageQuantity INT, @Months INT, @Years INT
AS
BEGIN
	UPDATE Usages
	SET
		RoomID = @RoomID,
		ServiceID = @ServiceID,
		UsageQuantity = @UsageQuantity,
		UsageMonth = @Months,
		UsageYear = @Years
	WHERE UsageID = @UsageID
END;
GO


CREATE PROC InsertServices
@ServiceName NVARCHAR(50), @ServicePrice INT, @ServiceUnit NVARCHAR(20)
AS
BEGIN
	INSERT INTO Services(ServiceName, ServicePrice, ServiceUnit)
	VALUES
	(
		@ServiceName,
		@ServicePrice,
		@ServiceUnit
	)
END;
GO


CREATE PROC UpdateServices
@ServiceID INT, @ServiceName NVARCHAR(50), @ServicePrice INT, @ServiceUnit NVARCHAR(20)
AS
BEGIN
	UPDATE Services
	SET
		
		ServiceName = @ServiceName,
		ServicePrice = @ServicePrice,
		ServiceUnit = @ServiceUnit
	WHERE ServiceID = @ServiceID
END;
GO

CREATE PROC GetBills
AS
BEGIN
	SELECT
		BillID AS N'Mã Hoá đơn',
		RoomID AS N'Mã phòng',
		BillMonth AS N'Tháng',
		BillYear AS N'Năm',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillPaid AS N'Tình trạng'
	FROM Bills
END;
GO

CREATE PROC SearchBills
@RoomID NVARCHAR(20)
AS
BEGIN
	SELECT
		BillID AS N'Mã Hoá đơn',
		RoomID AS N'Mã phòng',
		BillMonth AS N'Tháng',
		BillYear AS N'Năm',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillPaid AS N'Tình trạng'
	FROM Bills
	WHERE RoomID = @RoomID
END;
GO

CREATE PROC SearchBillsPaid
@BillPaid INT
AS
BEGIN
	SELECT
		BillID AS N'Mã Hoá đơn',
		RoomID AS N'Mã phòng',
		BillMonth AS N'Tháng',
		BillYear AS N'Năm',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillPaid AS N'Tình trạng'
	FROM Bills
	WHERE BillPaid = @BillPaid
END;
GO

CREATE PROC InsertBills
@RoomID INT, @StaffID INT, @Months INT, @Years INT, @DateCreation DATE
AS
BEGIN
	INSERT INTO Bills(RoomID, StaffID, BillMonth, BillYear, BillCreationDate, BillPaid)
	VALUES
	(
		@RoomID,
		@StaffID,
		@Months,
		@Years,
		@DateCreation,
		'0'
	)
END;
GO

CREATE PROCEDURE GetServicesToBill
    @RoomID INT, 
    @Months INT, 
    @Years INT
AS
BEGIN
    SELECT 
        Usages.UsageID AS 'ID',
        Services.ServiceName AS 'Tên dịch vụ',
        Usages.UsageQuantity AS 'Số lượng',
        Usages.UsageQuantity * Services.ServicePrice AS 'Thành tiền'
    FROM 
        Usages
    INNER JOIN 
        Services ON Usages.ServiceID = Services.ServiceID
    WHERE 
        Usages.RoomID = @RoomID 
        AND Usages.UsageMonth = @Months 
        AND Usages.UsageYear = @Years;
END;
GO

CREATE PROC CalTotalMoneyBill
    @RoomID INT, 
    @Months INT, 
    @Years INT
AS
BEGIN
    DECLARE @TotalMoney INT;
	SELECT
	@TotalMoney = ISNULL(@TotalMoney, 0) + Usages.UsageQuantity * Services.ServicePrice
    
	FROM 
        Usages
    INNER JOIN 
        Services ON Usages.ServiceID = Services.ServiceID
    WHERE 
        Usages.RoomID = @RoomID 
        AND Usages.UsageMonth = @Months 
        AND Usages.UsageYear = @Years;
	SELECT @TotalMoney AS 'Thành tiền';
END;
GO

CREATE PROC UpdateStaffs
@StaffID INT, @StaffName NVARCHAR(50), @StaffPhone NVARCHAR(10), @StaffAddress NVARCHAR(50), @StaffPersonalID NVARCHAR(15)
AS
BEGIN
	UPDATE Staffs
	SET
		StaffName = @StaffName,
		StaffPhone = @StaffPhone,
		StaffAddress = @StaffAddress,
		StaffPersonalID = @StaffPersonalID
	WHERE StaffID = @StaffID
END;
GO

CREATE PROC UpdateEmail
@StaffID INT, @StaffEmail NVARCHAR(50)
AS
BEGIN
	UPDATE Staffs
	SET
		StaffEmail = @StaffEmail
	WHERE StaffID = @StaffID
END;
GO

CREATE PROC UpdatePassword
@StaffID INT, @StaffEmail NVARCHAR(50) , @Password NVARCHAR(50)
AS
BEGIN
	UPDATE Accounts
	SET
		StaffEmail = @StaffEmail,
		AccountPassword = @Password
	WHERE Accounts.StaffID = @StaffID
END;
GO

CREATE PROC TotalUsageCost
@ServiceID INT, @Months INT, @Years INT
AS
	BEGIN	
		SELECT
			SUM(s.ServicePrice * u.UsageQuantity) AS TotalUsageCost
		FROM
			Services s
		JOIN
			Usages u ON s.ServiceID = u.ServiceID
		WHERE
			s.ServiceID = @ServiceID
			AND u.UsageMonth = @Months
			AND u.UsageYear = @Years
		GROUP BY
			s.ServiceID, s.ServiceName;
END;
GO

CREATE PROCEDURE CalTotalMoneyAllRoom
    @Months INT, 
    @Years INT
AS
BEGIN
    DECLARE @TotalMoney INT = 0; -- Khởi tạo giá trị mặc định cho @TotalMoney

    SELECT
        @TotalMoney += Usages.UsageQuantity * Services.ServicePrice
    FROM 
        Usages
    INNER JOIN 
        Services ON Usages.ServiceID = Services.ServiceID
    INNER JOIN 
        Bills ON Usages.RoomID = Bills.RoomID
               AND Usages.UsageMonth = Bills.BillMonth
               AND Usages.UsageYear = Bills.BillYear
    WHERE 
        Usages.UsageMonth = @Months 
        AND Usages.UsageYear = @Years
        AND Bills.BillPaid = 1; -- Chỉ tính tiền cho các hóa đơn đã thanh toán

    SELECT @TotalMoney AS 'TotalMoney';
END;
GO

CREATE PROCEDURE CountRooms
AS
BEGIN
    SELECT COUNT(RoomID) AS "AmountRoom" 
	FROM Rooms
END;
GO

CREATE PROCEDURE CountRoomsActive
AS
BEGIN
    SELECT COUNT(RoomID) AS "AmountRoom" 
	FROM Rooms
	WHERE RoomStatus = N'Hoạt động'
END;
GO

CREATE PROCEDURE CountBills
AS
BEGIN
    SELECT COUNT(BillID) AS "AmountBills" 
	FROM Bills
END;
GO

CREATE PROCEDURE CountBillsPaid
AS
BEGIN
    SELECT COUNT(BillID) AS "AmountBills" 
	FROM Bills
	WHERE BillPaid = '1'
END;
GO

CREATE PROC InsertStudentBills
@RoomID INT, @StudentID NVARCHAR(20), @BillMonth INT, @BillYear INT, @BillCreationDate DATE,
@StaffID INT, @BillTotalMoney INT, @BillPaid BIT
AS
BEGIN
	INSERT INTO StudentBills(RoomID, StudentID, BillMonth, BillYear, BillCreationDate, StaffID, BillTotalMoney, BillPaid)
	VALUES(
		@RoomID,
		@StudentID,
		@BillMonth,
		@BillYear,
		@BillCreationDate,
		@StaffID,
		@BillTotalMoney,
		@BillPaid
	)
END;
GO

CREATE PROC GetStudentBill
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn',
		StudentID AS N'Mã sinh viên',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillTotalMoney AS N'Tổng thanh toán',
		BillPaid AS N'Tình trạng'
	FROM StudentBills
END;
GO

CREATE PROC GetStudentBillFilter
@RoomID INT, @Months INT, @Years INT
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn',
		StudentID AS N'Mã sinh viên',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillTotalMoney AS N'Tổng thanh toán',
		BillPaid AS N'Tình trạng'
	FROM StudentBills
	WHERE
		RoomID = @RoomID 
		AND BillMonth = @Months
		AND BillYear = @Years
END;
GO

CREATE PROC GetStudentBillSearch
@StudentID NVARCHAR(20), @Months INT, @Years INT
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn',
		StudentID AS N'Mã sinh viên',
		BillCreationDate AS N'Ngày tạo',
		StaffID AS N'Mã nhân viên',
		BillTotalMoney AS N'Tổng thanh toán',
		BillPaid AS N'Tình trạng'
	FROM StudentBills
	WHERE
		StudentID = @StudentID 
		AND BillMonth = @Months
		AND BillYear = @Years
END;
GO

CREATE PROC GetDebtBills
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn'
		, StudentID AS N'Mã sinh viên'
		, BillCreationDate AS N'Ngày tạo'
		, StaffID AS N'Mã nhân viên'
		, BillTotalMoney AS N'Tổng tiền'
	FROM StudentBills
	WHERE BillPaid = 0
END;
GO

CREATE PROC GetDebtBillsFilter
@Months INT, @Years INT
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn'
		, StudentID AS N'Mã sinh viên'
		, BillCreationDate AS N'Ngày tạo'
		, StaffID AS N'Mã nhân viên'
		, BillTotalMoney AS N'Tổng tiền'
	FROM StudentBills
	WHERE BillPaid = 0
	AND BillMonth = @Months
	AND BillYear = @Years
END;
GO

CREATE PROC GetPaidBills
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn'
		, StudentID AS N'Mã sinh viên'
		, BillCreationDate AS N'Ngày tạo'
		, StaffID AS N'Mã nhân viên'
		, BillTotalMoney AS N'Tổng tiền'
	FROM StudentBills
	WHERE BillPaid = 1
END;
GO

CREATE PROC GetPaidBillsFilter
@Months INT, @Years INT
AS
BEGIN
	SELECT
		BillID AS N'Mã hoá đơn'
		, StudentID AS N'Mã sinh viên'
		, BillCreationDate AS N'Ngày tạo'
		, StaffID AS N'Mã nhân viên'
		, BillTotalMoney AS N'Tổng tiền'
	FROM StudentBills
	WHERE BillPaid = 1
	AND BillMonth = @Months
	AND BillYear = @Years
END;
GO

CREATE PROCEDURE GetContractOutDate
AS
BEGIN
    -- Truy vấn của bạn với CASE
    SELECT
        Contracts.ContractID AS N'Mã HĐ',
        Contracts.StudentID AS N'Mã SV',
        Contracts.StaffID AS N'Mã NV',
		Areas.AreaName AS N'Khu',
		RoomTypes.RoomTypeName AS N'Loại phòng',
		Rooms.RoomName AS N'Phòng',
        Contracts.CheckInDate AS N'Ngày tạo HĐ',
        Contracts.CheckOutDate AS N'Ngày hết hạn',
        Contracts.ContractDeposit AS N'Tiền cọc'
    FROM
        Contracts
	INNER JOIN
		Rooms ON Rooms.RoomID = Contracts.RoomID
    INNER JOIN
        Areas ON Areas.AreaID = Contracts.AreaID
    INNER JOIN
        RoomTypes ON RoomTypes.RoomTypeID = Contracts.RoomTypeID
	WHERE Contracts.CheckOutDate < GETDATE()
END;
GO

CREATE PROCEDURE RenewContracts
@ContractID INT, @StaffID INT, @CheckInDate DATE, @CheckOutDate DATE
AS
BEGIN
    -- Truy vấn của bạn với CASE
    UPDATE Contracts
	SET
		StaffID = @StaffID
		, CheckInDate = @CheckInDate
		, CheckOutDate = @CheckOutDate
	WHERE Contracts.ContractID = @ContractID;
END;
GO

CREATE PROC DeleteContracts
@ContractID INT
AS
BEGIN
	DELETE FROM Contracts WHERE ContractID = @ContractID
END;
GO

CREATE PROC CmpCheckOutDate
@StudentID NVARCHAR(20)
AS
BEGIN
	SELECT TOP 1 CheckOutDate
	FROM Contracts
	WHERE StudentID = @StudentID
	ORDER BY CheckOutDate DESC;
END;
GO

CREATE PROCEDURE GetTotalMoney
AS
BEGIN
    DECLARE @CurrentMonth INT = MONTH(GETDATE());
    DECLARE @CurrentYear INT = YEAR(GETDATE());

    SELECT SUM(BillTotalMoney) AS TotalPaidAmount
    FROM StudentBills
    WHERE BillPaid = 1
          AND BillMonth = @CurrentMonth
          AND BillYear = @CurrentYear;
END;
GO

----------------------------------------------------------------------
-- github : @vandunxg
-- Author : @vandunxg