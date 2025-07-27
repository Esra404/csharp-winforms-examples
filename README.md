# 🧠 Katmanlı Mimari ile Geliştirilmiş .NET Windows Forms Uygulaması

Bu proje, Entity Framework kullanılarak geliştirilen ve katmanlı mimari yapısına uygun olarak tasarlanmış bir **Windows Forms** uygulamasıdır. Uygulama, temel ürün yönetimi işlemlerini (CRUD) gerçekleştirmek amacıyla oluşturulmuştur. Kodlar C# diliyle yazılmıştır ve .NET Core desteklidir.

## 🏗️ Proje Yapısı

Bu projede katmanlı mimari kullanılmıştır. Katmanlar, yazılımın okunabilirliğini ve sürdürülebilirliğini artırmak için ayrıştırılmıştır:

- **Entity Layer:** Uygulamada kullanılan sınıflar (örneğin `Product`, `Category`) burada tanımlanmıştır.
- **Data Access Layer (DAL):** Entity Framework ile veritabanı işlemlerinin gerçekleştirildiği katmandır. Veriye erişim bu katmandan yapılır.
- **Business Layer:** İş kurallarının ve validasyonların yazıldığı katmandır. Verilerin işlenmesi burada sağlanır.
- **Presentation Layer (UI):** Windows Forms arayüzüyle kullanıcıların etkileşimde bulunduğu katmandır.

## 💼 Kullanılan Teknolojiler

- **C#**
- **.NET Core**
- **Entity Framework**
- **SQL Server** (veritabanı)
- **Windows Forms (WinForms)**

> ❗ Not: Bu projede `Dapper` **kullanılmamıştır**. Tüm veritabanı işlemleri Entity Framework aracılığıyla yapılmaktadır.

## 📷 Arayüzden Görseller

<img width="611" height="358" alt="image" src="https://github.com/user-attachments/assets/c1087b29-e8f1-4ef8-82fe-8322fa2bd6fb" />

Projenin `Forms` klasörü altında oluşturduğum formlar üzerinden bazı görseller paylaşılmıştır. Bunlar sayesinde arayüzün nasıl göründüğü hakkında fikir sahibi olabilirsiniz:

- Ürün Ekleme Formu
- Kategori Yönetimi
- Listeleme ve Güncelleme Formları

![Product Formu](screenshots/product-form.png)
![Category Formu](screenshots/category-form.png)

## 🚀 Nasıl Çalıştırılır?

1. Projeyi Visual Studio ile açın.
2. SQL Server üzerinde gerekli veritabanını oluşturun (veya `DbContext` ile migration işlemini yapabilirsiniz).
3. `App.config` ya da `appsettings.json` dosyasındaki bağlantı cümlesini kendi SQL Server ayarlarınıza göre güncelleyin.
4. Projeyi build edin ve `Presentation Layer` içindeki `FrmMain` gibi başlangıç formunu çalıştırın.

## 🎯 Amaç

Bu proje sayesinde hem **katmanlı mimari** prensipleri hem de **Windows Forms** geliştirme pratiği kazandım. Aynı zamanda Entity Framework üzerinden CRUD işlemlerinin nasıl yönetileceğini pekiştirmiş oldum. Proje bireysel gelişim amaçlı olup eğitimsel niteliktedir.

---

📁 Proje geliştirme sürecimde öğrendiğim tüm teknikleri ve yapıları burada toplamaya çalıştım. Katmanlar arası geçişleri, `Entity Framework` kullanımını ve `WinForms`'a uygulama yansıtmayı öğrenmek isteyenler için faydalı olabilir.

> Detaylı incelemek isteyenler için kod yapısı sade, okunabilir ve geliştirilebilir şekilde tutulmuştur.
