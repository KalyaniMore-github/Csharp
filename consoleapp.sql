CREATE TABLE Authors
(
AuthorId INT PRIMARY KEY,
AuthorName VARCHAR (50) NOT NULL,
AuthorGender VARCHAR (50) NOT NULL,
AuthorNationality VARCHAR (50) NOT NULL
)
INSERT INTO Authors
VALUES (1, 'Author-XYZ', 'Male', 'UK'),
(2, 'Author-WXY','Female', 'USA'),
(5, 'Author-VWX','Female', 'FRANCE'),
(20, 'Author-UVW','Female', 'USA'),
(25, 'Author-TUV','Male', 'UK')

CREATE TABLE Books
(
BookId INT PRIMARY KEY IDENTITY(1,1),
BookName VARCHAR (50) NOT NULL,
BookPrice INT,
AuthorIdF INT,
)
INSERT INTO Books 
VALUES ( 'Book-ABC', 100, 20),
( 'Book-BCD', 200,  20),
( 'Book-CDE', 150,  1),
( 'Book-EFG', 100,1),
( 'Book-FGH', 200, 8),
( 'Book-GHI', 150, 9),
( 'Book-HIJ', 100, 1),
( 'Book-JKL', 200, 10),
('Book-KLM', 150, 8)

SELECT  Books.BookName, Books.BookPrice, Authors.AuthorName, Authors.AuthorId
FROM Books
INNER JOIN Authors
ON Books.AuthorIdF = Authors.AuthorId