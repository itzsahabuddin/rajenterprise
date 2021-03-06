GO
create database [RajEnterprise]
GO
USE [RajEnterprise]
GO
/****** Object:  UserDefinedTableType [dbo].[stockTypeForSale]    Script Date: 7/14/2018 11:20:08 PM ******/
CREATE TYPE [dbo].[stockTypeForSale] AS TABLE(
	[sid] [int] NULL,
	[stock] [int] NULL
)
GO
/****** Object:  Table [dbo].[collection]    Script Date: 7/14/2018 11:20:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[collection](
	[coll] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[coll] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[companies]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[companies](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[company_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customers]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[custId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[mobile] [int] NULL,
	[panGst] [varchar](50) NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[custId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[products]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[cid] [int] NULL,
	[coll] [int] NULL,
	[weight] [varchar](50) NULL,
	[details] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[question]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[question](
	[qid] [int] IDENTITY(1,1) NOT NULL,
	[question] [varchar](90) NULL,
PRIMARY KEY CLUSTERED 
(
	[qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[registration]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[registration](
	[regid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](100) NULL,
	[email] [varchar](50) NULL,
	[contactno] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[businessname] [varchar](50) NULL,
	[businessaddress] [varchar](100) NULL,
	[gst] [varchar](50) NULL,
	[panno] [varchar](50) NULL,
	[qid] [int] NULL,
	[role] [int] NULL,
	[answer] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[contactno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sales]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invoiceId] [int] NULL,
	[customerId] [int] NULL,
	[date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stocks]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stocks](
	[sid] [int] IDENTITY(1,1) NOT NULL,
	[pid] [int] NULL,
	[mrp] [varchar](40) NULL,
	[rate] [varchar](40) NULL,
	[stock] [int] NULL,
	[sgst] [varchar](40) NULL,
	[cgst] [varchar](40) NULL,
	[igst] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[_updateStockAfterSale]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_updateStockAfterSale]
@saleTable stockTypeForSale READONLY
as 
begin
SET NOCOUNT ON;
 
      MERGE INTO stocks st
      USING @saleTable stTable
      ON stTable.sid=st.sid
      WHEN MATCHED THEN
      UPDATE SET st.stock = stTable.stock;
end
GO
/****** Object:  StoredProcedure [dbo].[generate_invoice]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generate_invoice](@custid int,@xmlData varchar(max),@id int output)
as
begin
insert into invoice(data) values(@xmlData);
declare @invoiveID int;
set @invoiveID=SCOPE_IDENTITY();
set @id=@invoiveID;
insert into sales(invoiceId,customerId,date) values(@invoiveID,@custid,SYSDATETIME());
end



GO
/****** Object:  StoredProcedure [dbo].[increaseStock]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[increaseStock](@coll int,@cid int,@weigth varchar(50),@details varchar(50),@mrp varchar(50),@rate varchar(50),@stock int,@sgst varchar(50),@cgst varchar(50),@igst varchar(50))
as
begin
declare @pid int;
set @pid=0;
select @pid=pid from products where  cid=@cid and coll=@coll and weight=@weigth;
if(@pid=0)
begin
insert into products values(@cid,@coll,@weigth,@details);
set @pid=SCOPE_IDENTITY();
insert into stocks values(@pid,@mrp,@rate,@stock,@sgst,@cgst,@igst);
end
else
begin
declare @currentStock int; declare @result varchar(50);
select @currentStock= stock from stocks where  pid=@pid;
set @result=CONVERT(int, @stock) + @currentStock;
update stocks set mrp=@mrp,rate=@rate,stock=@result,sgst=@sgst,cgst=@cgst,igst=@igst where pid=@pid;
end
end
GO
/****** Object:  StoredProcedure [dbo].[removeStock]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[removeStock](@sid int)
as
begin
declare @pid int;
select @pid=pid from stocks where sid=@sid;
delete stocks where sid=@sid;
delete products where pid=@pid;
end


GO
/****** Object:  StoredProcedure [dbo].[updateStock]    Script Date: 7/14/2018 11:20:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateStock](@sid int,@coll int,@cid int,@weigth varchar(50),@details varchar(50),@mrp varchar(50),@rate varchar(50),@stock int,@sgst varchar(50),@cgst varchar(50),@igst varchar(50))
as
begin
declare @pid int;
select @pid=pid from stocks where sid=@sid;
update products set coll=@coll,cid=@cid,weight=@weigth,details=@details where pid=@pid;
update stocks set pid=@pid,mrp=@mrp,rate=@rate,stock=@stock,sgst=@sgst,cgst=@cgst,igst=@igst where sid=@sid;
end

GO
insert into question values('In what city were you born?')
GO
insert into question values('What was your favorite place to visit as a child?')
GO
insert into question values('What is the name of your favorite pet?')
GO
insert into question values('What high school did you attend?')
GO
insert into question values('What is the name of your first school?')
GO
insert into question values('What is your mother''s maiden name?')
GO
insert into question values('What was the make of your first car?')
GO