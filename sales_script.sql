--SELECT * FROM sys.databases;
create database sales_record_db;
use sales_record_db;


create table dbo.table_client
				(
							_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
					customer_name varchar(100) NOT NULL,
					cus_address_1 varchar(200) , 
					cus_address_2 varchar(200) , 
					cus_address_3 varchar(200) , 
					cus_suburb varchar(100),
					cus_state varchar(100),
					cus_postal_code int

				);
go
--insert data to user table
INSERT INTO table_client values('cus1','add11','add12','add13','suburb1','state1',111);
INSERT INTO table_client values('cus2','add21','add22','add23','suburb2','state2',112);
INSERT INTO table_client values('cus3','add31','add32','add33','suburb3','state3',113);
GO

--DROP TABLE table_client;





create table dbo.table_sktitem
				(
					_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
					item_code varchar(100) NOT NULL,
					item_des varchar(200) NOT NULL, 
			

				);
go

INSERT INTO table_sktitem values('abc','Hello abc');
INSERT INTO table_sktitem values('xyz','Hello xyz');
INSERT INTO table_sktitem values('lmn','Hello lmn');
INSERT INTO table_sktitem values('kqy','Hello kqy');
INSERT INTO table_sktitem values('nom','Hello nom');

create table dbo.table_sales_info
				(
					_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
					item_code varchar(100) NOT NULL,
					item_des varchar(200) NOT NULL, 
					item_note varchar(200), 
					item_qty float NOT NULL, 
					item_price float,
					item_tax float,
					item_excl_amount float,
					item_tax_amount float,
					item_incl_amount float

				);
go

--insert data to salesinfo table
INSERT INTO table_sales_info values('abc','desc1','note1',2.0,300.0,0.25,0.2,0.2,2.2);
INSERT INTO table_client values('cus2','add21','add22','add23','suburb2','state2',112);
INSERT INTO table_client values('cus3','add31','add32','add33','suburb3','state3',113);
GO