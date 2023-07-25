# TraversalCore
Traversal Rezervasyon Asp.Net Core 5.0 Mini Proje 

[![Kamp Youtube Kanalı](https://img.shields.io/badge/Kamp%20Youtube%20Kanalı-izlemek%20için%20tıklayın-red)](https://www.youtube.com/playlist?list=PLKnjBHu2xXNMK5MBogdXmsXVi3K_eEZT5)

## Proje Hakkında: 
Veri tabanı olarak SQL Server kullanılarak, BusinessLayer, DataAccessLayer, DTOLayer, EntityLayer, PresentationLayer, SignalRApiForSQL ve SingalRConsume katmanlarından oluşan N Tier Architecture mimarisi, ASP.Net Core 5.0 ve Entity Framework Core teknolojileri kullanılarak Codefirst yaklaşımı ile API'lerle desteklenmiş ve kodlanmıştır. Ayrıca MSSQL ve Postgre SQL veri tabanları da kullanılmıştır.

 Bu proje, tatil rezervasyonları alanında faaliyet gösteren kapsamlı bir web sitesini temsil ediyor. Sitede, çeşitli tatil seçenekleri geniş bir yelpazede sunuluyor ve kullanıcılar kişisel hesaplarına kolayca giriş yaparak özel fırsatlardan yararlanabiliyorlar. Ayrıca, site içerisinde bulunan admin kullanıcısı, yönetici yetkileri sayesinde tatil paketleri, otel bilgileri ve kullanıcı verileri gibi önemli bilgileri güncelleme, ekleme ve silme gibi CRUD işlemlerini gerçekleştirebiliyor. Projemiz, modern ve şık tasarımıyla kullanıcılara üç farklı benzersiz deneyim sunuyor.

## Aşağıda, proje geliştirme aşamaları sıralı bir şekilde sunulmaktadır:
Özür dilerim, yanlış anlamışım. İşte 40 maddelik listeyi 20 maddeye indirgenmiş hali:

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
