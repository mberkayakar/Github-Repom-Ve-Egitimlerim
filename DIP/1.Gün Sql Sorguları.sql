/*   Veri tabanı dosyası oluşturuldu   */
create database DIP_BERKAY_AKAR_STAJ


/* Veri tabanının kullanılabilmesi için Use ile seçilmesi gerekti*/
USE DIP_BERKAY_AKAR_STAJ


/*   Soruların gerçekleştirilebilmesi için bir tablo oluşturuluyor   */

create table elemanlar(
TCKN  decimal(11) primary key,
ad nvarchar(50) not null,
soyad nvarchar(50) not null,
dogum_tarihi date not null ,
telefon_numarası_1 decimal (10)check (telefon_numarası_1 <5999999999 and telefon_numarası_1> 5000000000),
telefon_numarası_2 decimal (10) check (telefon_numarası_2 <5999999999 and telefon_numarası_2> 5000000000)
)




/* Tablo oluşturulduktan sonra içerisine birkaç veri ataması yapmam gerekecektir*/

insert into elemanlar values (2576575,'Berkay','Akar','1999-05-25',5415975442,5526931436)
insert into elemanlar values (257654525,'Anıl Burak','Akar','1999-04-10',5419874125,5546980604)
insert into elemanlar values (2576575123,'Ahmet','Yılmaz','1984-04-10',5419874125,5546980604)
insert into elemanlar values (4566575,'Ayşe Yıldırım','Yılmaz','1984-04-10',5419874125,5546980604)
insert into elemanlar values (257657554,'Mehmet','Yılmaz','1984-04-10',5419874125,5546980604)



										/*1. Soru */

							/*	Elemanların listesini getir	*/

select * from elemanlar
-- Bu sorgu tüm elemanları listeleyecektir.



										/*	2. Soru */
							/*	En Küçük Elemanın Doğum tarihi	*/

-- SELECT elemanlar.dogum_tarihi, Min(DATEDIFF(year,elemanlar.dogum_tarihi,GETDATE())) as 'Yaşı' from elemanlar
/*İlk aşamada Datedif ile tüm içeriğin yaşı hesaplandı bu aşamadan sonra en küçüklerini getirmesi kaldı */

select max(dogum_tarihi) as ' Dogum tarihi'  from elemanlar 
										/*  3.Soru	*/
								/*	En Büyük Elemanın Yaşı */

SELECT  Max(DATEDIFF(year,elemanlar.dogum_tarihi,GETDATE())) AS 'Yaş' from elemanlar


										/*  4.Soru	*/
							/*	Çıkan Elemanların Bilgisini Siliniz */

-- Bir kişinin verisini silmke gerekirse Delete  anahtar kelimesi kullanılır 
delete from elemanlar where TCKN=2576575

select * from elemanlar


										/*	5.Soru	*/
							/*		Yeni Gelen Birisinin Giriniz	*/
			
insert into elemanlar values (34358988840,'Muhammer','Albayrak','1986-04-22',5415975442,5526931436)


										/*	6.Soru	*/
				/*	Bilgilerinde hata olan bir elemanın bilgilerini güncelleme */

UPDATE elemanlar SET soyad='Aslan',telefon_numarası_1=5415975444 WHERE TCKN=34358988840


