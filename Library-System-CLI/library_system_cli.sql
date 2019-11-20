--Drop tables 
DROP TABLE IF EXISTS PatronBook;
DROP TABLE IF EXISTS Book;
DROP TABLE IF EXISTS Patron;


-- Create new tables
CREATE TABLE Book (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    Title VARCHAR(50) NOT NULL,
    Author VARCHAR(50) NOT NULL
);

CREATE TABLE Patron (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
);

CREATE TABLE PatronBook (
	Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	BookId INT NOT NULL,
	PatronId INT NOT NULL,
	DueDate DATETIME,
	Returned BIT DEFAULT 0,
	CONSTRAINT FK_PatronBook FOREIGN KEY(BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookPatron FOREIGN KEY(PatronId) REFERENCES Patron(Id)
);

-- Seed data
INSERT INTO Book (Title, Author) VALUES ('The Joy Luck Club', 'Amy Tan');
INSERT INTO Book (Title, Author) VALUES ('Mrs. Dalloway', 'Virginia Woolf');
INSERT INTO Book (Title, Author) VALUES ('Beloved', 'Toni Morrison');
INSERT INTO Book (Title, Author) VALUES ('One Hundred Years of Solitude', 'Gabriel Garcia Marquez');

INSERT INTO Patron (FirstName, LastName) VALUES ('Mark', 'Siler');
INSERT INTO Patron (FirstName, LastName) VALUES ('Russel', 'Jones');
INSERT INTO Patron (FirstName, LastName) VALUES ('Lynne', 'Harty');
INSERT INTO Patron (FirstName, LastName) VALUES ('Blair', 'VanHook');



INSERT INTO PatronBook (BookId, PatronId, DueDate) VALUES (1, 1, '20191118 10:34:09 AM');
INSERT INTO PatronBook (BookId, PatronId, DueDate) VALUES (2, 1, '20191220 10:34:09 AM');
INSERT INTO PatronBook (BookId, PatronId, DueDate, Returned) VALUES (3, 2, '20190604 10:34:09 AM', 1);


-- Check to make sure it worked!
SELECT * FROM Book;
SELECT * FROM Patron;
SELECT * FROM PatronBook;



