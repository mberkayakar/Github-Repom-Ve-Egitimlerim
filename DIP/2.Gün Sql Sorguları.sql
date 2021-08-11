/*   Veri tabanı dosyası oluşturuldu   */
create database DIP_BERKAY_AKAR_STAJ


/* Veri tabanının kullanılabilmesi için Use ile seçilmesi gerekti*/
USE DIP_BERKAY_AKAR_STAJ


/*   1.)  DIP_Employees tablosunu oluşturan script’i yazınız.  */


create table DIP_Employees(
TCKN  decimal(11) primary key,  
Ad nvarchar(50) not null,
Soyad nvarchar(50) not null,
Dogum_Tarihi date not null ,
telefon_numarası_1 decimal (10)
)




/*			2.) Tabloda 3 isimli kişiler için OrtaAd alanını ekleyiniz.				*/

ALTER TABLE DIP_Employees  ADD OrtaAd nvarchar(30)

/*			3.) Tabloda 3 isimli kişiler için OrtaAd alanını ekleyiniz.				*/

Alter Table DIP_Employees Alter Column telefon_numarası_1 Varchar(20) -- Decimal tanımlanan veri türü hem varchr olarak tip değiştirmiş hemde  10 haneden 20 haneye çıkartılmıştır

/*			4.) TCKN boş olamayacağı için bu alanı NULL olmayacak şekle çeviriniz.	*/

Alter Table DIP_Employees Alter Column TCKN Varchar(20) not null 
insert into DIP_Employees(TCKN,Ad,Soyad,Dogum_Tarihi,telefon_numarası_1) values (123,'Berkay','AKAR','1999-05-25','05415975442')
-- Sorgu cümleciginde tablo oluşturulurken primary key yapılmış olsa bile bu denemede tablo normal oluşturulup içerisine Alter ile ekleme yapılmış ve SQL server üzerinde denenmiştir

/*			5.) TCKN aynı olamayacağı için tabloyu tekrar oluşturup TCKN alanını UNIQUE INDEX olarak belirleyiniz.	*/


ALTER TABLE DIP_Employees ADD UNIQUE (TCKN);
insert into DIP_Employees(TCKN,Ad,Soyad,Dogum_Tarihi,telefon_numarası_1) values (123,'Berkay','AKAR','1999-05-25','05415975442')
insert into DIP_Employees(TCKN,Ad,Soyad,Dogum_Tarihi,telefon_numarası_1) values (123,'Ahmet','Yılmaz','1999-05-25','05415975442')


/* Aynı anda Aynı TC numarasın sahip birden fazla kayıt atıldı fakat unique olduğu için sorgu cümleciği bir hata verdi */