CREATE DATABASE Meetings;
USE Meetings;

CREATE TABLE [User] (
    id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

-- Tạo bảng Appointment
CREATE TABLE Appointment (
    id INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(100) NOT NULL,
    location NVARCHAR(100),
    startTime DATETIME NOT NULL,
    endTime DATETIME NOT NULL,
    ownerId INT NOT NULL,
    FOREIGN KEY (ownerId) REFERENCES [User](id)
);

-- Tạo bảng GroupMeeting (kế thừa từ Appointment)
CREATE TABLE GroupMeeting (
    appointmentId INT PRIMARY KEY,
    FOREIGN KEY (appointmentId) REFERENCES Appointment(id)
);

-- Tạo bảng GroupMeetingParticipant (nên tách riêng như trong sơ đồ lớp)
CREATE TABLE GroupMeetingParticipant (
    groupMeetingId INT NOT NULL,
    userId INT NOT NULL,
    PRIMARY KEY (groupMeetingId, userId),
    FOREIGN KEY (groupMeetingId) REFERENCES GroupMeeting(appointmentId),
    FOREIGN KEY (userId) REFERENCES [User](id)
);

-- Tạo bảng Reminder
CREATE TABLE Reminder (
    id INT PRIMARY KEY IDENTITY(1,1),
    timeBefore INT NOT NULL, -- số phút trước khi nhắc
    appointmentId INT NOT NULL,
    FOREIGN KEY (appointmentId) REFERENCES Appointment(id)
);