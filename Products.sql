use Assessment8

drop table Products

CREATE TABLE Products (
    PId INT PRIMARY KEY,
    Pld AS 'P' + RIGHT('00000' + CAST(PId AS VARCHAR(5)), 5) PERSISTED,
    PName NVARCHAR(MAX) NOT NULL,
    PPrice INT,
    ExpDate DATE NOT NULL,
    MnfDate DATE NOT NULL
)
INSERT INTO Products (PId, PName, PPrice, ExpDate, MnfDate)
VALUES
(101, 'iPhone15', 96000, '2023-12-31', '2022-01-01'),
(102, 'Galaxy s32', 78000, '2024-12-31', '2022-02-01'),
(103, 'Redmi10 Pro', 56000, '2025-12-31', '2022-03-01'),
(104, 'OnePlus c3', 46000, '2026-12-31', '2022-04-01'),
(105, 'MacBook', 100000, '2027-12-31', '2022-05-01'),
(106, 'Dell core', 67000, '2028-12-31', '2022-06-01'),
(107, 'Vivo note10',55000, '2029-12-31', '2022-07-01'),
(108, 'Oppo Reno', 38000, '2030-12-31', '2022-08-01'),
(109, 'Realme8 pro',27000, '2031-12-31', '2022-09-01'),
(110, 'Infinix x5', 23000, '2032-12-31', '2022-10-01')

select * from Products