CREATE TABLE [dbo].[dataStudents] (
    [studentID]      NVARCHAR (10) NOT NULL,
    [fullname]       NVARCHAR (20) NOT NULL,
    [phoneNumber]    NVARCHAR (10) NOT NULL,
    [birthday]       DATE          NOT NULL,
    [address]        NVARCHAR (20) NOT NULL,
    [sex]            NVARCHAR (4)  NOT NULL,
    [personalID]     NVARCHAR (12) NOT NULL,
    [classroom]      NVARCHAR (10) NOT NULL,
    [startContract]  DATE          NOT NULL,
    [dateofContract] REAL          NOT NULL,
    [lived]          BIT           NULL,
    [regStay]   BIT           NULL
);

