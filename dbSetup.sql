CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS chores(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(30) NOT NULL,
        description VARCHAR(255) NOT NULL,
        location VARCHAR(30) NOT NULL,
        time INT NOT NULL,
        complete BOOLEAN NOT NULL DEFAULT false,
        priority ENUM('low', 'medium', 'high') NOT NULL DEFAULT 'low',
        creatorId VARCHAR(255) NOT NULL,
        FOREIGN KEY (creatorId) REFERENCES accounts (id)
    ) default charset utf8 COMMENT "";

INSERT INTO
    chores (
        name,
        description,
        location,
        time,
        complete,
        priority,
        creatorId
    )
VALUES (
        'Water plants',
        'Bring down thirsty plants, stick in sink, water',
        'Kitch',
        30,
        false,
        'High',
        '639ce53441bd9289639a023d'
    );

SELECT LAST_INSERT_ID();

DELETE from chores WHERE id = 6;