USE Meetings;
-- Thêm người dùng
INSERT INTO [User] (Name) VALUES 
(N'Nguyễn Văn A'),
(N'Trần Thị B'),
(N'Lê Văn C');

-- Thêm cuộc hẹn cá nhân
INSERT INTO Appointment (title, location, startTime, endTime, ownerId) VALUES
(N'Họp dự án', N'Phòng 301', '2024-05-10 09:00:00', '2024-05-10 10:30:00', 1),
(N'Khám bệnh', N'Bệnh viện Đa khoa', '2024-05-10 14:00:00', '2024-05-10 15:00:00', 2);

-- Thêm cuộc họp nhóm
INSERT INTO Appointment (title, location, startTime, endTime, ownerId) VALUES
(N'Họp nhóm phát triển', N'Phòng họp 2', '2024-05-10 11:00:00', '2024-05-10 12:00:00', 1);

INSERT INTO GroupMeeting (appointmentId) VALUES (3);

INSERT INTO GroupMeetingParticipant (groupMeetingId, userId) VALUES
(3, 1), -- Chủ nhóm
(3, 2), -- Thành viên
(3, 3); -- Thành viên

-- Thêm nhắc nhở
INSERT INTO Reminder (timeBefore, appointmentId) VALUES
(15, 1), -- Nhắc trước 15 phút cho cuộc họp dự án
(30, 2), -- Nhắc trước 30 phút cho lịch khám bệnh
(60, 3); -- Nhắc trước 1 giờ cho cuộc họp nhóm

-- Thêm 4 cuộc hẹn cá nhân
INSERT INTO Appointment (title, location, startTime, endTime, ownerId) VALUES
(N'Họp với đối tác', N'Công ty ABC, tầng 5', '2024-05-10 08:30:00', '2024-05-10 09:30:00', 1),
(N'Đi siêu thị', N'VinMart Times City', '2024-05-10 10:00:00', '2024-05-10 11:30:00', 2),
(N'Gặp mentor', N'Quán cà phê Trung Nguyên', '2024-05-10 13:00:00', '2024-05-10 14:30:00', 3),
(N'Đón con từ trường', N'Trường Tiểu học Kim Đồng', '2024-05-10 16:00:00', '2024-05-10 16:30:00', 1);

-- Thêm 2 cuộc họp nhóm
INSERT INTO Appointment (title, location, startTime, endTime, ownerId) VALUES
(N'Họp triển khai dự án X', N'Phòng họp 3, tầng 7', '2024-05-10 15:00:00', '2024-05-10 16:30:00', 2),
(N'Training kỹ năng mới', N'Phòng đào tạo', '2024-05-10 17:00:00', '2024-05-10 18:30:00', 3);

-- Thêm vào bảng GroupMeeting
INSERT INTO GroupMeeting (appointmentId) VALUES 
(5), -- ID của cuộc họp nhóm đầu tiên
(6); -- ID của cuộc họp nhóm thứ hai

-- Thêm người tham gia cuộc họp nhóm 1
INSERT INTO GroupMeetingParticipant (groupMeetingId, userId) VALUES
(5, 1), -- Người dùng 1 tham gia
(5, 2), -- Người dùng 2 tham gia
(5, 3); -- Người dùng 3 tham gia

-- Thêm người tham gia cuộc họp nhóm 2
INSERT INTO GroupMeetingParticipant (groupMeetingId, userId) VALUES
(6, 2), -- Người dùng 2 tham gia
(6, 3); -- Người dùng 3 tham gia

-- Thêm nhắc nhở cho các cuộc hẹn
INSERT INTO Reminder (timeBefore, appointmentId) VALUES
(30, 4), -- Nhắc trước 30 phút đón con
(60, 5), -- Nhắc trước 1 giờ cho họp dự án X
(15, 6); -- Nhắc trước 15 phút cho buổi training

INSERT INTO Appointment (title, location, startTime, endTime, ownerId) VALUES
(N'Họp dự án', N'Phòng 301', '2025-05-06 09:00:00', '2025-05-06 10:30:00', 1),
(N'Khám bệnh', N'Bệnh viện Đa khoa', '2025-05-07 14:00:00', '2025-05-07 15:00:00', 2);
