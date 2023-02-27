Create database ProductManagement2
use ProductManagement2

create table StatusInfo
(
	StatusId varchar(10) primary key,
	StatusName varchar(50),
	Description varchar(300),
	CreateDate datetime,
	UpdateDate datetime
)
--drop table StatusInfo ---- TRUNCATE TABLE StatusInfo;
create table ProductInfo
(
	ProductId varchar(10) primary key,
	ProductName varchar(50),
	CurrentPrice decimal(12,2),
	--Status BIT,
	Status varchar(10),
	SetupDate datetime,
	UpdateDate datetime,
	CONSTRAINT FK_ProductInfo_StatusInfo_StatusId FOREIGN KEY (Status)  REFERENCES StatusInfo(StatusId)
)
--drop table ProductInfo 
---- TRUNCATE TABLE ProductInfo;
create table UnitInfo
(
	UnitId varchar(10) primary key,
	UnitName varchar(50),
	Description varchar(300),
	Status varchar(10),
	CreateDate datetime,
	UpdateDate datetime,
	CONSTRAINT FK_UnitInfo_StatusInfo_StatusId FOREIGN KEY (Status)  REFERENCES StatusInfo(StatusId)
)
--drop table UnitInfo 
---- TRUNCATE TABLE UnitInfo;
create table SupplierInfo
(
	SupplierId varchar(10) primary key,
	SupplierName varchar(50),
	Address varchar(300),
	Phone varchar(15),
)
--drop table SupplierInfo ---- TRUNCATE TABLE SupplierInfo;

create table StockDetails
(
	StockId varchar(10) primary key,
	SupplierId varchar(10),
	ProductId varchar(10),
	Price decimal(12,2),
	Quantity decimal(5,2),
	Unit varchar(10),
	TotalAmount decimal(12,2),
	Status varchar(100),
	CreateDate datetime,
	UpdateDate datetime,
	CONSTRAINT FK_StockDetails_SupplierInfo_SupplierId FOREIGN KEY (SupplierId)  REFERENCES SupplierInfo(SupplierId),
	CONSTRAINT FK_StockDetails_ProductInfo_ProductId FOREIGN KEY (ProductId)  REFERENCES ProductInfo(ProductId),
	CONSTRAINT FK_StockDetails_UnitInfo_UnitId FOREIGN KEY (Unit)  REFERENCES UnitInfo(UnitId)
)
--drop table StockDetails 
--------- TRUNCATE TABLE StockDetails;
--create table StockMaster
--(
--	TransactionId varchar(10) primary key,
--	SupplierId varchar(10),
--	TotalAmount decimal(12,2),
--	Status BIT,
--	SetupDate datetime,
--	UpdateDate datetime,
--	CreatedBy varchar(30)
--	CONSTRAINT FK_StockMaster_SupplierInfo_SupplierId FOREIGN KEY (SupplierId)  REFERENCES SupplierInfo(SupplierId)
--)
--drop table StockMaster 
--------- TRUNCATE TABLE StockMaster




--create TYPE UnitInfoType as Table
--(
--	UnitId varchar(10),
--	UnitName varchar(20),
--	Description varchar(100),
--	Status varchar(10),
--	CreatedDate datetime,
--	UpdateDate datetime
	
--)



