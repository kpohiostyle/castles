Create Table castles (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    knightCount INT NOT NULL,
    location VARCHAR(255) NOT NULL,
    hasPrincess BOOLEAN NOT NULL,
    hasDragon BOOLEAN NOT NULL,
    PRIMARY KEY(id) NOT NULL

);

Create Table knights (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    dragonsSlain INT,
    weaponType VARCHAR NOT NULL,
    CastleId INT NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(CastleId) REFERENCES castles(id) ON DELETE CASCADE
    
)