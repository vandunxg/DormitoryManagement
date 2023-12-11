--Bảng Tài khoản nhân viên
CREATE TABLE Account(
	Account_ID NVARCHAR(10) PRIMARY KEY NOT NULL,
	Account_Email NVARCHAR(20) NOT NULL,
	Account_Password NVARCHAR(20) NOT NULL
);

-- Bảng Khu KTX
CREATE TABLE Areas(
	AreaID NVARCHAR(5) PRIMARY KEY NOT NULL,
	AreaName NVARCHAR(10) NOT NULL
)

-- Bảng Loại phòng KTX
CREATE TABLE TypesRoom(
	TypeID NVARCHAR(5) PRIMARY KEY NOT NULL,
	TypeName NVARCHAR(5) NOT NULL

)

-- Bảng Khoa 
 CREATE TABLE Departments(
	DepartmentID NVARCHAR(10) PRIMARY KEY NOT NULL,
	DepartmentName NVARCHAR(30) NOT NULL
)


-- Bảng lớp học
CREATE TABLE Classroom(
	ClassID NVARCHAR(10) PRIMARY KEY NOT NULL,
	DepartmentID NVARCHAR(10) NOT NULL,
	ClassName NVARCHAR(10) NOT NULL,
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
)

-- Bảng Phòng KTX
CREATE TABLE Rooms (
    RoomID NVARCHAR(10) PRIMARY KEY NOT NULL,
    RoomNumber NVARCHAR(10) NOT NULL,
    TypeID NVARCHAR(5) NOT NULL,
	AreaID NVARCHAR(5) NOT NULL,
    RoomCapacity INT NOT NULL,
    RoomStatus NVARCHAR(20) NOT NULL,
	FOREIGN KEY (AreaID) REFERENCES Areas(AreaID),
	FOREIGN KEY (TypeID) REFERENCES TypesRoom(TypeID)
)


-- Bảng Sinh viên
CREATE TABLE Students (
    StudentID NVARCHAR(15) PRIMARY KEY NOT NULL,
    StudentName NVARCHAR(20) NOT NULL,
    StudentGender NVARCHAR(5) NOT NULL,
    StudentDOB DATE NOT NULL,
    StudentAddress NVARCHAR(25) NOT NULL,
    StudentPhone NVARCHAR(10) NOT NULL,
	StudentPersonalID NVARCHAR(12) NOT NULL,
	ClassID NVARCHAR(10) NOT NULL,
	DepartmentID NVARCHAR(10) NOT NULL,
	RoomID NVARCHAR(10) NOT NULL,
	CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    StudentLived bit,
	StudentRegResident bit,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID), 
	FOREIGN KEY (ClassID) REFERENCES Classroom(ClassID),
	FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


-- Bảng Dịch vụ
CREATE TABLE Services (
    ServiceID NVARCHAR(10) PRIMARY KEY NOT NULL,
    ServiceElectricity NVARCHAR(10) NOT NULL,
	ServiceWater  NVARCHAR(10) NOT NULL,
	ServiceTotal  NVARCHAR(10) NOT NULL,
	ServiceInternet NVARCHAR(10) NOT NULL,
	ServiceCleaning NVARCHAR(10) NOT NULL,
	Paid BIT,
	RoomID NVARCHAR(10) NOT NULL,
	FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);



CREATE PROC GetRoomsBelowCapacity
@TypeID NVARCHAR(10)
AS
BEGIN
    SELECT RoomID, RoomNumber
    FROM Rooms
    WHERE (
        SELECT COUNT(*) 
        FROM Students
        WHERE Students.RoomID = Rooms.RoomID
    ) < RoomCapacity AND Rooms.TypeID = @TypeID AND RoomStatus = N'Hoạt động';
END;
GO


CREATE PROCEDURE GetTypeRoom
AS
BEGIN
    SELECT TypeID , TypeName
    FROM dbo.TypesRoom
END;
GO

CREATE PROC GetDepartments
AS
BEGIN
	SELECT *
	FROM dbo.Departments
END;
GO



CREATE PROC GetStudents
AS
BEGIN
    SELECT S.* , D.DepartmentName
			
    FROM dbo.Students S
    INNER JOIN dbo.Departments D ON S.DepartmentID = D.DepartmentID;
END;
GO

CREATE PROC GetClassroom
@DepartmentID NVARCHAR(10)
AS
BEGIN
	SELECT *
	FROM dbo.Classroom
	WHERE DepartmentID = @DepartmentID
END;
GO

CREATE PROC InsertDataStudents
@StudentID NVARCHAR(15),
@StudentName NVARCHAR(20),
@StudentGender NVARCHAR(5),
@StudentDOB DATE,
@StudentAddress NVARCHAR(25),
@StudentPhone NVARCHAR(10),
@StudentPersonalID NVARCHAR(12),
@ClassID NVARCHAR(10),
@DepartmentID NVARCHAR(10),
@RoomID NVARCHAR(10),
@CheckInDate DATE,
@CheckOutDate DATE,
@StudentLived bit,
@StudentRegResident BIT
AS
BEGIN
	INSERT INTO dbo.Students
	(
	    StudentID,
	    StudentName,
	    StudentGender,
	    StudentDOB,
	    StudentAddress,
	    StudentPhone,
	    StudentPersonalID,
	    ClassID,
		DepartmentID,
	    RoomID,
	    CheckInDate,
	    CheckOutDate,
	    StudentLived,
	    StudentRegResident
	)
	VALUES
	(
	@StudentID,
	@StudentName,
	@StudentGender,
	@StudentDOB,
	@StudentAddress,
	@StudentPhone,
	@StudentPersonalID,
	@ClassID,
	@DepartmentID,
	@RoomID,
	@CheckInDate,
	@CheckOutDate,
	@StudentLived,
	@StudentRegResident
	)
END;
GO

CREATE PROC GetClassroom
@DepartmentID NVARCHAR(10)
AS
BEGIN
	SELECT *
	FROM dbo.Classroom
	WHERE DepartmentID = @DepartmentID
END;
GO

CREATE PROC UpdateDataStudents
    @StudentID NVARCHAR(15),
    @StudentName NVARCHAR(20),
    @StudentGender NVARCHAR(5),
    @StudentDOB DATE,
    @StudentAddress NVARCHAR(25),
    @StudentPhone NVARCHAR(10),
    @StudentPersonalID NVARCHAR(12),
    @ClassID NVARCHAR(10),
    @DepartmentID NVARCHAR(10),
    @RoomID NVARCHAR(10),
    @CheckInDate DATE,
    @CheckOutDate DATE,
    @StudentLived BIT,
    @StudentRegResident BIT
AS
BEGIN
    UPDATE dbo.Students
    SET
        StudentName = @StudentName,
        StudentGender = @StudentGender,
        StudentDOB = @StudentDOB,
        StudentAddress = @StudentAddress,
        StudentPhone = @StudentPhone,
        StudentPersonalID = @StudentPersonalID,
        ClassID = @ClassID,
        DepartmentID = @DepartmentID,
        RoomID = @RoomID,
        CheckInDate = @CheckInDate,
        CheckOutDate = @CheckOutDate,
        StudentLived = @StudentLived,
        StudentRegResident = @StudentRegResident
    WHERE
        StudentID = @StudentID;
END;
GO

CREATE PROC GetRoom
AS
BEGIN
	SELECT Rooms.RoomID , RoomCapacity , TypeID , AreaID , RoomNumber , RoomStatus , COUNT(Students.StudentID) AS StudentCount
	FROM Rooms LEFT JOIN Students ON Rooms.RoomID = Students.RoomID
	GROUP BY Rooms.RoomID , RoomCapacity , TypeID , AreaID , RoomNumber , RoomStatus;
END;
GO