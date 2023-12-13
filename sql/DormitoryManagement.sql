-- TẠO DATABASE
CREATE DATABASE DormitoryManagement;
GO

-- CHỌN DATABASE 
USE DormitoryManagement;
GO
-- BẢNG NHÂN VIÊN
CREATE TABLE Staffs(
	StaffID NVARCHAR(20) PRIMARY KEY NOT NULL,
	StaffPersonalID NVARCHAR(12) NOT NULL,
	StaffName NVARCHAR(50) NOT NULL,
	StaffPhone NVARCHAR(10) NOT NULL,
	StaffEmail NVARCHAR(50) NOT NULL,
	StaffAddress NVARCHAR(50) NOT NULL,
	StaffSalary MONEY NOT NULL,
	StaffImage IMAGE,
);
GO



-- BẢNG TÀI KHOẢN NHÂN VIÊN
CREATE TABLE Accounts(
	AccountID NVARCHAR(20) PRIMARY KEY NOT NULL,
	StaffEmail NVARCHAR(50) NOT NULL,
	AccountPassword NVARCHAR(20) NOT NULL,
	StaffID NVARCHAR(20) NOT NULL,
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
	AreaID NVARCHAR(20) PRIMARY KEY NOT NULL,
	AreaName NVARCHAR(10) NOT NULL
);
GO

-- BẢNG LOẠI PHÒNG
CREATE TABLE RoomTypes(
	RoomTypeID NVARCHAR(20) PRIMARY KEY NOT NULL,
	RoomTypeName NVARCHAR(20) NOT NULL,
	RoomTypePrice MONEY NOT NULL, 
	RoomCapacity INT NOT NULL
);
GO
-- BẢNG PHÒNG
CREATE TABLE Rooms(
	RoomID NVARCHAR(20) PRIMARY KEY NOT NULL,
	RoomName NVARCHAR(20) NOT NULL,
	RoomStatus NVARCHAR(20) NOT NULL,
	AreaID NVARCHAR(20) NOT NULL,
	RoomTypeID NVARCHAR(20) NOT NULL,
	FOREIGN KEY (AreaID) REFERENCES Areas(AreaID),
	FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(RoomTypeID)
);
GO

-- BẢNG HỢP ĐỒNG
CREATE TABLE Contracts(
	ContractID NVARCHAR(20) PRIMARY KEY NOT NULL,
	StudentID NVARCHAR(20) NOT NULL,
	StaffID NVARCHAR(20) NOT NULL,
	AreaID NVARCHAR(20) NOT NULL,
	RoomID NVARCHAR(20) NOT NULL,
	RoomTypeID NVARCHAR(20) NOT NULL,
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
	ServiceID NVARCHAR(20) PRIMARY KEY NOT NULL,
	ServiceName NVARCHAR(20) NOT NULL,
	ServicePrice MONEY NOT NULL,
	ServiceUnit NVARCHAR(20) NOT NULL,
);
GO

-- BẢNG SỬ DỤNG DỊCH VỤ
CREATE TABLE Usages(
	UsageID NVARCHAR(20) PRIMARY KEY NOT NULL,
	ServiceID NVARCHAR(20) NOT NULL,
	UsageQuantity INT NOT NULL,
	--RoomID
	FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);
GO

-- BẢNG HOÁ ĐƠN
CREATE TABLE Bills(
	BillID NVARCHAR(20) PRIMARY KEY NOT NULL,
	RoomID NVARCHAR(20) NOT NULL,
	BillMonth INT NOT NULL,
	BillYear INT NOT NULL,
	BillCreationDate DATE NOT NULL, 
	StaffID NVARCHAR(20) NOT NULL,
	UsageID NVARCHAR(20) NOT NULL,
	FOREIGN KEY (UsageID) REFERENCES Usages(UsageID),
	FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
	FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID)
);
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
INSERT INTO Areas (AreaID, AreaName)
VALUES
('A', N'Khu A'),
('B', N'Khu B'),
('C', N'Khu C'),
('D', N'Khu D'),
('E', N'Khu E'),
('F', N'Khu F'),
('G', N'Khu G');
GO

-- INSERT INTO RoomTypes
INSERT INTO RoomTypes(RoomTypeID, RoomTypeName, RoomCapacity, RoomTypePrice)
VALUES
('VIP1', N'VIP 1', 8, 500000),
('VIP2', N'VIP 2', 6, 700000),
('VIP3', N'VIP 3', 4, 1000000);
GO

-- INSERT INTO Rooms
INSERT INTO Rooms(RoomID, RoomName, RoomStatus, AreaID, RoomTypeID)
VALUES
('A101', '101', N'Hoạt động', 'A', 'VIP1'),
('A102', '102', N'Hoạt động', 'A', 'VIP1'),
('A103', '103', N'Hoạt động', 'A', 'VIP1'),
('A104', '104', N'Hoạt động', 'A', 'VIP1'),
('A105', '105', N'Hoạt động', 'A', 'VIP1'),
('B102', '101', N'Hoạt động', 'B', 'VIP2'),
('B103', '102', N'Hoạt động', 'B', 'VIP2'),
('B104', '103', N'Hoạt động', 'B', 'VIP2'),
('B105', '104', N'Hoạt động', 'B', 'VIP2'),
('B106', '105', N'Hoạt động', 'B', 'VIP2'),
('C101', '101', N'Hoạt động', 'C', 'VIP3'),
('C102', '102', N'Hoạt động', 'C', 'VIP3'),
('C201', '201', N'Hoạt động', 'C', 'VIP3'),
('C202', '202', N'Hoạt động', 'C', 'VIP3');
GO

--INSERT INTO Services
INSERT INTO Services(ServiceID, ServiceName, ServicePrice, ServiceUnit)
VALUES
('DV001', N'Điện sinh hoạt', 2500, N'kWh'),
('DV002', N'Nước sinh hoạt', 8000, N'm3'),
('DV003', N'Internet', 1000000, N'Tháng'),
('DV004', N'Vệ sinh', 1000000, N'Tháng');
GO

-- INSERT INTO USAGES
INSERT INTO Usages (UsageID , ServiceID , UsageQuantity)
VALUES

GO

--INSERT INTO Staffs
INSERT INTO Staffs(StaffID, StaffName, StaffPhone, StaffEmail, StaffAddress, StaffPersonalID, StaffSalary)
VALUES
('NV001', N'Nguyễn Văn Dũng', '0835595675', 'contact@vandunxg.com', N'Thanh Hoá', '038204113400', 250000);
GO

--INSERT INTO Students
INSERT INTO Students(StudentID, ClassID, StudentName, StudentGender, StudentDOB, StudentPersonalID, StudentEmail, StudentPhone, StudentAddress, StudentLived)
VALUES
('73DCTT22428', '73DCTT22', N'Nguyễn Văn Dũng', 'Nam', '2004-07-23', '038204004400', N'vandunxg@gmail.com', '0835595675', N'Hoằng Hoá, Thanh Hoá', 1);
GO

-- INSERT INTO Contracts

INSERT INTO Contracts (ContractID , StudentID , StaffID , AreaID , RoomID , RoomTypeID , CheckInDate , CheckOutDate)
VALUES
('S101', '73DCTT22428', 'NV001' , 'A' , 'A101' , 'VIP1' , '2022-10-20' , '2023-10-20')
GO


-----------------------------------------------------------------------------------------------------------------------------------------

-- Get Data Students
CREATE PROC GetStudents
AS
BEGIN
	SELECT * FROM dbo.Students
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
@StudentID NVARCHAR(20) , @ClassID NVARCHAR(10) , @StudentName NVARCHAR(50) , @StudentGender NVARCHAR(5) , 
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
	(   
		@StudentID,
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
@StudentID NVARCHAR(20) , @ClassID NVARCHAR(10) , @StudentName NVARCHAR(50) , @StudentGender NVARCHAR(5) , 
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
	DELETE FROM dbo.Students WHERE StudentID = @StudentID
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
		Rooms.RoomID, Rooms.RoomName, Rooms.RoomStatus,
		RoomTypes.RoomTypeName,
		Areas.AreaName,
		RoomTypes.RoomCapacity
	FROM
		Rooms
	JOIN RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
	JOIN Areas ON Rooms.AreaID = Areas.AreaID
	LEFT JOIN Contracts ON Rooms.RoomID = Contracts.RoomID
END;
GO

--Insert Rooms To Sql
CREATE PROC InsertRoomsData
@RoomID NVARCHAR(20) , @RoomName NVARCHAR(20) , @RoomStatus NVARCHAR(20) ,
@AreaID NVARCHAR(20) , @RoomTypeID NVARCHAR(20)
AS
BEGIN
	INSERT INTO Rooms (RoomID, RoomName, RoomStatus , AreaID , RoomTypeID)
	VALUES
	(@RoomID , @RoomName , @RoomStatus , @AreaID , @RoomTypeID)
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
CREATE PROC GetStudentsinRoom
AS 
BEGIN
	SELECT Students.StudentName , Students.StudentID
	FROM Students , Contracts
	WHERE Contracts.StudentID = Students.StudentID
END;
GO

