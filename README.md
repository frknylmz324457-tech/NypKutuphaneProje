# 📘 Kütüphane Yönetim Sistemi

Bu proje, kütüphane süreçlerini dijitalleştirmek, kitap takibini kolaylaştırmak ve kullanıcı taleplerini yönetmek amacıyla **C#** ve **MySQL** kullanılarak geliştirilmiş kapsamlı bir masaüstü uygulamasıdır.

Yöneticiler ve Üyeler için ayrıştırılmış özel arayüzleri ile modern ve kullanıcı dostu bir deneyim sunar.

## ⭐ Projenin Öne Çıkan Özellikleri

### 🛡️ 1. Gelişmiş Giriş ve Yetkilendirme Sistemi
* **Rol Bazlı Yönlendirme:** Giriş yapan kişi "Admin" ise Yönetici Paneline, "Üye" ise Kullanıcı Paneline (`UserDashboard`) otomatik yönlendirilir.
* Güvenli kullanıcı girişi.

### 📥 2. Kitap Talep Yönetimi (Özel Modül)
* **Üye Talebi:** Üyeler, kütüphanedeki kitapları inceleyip istedikleri kitap için "Talep Et" butonuna basarak istek gönderebilirler.
* **Yönetici Onayı:** Yöneticiler gelen talepleri `TalepForm` ekranında görür.
* **Sağ Tık Menüsü & Stok Entegrasyonu:** Yönetici bir talebe sağ tıklayıp **"Onayla"** dediğinde:
    * Talep durumu "Onaylandı" olarak güncellenir.
    * **Otomatik Stok Düşümü:** Kitabın stoğu veritabanından anında 1 adet düşülür.

### 📦 3. Kitap ve Stok Yönetimi
* Kitap Ekleme, Silme ve Güncelleme işlemleri.
* Anlık stok takibi ve listeleme.
* Sadece stoğu olan kitapların listelenmesi.

### 👤 4. Üye İşlemleri
* Yeni üye kaydı oluşturma.
* Üye bilgilerini güncelleme ve silme.
* Üyelerin geçmiş işlemlerinin takibi.

---

## 🛠️ Kullanılan Teknolojiler ve Mimari

Bu proje **Katmanlı Mimari (Layered Architecture)** prensiplerine sadık kalınarak geliştirilmiştir.

* **Dil:** C#
* **Platform:** Windows Forms (.NET Framework / .NET 6+)
* **Veritabanı:** MySQL
* **Veri Erişimi:** ADO.NET (Özelleştirilmiş `DbHelper` sınıfı ile)

### 📐 Mimari Yapı
* **DAL (Data Access Layer):** Veritabanı bağlantıları ve CRUD işlemleri burada yönetilir (`DbHelper`).
* **UI (User Interface):** Kullanıcı etkileşiminin olduğu formlar (`MainForm`, `UserDashboard`, `TalepForm`, `LoginForm`).
* **BLL (Business Logic Layer):** İş mantığı ve veri kontrolleri.

---

## 📽️ Tanıtım videosu: 


