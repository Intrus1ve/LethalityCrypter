﻿CREATE TABLE dbo.Privates
(
	Token VARCHAR(MAX) NOT NULL,
    MonthCount INT NOT NULL, 
    BuyDate DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
)