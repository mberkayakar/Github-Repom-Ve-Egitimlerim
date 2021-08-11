------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------

/*						     	    	--   6. Gün --		           						  */

------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------




-- SQl server için açıklama satırı iki adet eksi ile verilebilmektedir. --

------------------------------------------------------------------------------------------------

/*

Çoklu açıklama satırı için bu 
şekilde yapabiliriz tıpkı C# ta 
olduğu gibi verilebilmektedir.

*/


------------------------------------------------------------------------------------------------
/*

RDBMS (Relational Database Management System) : İlişkisel veri tabanı yönetim sistemi demektir. Kademeli yetkilendirme
gibi mekanikleri içermektedir. Postresql, Mysql, Oracle, Sql Server, örnek olarak verilebilir. ANSI SQL standartını kabul eder. 
Bu standartı kabul eden tüm sql tiplerinde kullanılır. Normalizasyon bir modelleme standartıdır.

Normailzasyon: Bir tasarım ve modelleme tekniğidir. Amaç Veri kaçaklarını engellemektdir. Objeleri tutan yapılara tablo denir.
(sepet müşteri öğrenci objesi). tablo isimlerinde genellikle çoğul isim kullanılır. satırlar objeyi sütunlar ise özellikleri 
anlatır. Primary key : bir tabloda benzersiz olan anahtara denir. Bir datayı diğer datalardan ayıran yapıdır. TC no Müşteri No
gibi.

|   İd    |  İsim   | Soyisim    |  Şehir    |
|         |         |            |           |
|         |         |            |           |

Normalizasyon : Dont Repeat Yourself (kendini tekrar etme prensibi) Normalizasyonun odaklandığı nokta ise kendini tekrar etmeme odaklı olması gerekmektedir.
verinin tekrarı içerisinde hatalı giriş yapılabilir. İstanbul ila Istanbul karmaşıklığa sebebiyet verecektir. Bu sebepten ötürü Farklı bir tabloda tutulup
işaret edilmesi gerekmektedir.  Bu tablolara referans tablosu denmektedir. 

|   İd    |  İsim   | Soyisim    |  Şehirid    |        |İD		| Şehir		|
|         |         |            |             |		|		|			|
|         |         |            |             |		|		|			|


Tablo kurulurken genellikle ilk sırada primary key sonrasıda ise ilişkili tabloların ilişkisi (Foreing key) daha sonrasında 
ise geri kalan tablo verilmektedir. Primary Key : aynı tablo içerisinde benzersizlik oluşturma işidir. Bir tabloda bir adep primary
key yapılması gerekir. aynı tabloda birden fazla primary  key vermek yazılımsal olarak hata vermemekle birlikte hatalı implementasyona sebebiyet verebilmektedir.
gerekli olması koşulunda unique key verilmelidir. iki tane kolon bir daha tekrar emtek istemiyorsa unique key verilmelidir. misal Berkay Akar kaydı için isim ve soy iism
unique sütunlar tanımlandıysa berkay akar kaydından bir daha gerçekleştirilemez

basit bir e ticaret tablosu için
kişisel bilgiler ve ürünler tablosu

|   İd    |  İsim   | Soyisim    |  Şehirid    |        |id		| Urun		|
|         |         |            |             |		|		|			|
|         |         |            |             |		|		|			|


bunlar 3. bir tabloda birleştirilir ve o tabloya bir sipariş tablosu deriz


fatura tablosu
sipariş id si     |   costumer id   |   date   |



bu tabloya veriler girildikten sonra başka bir tablodan buraya sepet içeriği referans verilir 


sipariş detay yablosu

sipariş id |  ürüün |   adet |  tane müktarı
1				2			2			5
1				32			1	      123
*/



/* Açırı tasarım : yönetilebilirlikten çıkmış tasarımdır yani sen istersen isimleri bir tabloda soy isimleri bir tabloda yazıop oralardanda ilişki 
yapabilirsin. Fakat gittikçe normalizasyon seviyesi gereksiz artmaktadır. En normalize tabloda sütun sayıları sadece 2 sütun içerebilmektedir. 
solid i baz alarak gittikçe artarsa her sınıfta sadece bir adet fonksiyon elde edebiliriz. Sonrası ise yönetilmesi Overdeising a gireceği için yönetilebilirliği
zorlaşacaktır. 



*/


--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------
/*																								*/
/*											Kodlar												*/
/*																								*/
--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

use Northwind		--  Hangi veri tabanını kullanacağımızı belirtiriz.


/* select: seç demek bir veri tabanından veri çekmeye yarayan komuttur*/

select * from Customers

/* 

dbo.Categories üzerindeki tüm dataları çek demek
selectten sonra gelen ise kolonların ismidir * 
ise tüm kolonları getirmesi manasına gelir
from ise hangi tablodan gelecegini belirtmektedir. 
başında dbo. olan tabloda dbo ile yazabileceğin 
gibi normalde yazabilirsin ve çalışır.

*/

select ContactName,CompanyName,City from Customers

/* görüldüğü üzere 3 adet sütun seçilmiştir ve tablodan sadece 3 tablo çekilecektir.*/
/*
Temel çalışma mantığı ram üzerinde geçici bir tablo oluşturulur ve o değerler sorguya göre kopyalanır 
aslında bu dönen bize bir tablodur  hatta select ile bu şekilde oluşturulan bir tablo başka 
var olan bir tablo ile joinleme işleminde dahi kullanılabilir
*/


select ContactName ad,CompanyName şirket,City şehir from Customers

/* gerçek sütun yazıldıktan sonra  bir boşluk ile istenilen şekilde gösterilebilir 
örnek vermek gerekirse contact name i biz tabloda isim olarak göstermesini company 
name i ise şirket olarak dönürmesini istedik arry us denir bu methoda*/


select * from Customers where City = 'Berlin'   -- ikiside aynı
select * from dbo.Customers where City = 'London'


/* Where ile bir filitreleme yapabiliriz. String ifadeler tek tırnak ile yazılır
C# taki gibi " ile yazılmaz*/


select * from Products where CategoryID=2 

select * from Products where CategoryID=2 and ProductID=3

select * from Products where CategoryID=2 or CategoryID=3

select * from Products where CategoryID=2 and UnitPrice>=3

select * from Products where CategoryID=2 and UnitPrice<>3  -- 3 ten farklı olarak olanları getir demektir. yani category id 2 gelecek ama unite price i 3 olamyacak

/* Filitreleme yapıldıktan sonra and or gibi bağlaçlar ile de bağlanabilir*/

											/* Sıralama*/

/* sıralama order by ile yapılır artan azalan a dan z ye yada 0 dan sonsuza gibi   */


select * from Products order by ProductName -- isme göre sırala

select * from Products order by ProductID  -- product id ye göre sırala

select * from Products order by CategoryID,ProductName  -- Gelen veriler önce karegory id ye göre sıralanır, sonrasında kategori id si aynı olan veriler kendi içlerinde 2. bir parametreyi baz alarak sıralandırılır



select * from Products order by UnitPrice asc -- (asc parametresi defaulttur yani yazsasanda yazmasanda ucuzdan pahalıya sıralar)
select * from Products order by UnitPrice 
select * from Products order by UnitPrice desc  -- (işte şimdi azalan olacak bir önceki artandı)


select * from Products where CategoryID=1 order by UnitPrice desc
select * from Products where CategoryID=1 order by UnitPrice asc


/* Önce category filitrelendi ardından unit price i geldi. */


											/*Group BY*/

select count(*) From Products  /* Tüm satırları say demek count(*)  Bütün product tablosunda kaç adet ürün var demek */

select count(*) Adet From Products   /* Gelen sayının tepesine Adet Yazdırır yani gelen ismi çevirir*/

select count(*)  From  Products group by CategoryID  /* Her kategoriden kaç ürün olduğunu gösterir. */ -- (Benim bildiğim)

select CategoryID Kategori , count(*) Adet From  Products group by CategoryID /* Modifiyelisi*/    -- 1 saat 50 dakika da söylüyor.   her kategoriden kaç ürün olduğunu söylemektedir.

/* Groupby da * yerine groupby kullandığımız zaman select edilen kolon sadece Groupby da yazılan alan ile count gibi kümülatif datalar olabilir*/



-- Ürün sayısı 10 dan az olan kategorileri listele

select count(*) from Products group by CategoryID having count(*) < 10

/* Kümülatif datalarda bu şekilde yazılır yani sum count vs kullanıyorsan koşulunu verirken  where yerine having kullanırsın*/


select count(*) from Products where UnitPrice>20 group by CategoryID having count(*) < 10

/* 20 tl den fazla olan ürünler içerisinde category id ye göre gurupby yapıp sayısını getirme işi */


																	/*  Joinler */


select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
/*						Method inner outher full vs		on ise hangi kurala göre */

select Products.ProductID ürün_id, Products.ProductName ürün_adı,Products.UnitPrice,Categories.CategoryName Kategori_adı from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- C# ta ismi DTO olarak geçer Data Transformation Object olarak geçmektedir. 

select Products.ProductID ürün_id, Products.ProductName ürün_adı,Products.UnitPrice,Categories.CategoryName Kategori_adı from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

/* İlk çalışacak olan where koşuludur filitreleme olduktan sonra select ve joinler gerçekleşitr.*/

/*		İnner Join iki tablodaki eşleşenleri bir araya getirmektedir.	*/

select count(*) from Products p inner join [Order Details] od on p.ProductID= od.ProductID

/* Birden çok tabloyu inner etmek istersen ilk ikisini inner yaptıktan sonra hepsini 3. bir inner a alırsın*/


select  * from Products p inner join [Order Details] od on p.ProductID= od.ProductID inner join Orders  on Orders.OrderID = od.OrderID 



/* İnner Join eşleşen kayıtlerı getirir hiç eşleşmemiş kayıtlar için outer join kullanmamız gerekmektedir.

Left join solda olup sagda olmayanları + ikisininde kesiişimini getirir

right join sağda olup sagda olmayanları + ikisininde kesiişimini getirir

outher join ise ortak olmayanları getirmen gerekecektir. 
*/

													/* Ödev listesi */

/*

Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.

İpucu : Group by kullanılacak

İpucu : (Products), (Orders), (Order Details) tabloları join edilecek.   +++++++

İpucu : Sum kullanılacak.

Sonuç aşağıdaki formatta olmalıdır.

Ürün Adı, Kazanılan Toplam Miktar



Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek.

Ödevinize ait sql kodunu paylaşınız.

*/

select Products.ProductName as Ürün_ismi,  sum( [Order Details].Quantity * [Order Details].UnitPrice) as Toplam_Ne_Kadar from [Order Details]  inner join Orders  on [Order Details].OrderID = Orders.OrderID inner join Products on Products.ProductID =[Order Details].ProductID group by Products.ProductName


 [Order Details].OrderID Sipariş_No, Products.ProductID Ürün_id, Products.ProductName Ürün_İsmi,  [Order Details].UnitPrice Birim_Fiyatı, [Order Details].Quantity Kaç_Tane , [Order Details].Quantity * [Order Details].UnitPrice as Toplam_Ne_Kadar

select *  from [Order Details]  inner join Orders  on [Order Details].OrderID = Orders.OrderID inner join Products on Products.ProductID =[Order Details].ProductID 


 