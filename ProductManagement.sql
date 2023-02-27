Create database ProductManagement
use ProductManagement

create table StatusInfo
(
	StatusId varchar(10) primary key,
	StatusName varchar(20),
	Description varchar(100),
	CreateDate datetime,
	UpdateDate datetime
)
--drop table StatusInfo
create table UnitInfo
(
	UnitId varchar(10) primary key,
	UnitName varchar(20),
	Description varchar(100),
	Status varchar(10),
	CreateDate datetime,
	UpdateDate datetime,
	CONSTRAINT FK_UnitInfo_StatusInfo_StatusId FOREIGN KEY (Status)  REFERENCES StatusInfo(StatusId)
)
--drop table UnitInfo
create table SupplierInfo
(
	SupplierId varchar(10) primary key,
	SupplierName varchar(50),
	Address varchar(100),
	Phone varchar(15),
)
--drop table SupplierInfo
create table ProductInfo
(
	ProductId varchar(10) primary key,
	ProductName varchar(50),
	CurrentPrice decimal(12,2),
	Status BIT,
	SetupDate datetime,
	UpdateDate datetime,
)
--drop table ProductInfo
create table StockDetails               --   fdsytiuop[
(
	StockId varchar(10) primary key,
	SupplierId varchar(10),
	ProductId varchar(10),
	TransactionId varchar(10),
	Price decimal(12,2),
	Quantity decimal(5,2),
	Unit varchar(10),
	TotalAmount decimal(12,2),
	Status BIT,
	CreateDate datetime,
	UpdateDate datetime,
	CONSTRAINT FK_StockDetails_SupplierInfo_SupplierId FOREIGN KEY (SupplierId)  REFERENCES SupplierInfo(SupplierId),
	CONSTRAINT FK_StockDetails_ProductInfo_ProductId FOREIGN KEY (ProductId)  REFERENCES ProductInfo(ProductId),
	CONSTRAINT FK_StockDetails_StockMaster_TransactionId FOREIGN KEY (TransactionId)  REFERENCES StockMaster(TransactionId)
)
--drop table StockDetails
create table StockMaster
(
	TransactionId varchar(10) primary key,
	SupplierId varchar(10),
	TotalAmount varchar(10),
	Status BIT,
	SetupDate datetime,
	UpdateDate datetime,
	CreatedBy varchar(30)
	CONSTRAINT FK_StockMaster_SupplierInfo_SupplierId FOREIGN KEY (SupplierId)  REFERENCES SupplierInfo(SupplierId)
)
--drop table StockMaster




--create TYPE UnitInfoType as Table
--(
--	UnitId varchar(10),
--	UnitName varchar(20),
--	Description varchar(100),
--	Status varchar(10),
--	CreatedDate datetime,
--	UpdateDate datetime
	
--)



