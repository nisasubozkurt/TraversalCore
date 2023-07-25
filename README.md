# TraversalCore
Traversal Rezervasyon Asp.Net Core 5.0 Mini Proje 

[![Kamp Youtube Kanalı](https://img.shields.io/badge/Kamp%20Youtube%20Kanalı-izlemek%20için%20tıklayın-red)](https://www.youtube.com/playlist?list=PLKnjBHu2xXNMK5MBogdXmsXVi3K_eEZT5)

## Proje Hakkında: 
Veri tabanı olarak SQL Server kullanılarak, BusinessLayer, DataAccessLayer, DTOLayer, EntityLayer, PresentationLayer, SignalRApiForSQL ve SingalRConsume katmanlarından oluşan N Tier Architecture mimarisi, ASP.Net Core 5.0 ve Entity Framework Core teknolojileri kullanılarak Codefirst yaklaşımı ile API'lerle desteklenmiş ve kodlanmıştır. Ayrıca MSSQL ve Postgre SQL veri tabanları da kullanılmıştır.

 Bu proje, tatil rezervasyonları alanında faaliyet gösteren kapsamlı bir web sitesini temsil ediyor. Sitede, çeşitli tatil seçenekleri geniş bir yelpazede sunuluyor ve kullanıcılar kişisel hesaplarına kolayca giriş yaparak özel fırsatlardan yararlanabiliyorlar. Ayrıca, site içerisinde bulunan admin kullanıcısı, yönetici yetkileri sayesinde tatil paketleri, otel bilgileri ve kullanıcı verileri gibi önemli bilgileri güncelleme, ekleme ve silme gibi CRUD işlemlerini gerçekleştirebiliyor. Projemiz, modern ve şık tasarımıyla kullanıcılara üç farklı benzersiz deneyim sunuyor.

## Aşağıda, proje geliştirme aşamaları sıralı bir şekilde sunulmaktadır:

1. Katmanlar oluşturuldu ve projenin genel yapısı belirlendi.
2. Veritabanı işlemleri için Context sınıfı tanımlandı ve migration işlemi gerçekleştirildi.
3. DataAccesLayer ve BusinessLayer Generic Interface'leri kullanılarak veri erişimi yapıldı.
4. Repository Design Pattern yaklaşımı kullanılarak veritabanı işlemleri gerçekleştirildi.
5. Fluent Validation kütüphanesi kullanılarak giriş yapılan verilerin doğruluğu kontrol edildi.
6. Partial Async ve View Component yapıları kullanılarak performans artırımı sağlandı.
7. MSSQL veritabanı kullanılarak CRUD işlemleri yapıldı.
8. Yorumları ait olduğu rotaya göre listeleme ve yaptırma işlemleri gerçekleştirildi.
9. Identity kullanılarak kullanıcı girişi yapıldı ve kullanıcının profil bilgileri getirildi.
10. Login ve Register sayfaları oluşturuldu. Custom Identity Validator işlemleri gerçekleştirildi.
11. Identity ile kullanıcı profil ve resim bilgisi güncellemesi yapıldı.
12. Giriş yapmış kullanıcıya ait aktif, onay bekleyen, geçmiş ve yeni rezervasyon sayfaları oluşturuldu.
13. Include metodu ve Ef bağımlılığının kaldırıldı. Container dependencies ve startup yapıları refactoring edildi.
14. 404 not found sayfası oluşturuldu. Hem dinamik hem de statik excel ve pdf raporları sayfaları oluşturuldu.
15. Mail gönderme işlemi yapıldı. Ajax işlemleri yapıldı.
16. Data Transfer Object (DTO) katmanı oluşturuldu ve AutoMapper kullanılarak veri transferi işlemleri optimize edildi.
17. Api Projesi ana projede kullanıldı. Rapid Api Booking üzerinden otel listesi çekildi.
18. CQRS Design Pattern kullanılarak veri işlemleri ayrıştırıldı. MediatR kütüphanesi kullanılarak işlemler daha düzenli bir şekilde yapıldı.Unit Of Work implementasyonu yapıldı ve veritabanı işlemleri daha yönetilebilir hale getirildi.
19. Api üzerinden ziyaretçi veri seti oluşturuldu. CrossTab kullanılarak ziyaretçiler için pivot tablosu oluşturuldu. SignalR kullanılarak grafikte anlık veri görüntüleme yapıldı.
20. Rol CRUD işlemleri gerçekleştirildi. Çoklu dil desteği ve şifremi unuttum sayfaları ile kampı tamamladık.

## Proje Görselleri
![Ekran görüntüsü 2023-07-25 134856](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/c8ca56a6-3e3a-44af-b042-6a5d355e1fb7)

![Ekran görüntüsü 2023-07-25 135147](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/3fcdeedf-d7b6-4f66-9017-cdd0c3938449)

![Ekran görüntüsü 2023-07-25 135502](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/534db256-9c06-4e4b-901f-f416e97bec93)

![Ekran görüntüsü 2023-07-25 135342](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/57ec41f8-e760-4698-a47c-28184cde9ce3)

![Ekran görüntüsü 2023-07-25 135544](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/887914e7-c522-4757-aad3-91cb21d32427)

![Ekran görüntüsü 2023-07-25 135635](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/1a8fb9ed-dfa6-4f37-901a-9d398e491fc4)

![Ekran görüntüsü 2023-07-25 135405](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/efb51925-10c7-49e9-95ee-43c5392bbea2)

![Ekran görüntüsü 2023-07-25 135712](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/bc4e0eb8-88a8-42d4-b9dd-8a41aec406ad)

![Ekran görüntüsü 2023-07-25 135811](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/e8092512-0a3c-45fc-92f4-a5443446ab7f)

![Ekran görüntüsü 2023-07-25 140031](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/2751cfb5-4121-46e6-a36f-ecd090007cd6)

![Ekran görüntüsü 2023-07-25 135952](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/8fccffb1-9817-4f2a-97d3-9e6f382674b6)

![Ekran görüntüsü 2023-07-25 140120](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/d76f8f8b-c09f-41f6-9a1b-9e43ddd51d21)

![Ekran görüntüsü 2023-07-25 140216](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/f427eedc-3cef-4a17-9a3b-ebe14c67aa41)

![Ekran görüntüsü 2023-07-25 140149](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/c7950814-1675-4ab2-a113-baf89d564412)

<img width="1200" alt="Ekran Resmi 2023-07-25 14 08 11" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/fbc7810f-e915-4cea-916e-d73d94fb5a3f">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 03 55" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/13fdc5d6-27f8-46d9-a0eb-0fc50b77870b">

![Ekran görüntüsü 2023-07-25 140425](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/391602eb-f097-40cd-8476-3930bfb5f23a)

![Ekran görüntüsü 2023-07-25 140452](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/37495d13-20ef-4139-b32b-38af071407fe)

![Ekran görüntüsü 2023-07-25 140523](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/0e6c0263-ba7e-4a1f-ac6d-f050fb09db7b)

![Ekran görüntüsü 2023-07-25 140755](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/669f1326-70e0-47d0-84c3-c7212ed8d9bf)

![Ekran görüntüsü 2023-07-25 140722](https://github.com/nisasubozkurt/TraversalCore/assets/95681404/b46e975e-402f-4959-8a3a-6d789360866c)

<img width="1200" alt="Ekran Resmi 2023-07-25 14 08 21" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/a7f840db-ea03-4b4c-9ab2-61395cac0623">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 08 54" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/0d17af91-74c9-48bb-a7f7-6cc99a303bbb">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 06 06" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/9241a7af-810a-4eb8-821c-e4683f0d6508">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 06 18" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/06c0b40c-63f8-452a-838a-07f5da1fb518">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 06 34" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/5dbc8231-5437-4a35-a224-973fee0f6eb4">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 08 38" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/50610f6e-d8ce-4091-bfd7-0e57b413bb70">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 09 11" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/42f812a2-6827-47a8-951b-13719eced04e">

<img width="1200" alt="Ekran Resmi 2023-07-25 14 09 23" src="https://github.com/nisasubozkurt/TraversalCore/assets/95681404/2ec7190c-dcc9-46d9-a91c-fffdf2b50a6e">
