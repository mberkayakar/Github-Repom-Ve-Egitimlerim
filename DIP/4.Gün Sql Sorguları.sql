use DIP_BERKAY_AKAR_STAJ


/*	DIP_Employees tablosunu oluşturan script	*/

create table DIP_Employees(
TCKN  decimal(11) primary key,  
Ad nvarchar(50) not null,
Soyad nvarchar(50) not null,
Dogum_Tarihi date not null ,
telefon_numarası_1 decimal (10),
telefon_numarası_2 decimal (10),
)

/*			1.)  Maaş Tablosu Oluşturma         */


create table CalısanMaas(
ID int identity(1,1) primary key,  -- Normalizasyon kuralları geregi oluturulmuştur
TCKN decimal(11),
Tarih date not null ,
Maas decimal(10,2) not null,
CONSTRAINT FK_maasbirlestirmesi FOREIGN KEY (TCKN) REFERENCES DIP_Employees(TCKN),  
)

 




/* Soru 2 : Eleman isimlerini Ocak maaşına göre azalan sıralayınız.  */

select CalısanMaas.TCKN, Ad,Soyad,Dogum_Tarihi,Tarih,Maas from DIP_Employees inner join CalısanMaas on CalısanMaas.TCKN = DIP_Employees.TCKN where CalısanMaas.Tarih between '2021-01-01' AND '2021-01-31' 
order by Maas Desc

