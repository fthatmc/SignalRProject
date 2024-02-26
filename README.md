# SignalR Restaurant

## Projenin Amacı

Bu projede kullanıcılar, online olarak sipariş verebilir veya rezervasyon oluşturabilirler. Sipariş vermek için kullanıcı kayıt formundan kayıt olup giriş yapması gerekmektedir. 
Kullanıcı Menü'de bulunan ürünleri sepetine ekleyip sepet iconuna tıklayarak ne kadar ücret ödeyeceğini görebilir.
Siparişler ve rezervasyonlar, admin panelinde SignalR teknolojisi kullanılarak sayfa yenilemeden canlı olarak görüntülenir. Adminler, bu canlı görüntü üzerinden siparişleri ve rezervasyonları inceleyerek onaylama veya iptal etme yetkisine sahiptir. Herhangi bir durum değişikliği, ilgili kullanıcının gerçek e-posta adresine otomatik olarak gönderilir.Bu sayede, kullanıcılar ve adminler işlemleri anlık olarak takip edebilirler ve herhangi bir değişiklik olduğunda hızlı bir şekilde bilgilendirilirler.

## Teknik Detaylar
ASP.NET Core 6.0 SignalR ve Web API kullanılarak geliştirilen proje, tüm CRUD işlemlerini API üzerinden gerçekleştirir ve bu işlemler MVC tarafında consume edilir. Dinamik veritabanı yönetimi için Entity Framework Code First kullanılmıştır. Dto katmanı, entity'leri daha güvenli işlemlere tabi tutar. N Katmanlı mimari yapısı, projede uygulanarak kodun daha modüler ve sürdürülebilir olmasına öncelik verilmiştir.

## Kullanılan Teknolojiler
-	Asp.Net Core 6.0
-	Asp.Net Core Web API
-	SignalR
-	MSSQL
-	Identity
-	MailKit
-	AutoMapper
-	Entity Framework Code First
-	Html
-	Css
-	JavaScript
-	Bootstrap

## Katmanlar
-	UI Layer
-	Entity Layer
-	DataAccess Layer
-	Business Layer
-	Dto Layer
-	Web Api Layer

## Öne Çıkan Özellikler
-	Restorana rezervasyon yapma özelliği
-	Online Sipariş verme özelliği
-	MSSQL ilişkili tablolar
-	Identity kütüphanesi ile giriş yapma özelliği
-	Admin Panel
-	Adminlere mesaj gönderme
-	SignalR ile canlı mesajlaşma
-	SignalR ile masa durumlarını canlı görüntüleme
-	Anlık istatistik görüntüleme
-	Ürünlerde indirim oluşturma
-	Mail gönderme

## Admin Panel Özellikler
-	Kategoriler CRUD işlemler
-	Ürünler CRUD işlemler
-	Rezervasyonları sayfa yenilemeden görüntüleme
-	İndirim oluştruma
-	İstatistik görüntüleme
-	Bildirim oluşturma
-	Masa durumlarını sayfa yenilemeden görüntüleme
-	Site üzerinden diğer veriler için CRUD işlemler
-	
## Teknik Özellikler
-	MSSQL Veritabanı
-	Asp.net core 6.0
-	N Katmanlı Mimari Yapı
-	SignalR ile canlı veri takibi
-	Entity Framework Code First LINQ
-	Web API
-	Identity
-	AutoMapper
-	MailKit

![Ekran görüntüsü 2024-02-26 152118](https://github.com/fthatmc/SignalRProject/assets/136472585/b98c53fc-bbe7-40b1-a45d-316f9bcefe72)

![Ekran görüntüsü 2024-02-26 153345](https://github.com/fthatmc/SignalRProject/assets/136472585/54141f9e-8084-4091-bfb4-54ed19c14035)

![Ekran görüntüsü 2024-02-26 153450](https://github.com/fthatmc/SignalRProject/assets/136472585/71b9656c-f8f7-4978-a5bb-e9077bcacd24)

![Ekran görüntüsü 2024-02-26 161519](https://github.com/fthatmc/SignalRProject/assets/136472585/980579ea-06f3-4dbd-8437-6e94e4e3649b)

![Ekran görüntüsü 2024-02-26 154003](https://github.com/fthatmc/SignalRProject/assets/136472585/65da185a-c7e1-4603-9779-e03f6f86734f)

![Ekran görüntüsü 2024-02-26 154037](https://github.com/fthatmc/SignalRProject/assets/136472585/d4046335-3b2e-430d-8c15-0de5f9a4aa96)

![Ekran görüntüsü 2024-02-26 154136](https://github.com/fthatmc/SignalRProject/assets/136472585/f139310c-4442-407b-8e24-c8c529dd52cf)

![Ekran görüntüsü 2024-02-26 155300](https://github.com/fthatmc/SignalRProject/assets/136472585/b52fb131-3eed-45df-8931-ea4f9e10dc74)

![Ekran görüntüsü 2024-02-26 153848](https://github.com/fthatmc/SignalRProject/assets/136472585/3df555bb-ed9f-469f-a154-fe872519f038)

![Ekran görüntüsü 2024-02-26 160020](https://github.com/fthatmc/SignalRProject/assets/136472585/3dec511a-f815-4078-a8b7-60a7ffc477e5)

![Ekran görüntüsü 2024-02-26 155504](https://github.com/fthatmc/SignalRProject/assets/136472585/0effaebe-121a-4657-a4d1-a3d86305c832)


![Ekran görüntüsü 2024-02-26 155545](https://github.com/fthatmc/SignalRProject/assets/136472585/cc922b26-268d-40de-8a76-85720e694ab2)


![Ekran görüntüsü 2024-02-26 155616](https://github.com/fthatmc/SignalRProject/assets/136472585/5ab95944-c04e-44b0-b3aa-3cf155cdf879)


![Ekran görüntüsü 2024-02-26 154254](https://github.com/fthatmc/SignalRProject/assets/136472585/4592221f-9788-4f15-9fc5-5de97482335c)

![Ekran görüntüsü 2024-02-26 154330](https://github.com/fthatmc/SignalRProject/assets/136472585/5801d01d-e44b-46cf-8782-26e22acd782c)

![Ekran görüntüsü 2024-02-26 154358](https://github.com/fthatmc/SignalRProject/assets/136472585/90e4e2fb-d739-45aa-b370-6d1e9c4dc595)

![Ekran görüntüsü 2024-02-26 154437](https://github.com/fthatmc/SignalRProject/assets/136472585/f5f60c3a-c9a5-469b-a0e3-3dcb16a0ff4f)

![Ekran görüntüsü 2024-02-26 154520](https://github.com/fthatmc/SignalRProject/assets/136472585/009cbd69-5c31-43d6-809e-e7054d1be10c)

![Ekran görüntüsü 2024-02-26 155008](https://github.com/fthatmc/SignalRProject/assets/136472585/675d845b-8e77-4e54-8b42-a752f595a70a)

![Ekran görüntüsü 2024-02-26 155106](https://github.com/fthatmc/SignalRProject/assets/136472585/896cb79d-f9b4-40a4-af84-d6f104822383)
