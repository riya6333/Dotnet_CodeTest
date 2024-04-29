create database MoviesDB
use MoviesDB 

CREATE TABLE Movie (
    Mid INT PRIMARY KEY,
    MovieName VARCHAR(255),
    DateOfRelease DATE
);

INSERT INTO Movie VALUES (1, 'AA', '2020-03-11'),
(2, 'BB', '2021-08-21'),
(3, 'CC', '2022-04-13'),
(4, 'DD', '2023-06-11'),
(5, 'EE', '2024-03-16');