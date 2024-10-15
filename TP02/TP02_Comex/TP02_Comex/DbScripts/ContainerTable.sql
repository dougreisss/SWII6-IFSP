CREATE TABLE Container (
    IdContainer INT IDENTITY(1,1),
    Numero NVARCHAR(50),
    ContainerType NVARCHAR(50),
    ContainerSize INT,
    IdBL INT,
    CONSTRAINT PK_Container PRIMARY KEY (IdContainer),
    CONSTRAINT FK_Container_Bl FOREIGN KEY (IdBL) REFERENCES Bl(IdBL)
);
