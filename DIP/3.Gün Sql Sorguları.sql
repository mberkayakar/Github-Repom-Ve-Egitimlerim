/*   Veri tabanı dosyası oluşturuldu   */
create database DIP_BERKAY_AKAR_STAJ


/* Veri tabanının kullanılabilmesi için Use ile seçilmesi gerekti*/
USE DIP_BERKAY_AKAR_STAJ


/*	DIP_Employees tablosunu oluşturan script	*/





create table DIP_Employees(
TCKN  decimal(11) primary key,  
Ad nvarchar(50) not null,
Soyad nvarchar(50) not null,
Dogum_Tarihi date not null ,
telefon_numarası_1 decimal (10),
telefon_numarası_2 decimal (10),
)




/*			2.)  Tablo içerisine Personel Ekleme         */

insert into DIP_Employees values (1,'Berkay','Akar','1999-05-25',5415975442,5526931436)
insert into DIP_Employees values (2,'Anıl','Akar','1984-07-25',5415975442,5526931436)
insert into DIP_Employees values (3,'Burak','Karaca','1980-12-05',5415975442,5526931436)


/* Soru 1 : En küçük elemanın bilgileri */



/* Soru 2 : En küçük ve en büyük elemanın bilgileri aynı anda getir  */

-- Bu işlem için union kullanılması gerekmektedir


SELECT * from DIP_Employees  where Dogum_Tarihi=(SELECT MIN(Dogum_Tarihi) from DIP_Employees) 
union
SELECT * from DIP_Employees  where Dogum_Tarihi=(SELECT MAX(Dogum_Tarihi) from DIP_Employees) 


