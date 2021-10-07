-- * tüm kolonları ifade eder
--select * from Customers --customers daki tüm kolonlar gelir
--select  ContactName,CompanyName, City from Customers -- customersdaki 3 kolon gelir
--select  ContactName Adi,CompanyName SirketAdi, City Sehir from Customers -- customersdaki kolonlari istediğimiz isimle getirir 
--select * from Customers where City='London' -- where ile koşul koyduk, şehri london olanları çektik , metinler tek tırnak unutma
--sElEcT * fRoM ProDuctS where CategoryID=1 or (CategoryID=4 and SupplierID=5)-- case insensitive yani büyük küçük harf farketmez
--select * from Products where UnitPrice>20 
--select * from Products order by ProductName --*********order by sırala demek(artan sıraya göre)
--select * from Products order by UnitPrice desc -- desc çoktan aza sıralar (default u asc)
--select * from Products order by CategoryID,ProductName --önce categoryID ye göre sonra ürün adına göre sıralar
--select * from Products where UnitPrice>25 and UnitPrice<60 order by ProductName 
--select count(*) Adet from Products -- ürünlerin satırlarının sayısı count(*) ile bulunur , adet yazarak gelen satıra isim verdik
--select count(*) from Products where CategoryID=2 -- categoryID si 2 olan ürün satır sayısı
--select  CategoryID,count(*) Adet from Products where UnitPrice>20 group by CategoryID  -- select X from Products group by X şeklinde olmalı , ilk X yerine * denmez
--select  CategoryID,ProductName,count(*) Adet from Products  group by CategoryID, ProductName order by ProductName
--select  CategoryID,count(*) Adet from Products  group by CategoryID having count(*)<10
--select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryNamefrom products inner join Categories on Products.CategoryID=Categories.CategoryID
--select * from Products p left join [Order Details] od on p.ProductID=od.ProductID
--select * from customers c left join orders o on c.CustomerID=o.CustomerID where o.OrderID is null

--insert into Customers(CustomerID,ContactName,CompanyName,City) values('asdf','emre','akinci a.ş','sakarya')
--update Customers set city='bERLİN' where CustomerID='ALFKİ'

--select ContactName AD,city SEHIR,Address ADRES,Phone TEL from Customers where City='México D.F.' order by AD 
--customersdan México D.F. da yaşayanları adlarına göre sıralama

--delete from Customers  where CustomerID='ANATR'
--delete from Orders  where CustomerID='ANATR'
--delete from [Order Details]  where OrderID='ANATR'
--select *  from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.OrderID is null
--select CustomerID,ContactName AD,city SEHIR,Address ADRES,Phone TEL from Customers where City='México D.F.' order by AD 
--select AVG(UnitPrice) ortalamaFiyat,AVG(UnitsOnOrder) ortSatis from Products 
--SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK');

--SELECT * INTO CustomersBackup2017 FROM Customers
--SELECT * INTO CustomersGermany FROM Customers WHERE Country = 'Germany';


select p.ProductName UrunAdi, SUM(od.Quantity*od.UnitPrice) Kazanc from Products p 
inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on  od.OrderID=o.OrderID
group by p.ProductName
order by Kazanc 



