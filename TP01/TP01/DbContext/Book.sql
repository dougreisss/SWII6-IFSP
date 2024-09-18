create table dbo.Book 
(
	BookId int identity(1, 1),
	[Name] varchar(180),
	Priace decimal (16, 2),
	Qty int,
	constraint pk_book primary key (BookId)
);