

Create DataBase ElectricityBillDB;


Create Table ElectricityBill (
    consumer_number Varchar(20),
    consumer_name Varchar(50),
    units_consumed Int,
    bill_amount Float
);

select * from ElectricityBill;
