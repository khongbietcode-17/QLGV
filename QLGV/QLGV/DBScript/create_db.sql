CREATE DATABASE QLGV ON
(
name = QLGV_d,
filename = 'D:\QLGV_DB\QLGV.mdf',
size = 8,
maxsize = 50,
filegrowth = 5
)
log on
(
name = QLGV_lg,
filename = 'D:\QLGV_DB\QLGV.ldf',
size = 8,
maxsize = 50,
filegrowth = 5
)
