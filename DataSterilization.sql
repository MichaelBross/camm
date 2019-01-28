-- Data Sterilization Process

-- Clear WorkOrders
DELETE FROM dbo.WorkOrders

-- Select work orders from companies that are no longer in business from WorkOrdersAll and insert it into WorkOrders 
INSERT INTO WorkOrders
SELECT * FROM WorkOrdersAll
WHERE Customer Like 'Amer%' OR Customer Like 'Make%' OR Customer Like 'Sportscam%' OR Customer Like 'Outerbridge%' OR Customer Like 'Liberty%'
GO

-- Clear BOMs
DELETE FROM dbo.BOMs
GO

-- Select BOMS from DBA_BOM_Copy where ParentNumber equals WorkOrder.AssemblyNumber and WorkOrder.AssemblyNumber equals Amertron part numbers then insert the BOMs in to table BOMs
INSERT INTO dbo.BOMs
SELECT LineNumber, ParentNumber, ChildNumber, Reference, QtyRequired, LastUpdate from dbo.DBA_BOM_Copy
WHERE ParentNumber like '104___ %'
or ParentNumber like '104___-%'
or ParentNumber like '105___ %'
or ParentNumber like '105___-%'
UNION
SELECT DISTINCT LineNumber, ParentNumber, ChildNumber, Reference, QtyRequired, LastUpdate from dbo.DBA_BOM_Copy
JOIN WorkOrders ON ParentNumber = AssemblyNumber

-- Clear Items
DELETE FROM Items
GO

-- Select Items from ItemsCopy where ItemNumber equals BOMs.ParentNumber or ItemNumber equals BOMs.ChildNumber and insert into Items
INSERT INTO Items
SELECT DISTINCT ItemNumber, Class, Type, ItemDescription, OnWorkOrder, OnAllocation, InWorkInProgress, Available, UnitsOfMeasure, 
				Specs01, Specs02, Specs03, Specs04, Specs05, Specs06, Specs07, Specs08, Specs09, Specs10, Specs11, Specs12, ItemsCopy.LastUpdate 
FROM ItemsCopy
JOIN BOMs ON ItemNumber = ParentNumber OR ItemNumber = ChildNumber