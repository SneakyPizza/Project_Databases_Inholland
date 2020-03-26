USE [ProjectDatabase]

ALTER TABLE [Event] NOCHECK CONSTRAINT ALL;
ALTER TABLE [EventJunction] NOCHECK CONSTRAINT ALL;
-- Events
INSERT INTO [Event] (Date, Description, SupervisorID, EventJunctionID, ActivityID) 
VALUES (23/03/2020, N'Spellendag 1', 2, 1, 1);

INSERT INTO [Event] (Date, Description, SupervisorID, EventJunctionID, ActivityID) 
VALUES (24/03/2020, N'Spellendag 2', 4, 2, 2);



-- Event Junction
-- First event
INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (1, 1);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (3, 1);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (6, 1);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (8, 1);

--Second event
INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (10, 2);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (8, 2);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (12, 2);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (14, 2);

INSERT INTO [EventJunction] (PersonID, EventID) 
VALUES (16, 2);

	ALTER TABLE [Event] CHECK CONSTRAINT ALL;
	ALTER TABLE [EventJunction] CHECK CONSTRAINT ALL;