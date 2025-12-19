-- MSSQL şema ve tablolar
IF DB_ID('guessgame') IS NULL
BEGIN
    CREATE DATABASE guessgame;
END
GO

USE guessgame;
GO

IF OBJECT_ID('dbo.users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.users (
        id INT IDENTITY(1,1) PRIMARY KEY,
        username NVARCHAR(50) NOT NULL UNIQUE,
        password_hash NVARCHAR(128) NOT NULL,
        ad NVARCHAR(50) NOT NULL,
        soyad NVARCHAR(50) NOT NULL,
        telefon NVARCHAR(30) NULL,
        email NVARCHAR(100) NULL,
        kayit_tarihi DATETIME2 NOT NULL CONSTRAINT DF_users_kayit_tarihi DEFAULT SYSUTCDATETIME(),
        unvan NVARCHAR(100) NULL,
        notlar NVARCHAR(MAX) NULL
    );
END
GO

IF OBJECT_ID('dbo.scores', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.scores (
        id INT IDENTITY(1,1) PRIMARY KEY,
        user_id INT NOT NULL,
        score INT NOT NULL,
        sure FLOAT NOT NULL, -- saniye
        oyun_tarihi DATETIME2 NOT NULL CONSTRAINT DF_scores_oyun_tarihi DEFAULT SYSUTCDATETIME(),
        CONSTRAINT FK_scores_users FOREIGN KEY (user_id) REFERENCES dbo.users(id) ON DELETE CASCADE
    );
END
GO

-- örnek admin kullanıcısı (parola: admin123, SHA256)
MERGE dbo.users AS target
USING (VALUES ('admin')) AS src(username)
ON target.username = src.username
WHEN NOT MATCHED THEN
    INSERT (username, password_hash, ad, soyad, telefon, email, kayit_tarihi, unvan, notlar)
    VALUES ('admin', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9',
            'Admin', 'User', '', 'admin@example.com', SYSUTCDATETIME(), 'Yönetici', 'Varsayılan kullanıcı')
WHEN MATCHED THEN
    UPDATE SET password_hash = '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9';
GO

