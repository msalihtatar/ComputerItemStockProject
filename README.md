# ComputerItemStockProject
Computer Item Stock And Sale Project. (C# and WindowsForm)

PROJE KONUSU

Bu projede, bilgisayar parçası satış mağazası ürün stok takip ve satış sistemi hazırlanması amaçlanmaktadır. 
Stok takibi; tedarik edilerek ya da üretilerek elde edilen, kullanılmadan ya da müşteriye arz edilmeden önce belli bir süre bekletilen ürünlerin miktarıdır. Dolayısıyla bir işletmenin sağlıklı ve sorunsuz bir şekilde işleyişi için oldukça önemlidir. Stok takibi, bir işletmenin faaliyetini yürütebilmek için satmak üzere aldığı ya da satılacak ürünü üretmek için kullandığı malzemelerin kaydıdır. Bu kaydın amacı işletmenin karlılığını arttırmak için stok ve üretim maliyetlerini en aza indirecek stoklama seviyesini tutturmaktır. Stok takibi, müşterilerin hangi dönemlerde ne gibi taleplerinde artışlar olduğunu analiz etmenize de yardımcı olur. İşletmelerin ürünlerinin miktarını gözeterek mağaza ve depolarındaki durumu takip eden programdır. İş akışının daha düzenli bir şekilde gerçekleştirilmesine yardımcı olan bu programlar, satış yapılabilecek miktarı belirlemenize ve takip etmenizi sağlar.
Günümüzde satış mağazaları gittikçe genişlemekte ve ürün skalasını artırmaktadır. Bu da ürünlerin kontrolünü zorlaştırmaktadır ve klasik yöntemler bu zorlu durumla başa çıkmak için yeterli değildir. Bunun yanı sıra, teknolojinin gelişmesiyle birlikte insanlar artık her işini olabildiğince hızlı halletmeye başladı. Her geçen gün de yeni teknolojilerle yapılan işlemler daha da kolaylaşıp, hızlanmaktadır. Buna göre, bir satıcının ürünlerini defterlere yazması, fiyatlarını tutması, satış bilgilerini saklaması, istediği bilgiyi de bunların arasından anlık olarak alması artık mümkün değildir. Müşteri taleplerini karşılayabilmek ve stokta bir ürünün olup olmadığının bilgisini, fiyat vb. bilgilerin anlık olarak müşterilere aktarılması zorunlu bir hal almıştır. Bilanço işlemlerinin hesap makineleri ile yapılması artık günümüzde karşılığı olmayan bir durumdur.

Bu proje bittiğinde, bu sistemi kullanan satıcı, stoğuna yeni ürün bilgisi ekleyebilecek, kod veya ad bilgisine göre ürün listeleyebilecek, listelediği ürünlerin fiyat, adet gibi bilgilerini güncelleyebilecek, ürünleri stoktan silebilecek. Ayrıca yıl veya ürün bilgisine göre sattığı ürünleri listeleyip, bilançosunu çıkarabilecek. Stoğu biten veya azalan ürünleri sorgulayabilecek. Bunun yanında müşterinin mağazadan satın almak istediği ürünün/ürünlerin satışını yapabilecek veya yine müşterinin belli kurallar çerçevesinde geri getirdiği ürünün/ürünlerin iade işlemlerini gerçekleştirebilecek. 


ANALİZ

Bu sistemi mağazadaki ürün stoğu ve satış işlemlerinden sorumlu çalışan kullanacak. Bu çalışan aşağıdaki işlemleri yapabilecek.
•	Stoğa yeni ürün girişi yapmak
•	Stoktan ürün silmek
•	Stoktaki ürünü güncellemek
•	Stoktaki ürün kodu veya ürün adına göre arama yapmak
•	Stoktaki ürünleri özelliklerine göre listelemek
•	Yıllara göre satışı yapılan ürünlerin bilançosunu çıkarmak
•	En çok ve en az satılan ürünleri listeleyebilecek
•	Stoğu azalan veya biten ürünleri listeleyebilecek
•	Müşterinin satın almak istediği ürünün satış işlemini yapabilecek
•	Müşterinin iade etmek istediği ürünün iade işlemini yapabilecek

Yukarıdaki gereksinimler doğrultusunda ürünlere, stoğa, müşterilere ait bilgiler bir veritabanı aracılığı ile yönetilecek. Stok Takip ve Satış Veritabanı’nda Tedarikçi, Ürün, Stok, Müşteri, Satış ve İade tabloları bulunmaktadır. Bu tablolar şu anki ve gelecekteki olası gereksinimler baz alınarak oluşturulmuştur. Bu veritabanı ve gereksinimler sistemin final durumunda değişiklik gösterebilir. Aşağıda Veri Stok Takip ve Satış Veritabanı Modeli tabloları ve nitelikleri tablolar halinde verilmiştir.


Tedarikçi Tablosu ve Nitelikleri:
TedarikciID
TedarikciAdi
TedarikciUlke
TedarikciTelNo
TedarikciAdres


Müşteri Tablosu ve Nitelikleri:
MusteriID
MusteriAdi
MusteriSoyadi
MusteriTelNo


Ürün Tablosu ve Nitelikleri:
UrunID
UrunAdi
UrunKodu
UrunMensei
UrunFiyati
UrunMarka
UrunAciklama
TedarikciID


Stok Tablosu ve Nitelikleri:
StokID
UrunID
StokSayisi
SatisSayisi
IadeSayisi
SonKullanmaTarihi


Satış Tablosu ve Nitelikleri: 
SatisID
UrunID
MusteriID
SatisTarihi
IadeTarihi


İade Tablosu ve Nitelikleri:
IadeID
SatisID
IadeTarihi


Aşağıda bu sistemin kullanıcısı olan mağaza stok takip ve satış sorumlusunun use keys diyagramı verilmiştir.
 
 
Uygulamanın kullanım senaryosu.
![image](https://user-images.githubusercontent.com/74512773/148965066-f659f918-9ca2-470e-b1c1-83a2d2ade378.png)

