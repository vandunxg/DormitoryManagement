﻿--Bảng Tài khoản nhân viên
CREATE TABLE Account(
  Account_ID NVARCHAR(10) PRIMARY KEY NOT NULL,
  Account_Email NVARCHAR(20) NOT NULL,
  Account_Password NVARCHAR(20) NOT NULL
);

-- Bảng Phòng
CREATE TABLE Rooms (
    RoomID NVARCHAR(10) PRIMARY KEY NOT NULL,
    RoomNumber NVARCHAR(10) NOT NULL,
    RoomType NVARCHAR(20) NOT NULL,
	RoomArea NVARCHAR(5) NOT NULL,
    RoomCapacity INT NOT NULL,
    RoomStatus NVARCHAR(20) NOT NULL
);

-- Bảng Sinh viên
CREATE TABLE Students (
    StudentID NVARCHAR(15) PRIMARY KEY NOT NULL,
    StudentName NVARCHAR(20) NOT NULL,
    StudentGender NVARCHAR(5) NOT NULL,
    StudentDOB DATE NOT NULL,
    StudentAddress NVARCHAR(25) NOT NULL,
    StudentPhone NVARCHAR(10) NOT NULL,
	StudentPersonalID NVARCHAR(12) NOT NULL,
	StudentClassroom NVARCHAR(10) NOT NULL,
	RoomID NVARCHAR(10) NOT NULL,
	CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    StudentLived bit,
	StudentRegResident bit,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
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
