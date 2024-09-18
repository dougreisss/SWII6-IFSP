create table dbo.Author 
(
	AuthorId int identity (1, 1),
	[Name] varchar(255),
	Email varchar(255),
	Gender char(1),
	constraint pk_author primary key (AuthorId)
);