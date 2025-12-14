-- MySQL şema ve tablolar
CREATE DATABASE IF NOT EXISTS guessgame CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE guessgame;

CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(128) NOT NULL,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    telefon VARCHAR(30),
    email VARCHAR(100),
    kayit_tarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    unvan VARCHAR(100),
    notlar TEXT
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS scores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    score INT NOT NULL,
    sure DOUBLE NOT NULL, -- saniye
    oyun_tarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_scores_users FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
) ENGINE=InnoDB;

-- örnek admin kullanıcısı (parola: admin123, SHA256)
INSERT INTO users (username, password_hash, ad, soyad, telefon, email, unvan, notlar)
VALUES ('admin', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'Admin', 'User', '', 'admin@example.com', 'Yönetici', 'Varsayılan kullanıcı')
ON DUPLICATE KEY UPDATE password_hash = VALUES(password_hash);

