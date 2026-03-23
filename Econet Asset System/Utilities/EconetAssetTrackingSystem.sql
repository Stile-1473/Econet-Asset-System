-- ============================================
-- ECONET ASSET TRACKING SYSTEM DATABASE SCRIPT
-- 
-- ============================================

-- Create database
IF DB_ID('EconetAssetTrackingDB') IS NOT NULL
BEGIN
    ALTER DATABASE EconetAssetTrackingDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EconetAssetTrackingDB;
END;
GO

CREATE DATABASE EconetAssetTrackingDB;
GO

USE EconetAssetTrackingDB;
GO

-- ============================================
-- 1. ROLES
-- ============================================
CREATE TABLE Roles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- ============================================
-- 2. LOCATIONS
-- ============================================
CREATE TABLE Locations (
    LocationId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(255) NULL
);
GO

-- ============================================
-- 3. DEPARTMENTS
-- ============================================
CREATE TABLE Departments (
    DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    LocationId INT NOT NULL,
    ParentDepartmentId INT NULL,
    CONSTRAINT FK_Departments_Locations
        FOREIGN KEY (LocationId) REFERENCES Locations(LocationId),
    CONSTRAINT FK_Departments_Parent
        FOREIGN KEY (ParentDepartmentId) REFERENCES Departments(DepartmentId)
);
GO

-- ============================================
-- 4. STATUS TYPES
-- ============================================
CREATE TABLE StatusTypes (
    StatusTypeId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL UNIQUE,
    Description NVARCHAR(255) NULL,
    IsActive BIT NOT NULL DEFAULT 1
);
GO

-- ============================================
-- 5. CATEGORIES
-- ============================================
CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- ============================================
-- 6. USERS
-- ============================================
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    RoleId INT NOT NULL,
    DepartmentId INT NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CHK_Users_Status CHECK (Status IN ('Active', 'Inactive')),
    CONSTRAINT FK_Users_Roles
        FOREIGN KEY (RoleId) REFERENCES Roles(RoleId),
    CONSTRAINT FK_Users_Departments
        FOREIGN KEY (DepartmentId) REFERENCES Departments(DepartmentId)
);
GO

-- ============================================
-- 7. ASSETS
-- ============================================
CREATE TABLE Assets (
    AssetId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Tag NVARCHAR(50) NOT NULL UNIQUE,
    CategoryId INT NOT NULL,
    SerialNumber NVARCHAR(100) NOT NULL,
    PurchaseDate DATE NOT NULL,
    Cost DECIMAL(18,2) NOT NULL DEFAULT 0,
    Supplier NVARCHAR(100) NULL,
    WarrantyExpiry DATE NULL,
    LocationId INT NOT NULL,
    StatusTypeId INT NOT NULL,
    ImagePath NVARCHAR(255) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Assets_Categories
        FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    CONSTRAINT FK_Assets_Locations
        FOREIGN KEY (LocationId) REFERENCES Locations(LocationId),
    CONSTRAINT FK_Assets_StatusTypes
        FOREIGN KEY (StatusTypeId) REFERENCES StatusTypes(StatusTypeId)
);
GO

-- ============================================
-- 8. ASSIGNMENTS
-- ============================================
CREATE TABLE Assignments (
    AssignmentId INT IDENTITY(1,1) PRIMARY KEY,
    AssetId INT NOT NULL,
    AssigneeType NVARCHAR(20) NOT NULL,
    AssigneeId INT NOT NULL,
    AssignDate DATETIME NOT NULL DEFAULT GETDATE(),
    ExpectedReturnDate DATETIME NULL,
    ReturnDate DATETIME NULL,
    ConditionOnReturn NVARCHAR(20) NULL,
    Notes NVARCHAR(255) NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Assigned',
    CONSTRAINT CHK_Assignments_AssigneeType CHECK (AssigneeType IN ('User', 'Location')),
    CONSTRAINT CHK_Assignments_Status CHECK (Status IN ('Assigned', 'Returned', 'Transferred')),
    CONSTRAINT CHK_Assignments_Condition CHECK (ConditionOnReturn IS NULL OR ConditionOnReturn IN ('Good', 'Damaged')),
    CONSTRAINT FK_Assignments_Assets
        FOREIGN KEY (AssetId) REFERENCES Assets(AssetId)
);
GO

-- ============================================
-- 9. MAINTENANCE RECORDS
-- ============================================
CREATE TABLE MaintenanceRecords (
    MaintenanceId INT IDENTITY(1,1) PRIMARY KEY,
    AssetId INT NOT NULL,
    IssueDescription NVARCHAR(255) NOT NULL,
    MaintenanceType NVARCHAR(50) NOT NULL,
    Vendor NVARCHAR(100) NULL,
    Cost DECIMAL(18,2) NOT NULL DEFAULT 0,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NULL,
    Status NVARCHAR(20) NOT NULL,
    Notes NVARCHAR(255) NULL,
    CONSTRAINT CHK_Maintenance_Type CHECK (MaintenanceType IN ('Preventive', 'Corrective', 'Upgrade')),
    CONSTRAINT CHK_Maintenance_Status CHECK (Status IN ('Scheduled', 'In Progress', 'Completed')),
    CONSTRAINT FK_Maintenance_Assets
        FOREIGN KEY (AssetId) REFERENCES Assets(AssetId)
);
GO

-- ============================================
-- 10. NOTIFICATIONS
-- ============================================
CREATE TABLE Notifications (
    NotificationId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    Message NVARCHAR(255) NOT NULL,
    IsRead BIT NOT NULL DEFAULT 0,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Notifications_Users
        FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
GO

-- ============================================
-- 11. AUDIT LOGS
-- ============================================
CREATE TABLE AuditLogs (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    Action NVARCHAR(100) NOT NULL,
    EntityType NVARCHAR(50) NOT NULL,
    EntityId INT NOT NULL,
    [Timestamp] DATETIME NOT NULL DEFAULT GETDATE(),
    Details NVARCHAR(MAX) NULL,
    CONSTRAINT FK_AuditLogs_Users
        FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
GO

-- ============================================
-- INDEXES
-- ============================================
CREATE INDEX IX_Users_RoleId ON Users(RoleId);
CREATE INDEX IX_Users_DepartmentId ON Users(DepartmentId);
CREATE INDEX IX_Assets_CategoryId ON Assets(CategoryId);
CREATE INDEX IX_Assets_LocationId ON Assets(LocationId);
CREATE INDEX IX_Assets_StatusTypeId ON Assets(StatusTypeId);
CREATE INDEX IX_Assignments_AssetId ON Assignments(AssetId);
CREATE INDEX IX_MaintenanceRecords_AssetId ON MaintenanceRecords(AssetId);
CREATE INDEX IX_Notifications_UserId ON Notifications(UserId);
CREATE INDEX IX_AuditLogs_UserId ON AuditLogs(UserId);
CREATE INDEX IX_AuditLogs_Timestamp ON AuditLogs([Timestamp]);
GO

-- ============================================
-- SAMPLE DATA
-- ============================================

-- Roles
INSERT INTO Roles (Name) VALUES
('Admin'),
('Manager'),
('IT Staff');
GO

-- Locations
INSERT INTO Locations (Name, Description) VALUES
('Head Office', 'Main headquarters'),
('Bulawayo Branch', 'Branch office in Bulawayo'),
('Mutare Branch', 'Branch office in Mutare');
GO

-- Departments
INSERT INTO Departments (Name, LocationId, ParentDepartmentId) VALUES
('ICT', 1, NULL),
('Finance', 1, NULL),
('Operations', 2, NULL),
('Support', 3, NULL);
GO

-- Status Types
INSERT INTO StatusTypes (Name, Description, IsActive) VALUES
('Available', 'Asset ready for assignment', 1),
('Assigned', 'Asset currently assigned', 1),
('Maintenance', 'Asset under maintenance', 1),
('Retired', 'Asset no longer in use', 1);
GO

-- Categories
INSERT INTO Categories (Name) VALUES
('Laptop'),
('Desktop'),
('Router'),
('Printer'),
('Monitor'),
('Mobile Device');
GO

-- Users
-- NOTE: For now these are plain test hashes/placeholders. Replace later with real hashed passwords from C#.
INSERT INTO Users (Name, Email, PasswordHash, RoleId, DepartmentId, Status) VALUES
('System Admin', 'admin@econet.local', 'admin123', 1, 1, 'Active'),
('Tinashe Moyo', 'tinashe@econet.local', 'password123', 2, 1, 'Active'),
('Rudo Dube', 'rudo@econet.local', 'password123', 3, 2, 'Active');
GO

-- Assets
INSERT INTO Assets
(Name, Tag, CategoryId, SerialNumber, PurchaseDate, Cost, Supplier, WarrantyExpiry, LocationId, StatusTypeId, ImagePath)
VALUES
('Dell Latitude 5420', 'AST001', 1, 'DL5420-001', '2025-01-10', 1200.00, 'Dell Zimbabwe', '2027-01-10', 1, 1, NULL),
('HP ProDesk 600', 'AST002', 2, 'HP600-002', '2024-09-15', 950.00, 'HP Supplier', '2026-09-15', 1, 1, NULL),
('Cisco Router 2900', 'AST003', 3, 'CSR2900-003', '2024-07-20', 2000.00, 'Cisco Partner', '2027-07-20', 2, 1, NULL),
('Canon Printer X12', 'AST004', 4, 'CNX12-004', '2025-02-01', 500.00, 'Canon Dealer', '2026-02-01', 3, 1, NULL);
GO

-- Assignments
INSERT INTO Assignments
(AssetId, AssigneeType, AssigneeId, AssignDate, ExpectedReturnDate, ReturnDate, ConditionOnReturn, Notes, Status)
VALUES
(1, 'User', 2, GETDATE(), DATEADD(DAY, 30, GETDATE()), NULL, NULL, 'Issued for field work', 'Assigned');
GO

-- Update asset status for assigned asset
UPDATE Assets
SET StatusTypeId = (SELECT StatusTypeId FROM StatusTypes WHERE Name = 'Assigned')
WHERE AssetId = 1;
GO

-- MaintenanceRecords
INSERT INTO MaintenanceRecords
(AssetId, IssueDescription, MaintenanceType, Vendor, Cost, StartDate, EndDate, Status, Notes)
VALUES
(4, 'Paper jam and roller replacement', 'Corrective', 'Canon Service Centre', 75.00, GETDATE(), NULL, 'In Progress', 'Awaiting spare parts');
GO

-- Update asset status for maintenance asset
UPDATE Assets
SET StatusTypeId = (SELECT StatusTypeId FROM StatusTypes WHERE Name = 'Maintenance')
WHERE AssetId = 4;
GO

-- Notifications
INSERT INTO Notifications (UserId, Type, Message, IsRead) VALUES
(1, 'WarrantyExpiry', 'Asset AST002 warranty expires soon.', 0),
(2, 'Assignment', 'You have been assigned asset AST001.', 0);
GO

-- AuditLogs
INSERT INTO AuditLogs (UserId, Action, EntityType, EntityId, Details) VALUES
(1, 'CREATE', 'Asset', 1, 'Created asset Dell Latitude 5420'),
(1, 'ASSIGN', 'Assignment', 1, 'Assigned asset AST001 to user Tinashe Moyo'),
(1, 'MAINTENANCE', 'Maintenance', 1, 'Printer AST004 sent for maintenance');
GO