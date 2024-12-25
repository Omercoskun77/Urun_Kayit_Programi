# Urun_Kayit_Programi

Windows Forms tabanlı ürün yönetim ve kullanıcı kimlik doğrulama sistemi.

## Özellikler

- Kullanıcı kimlik doğrulama sistemi
  - Giriş ve kayıt işlemleri
  - Şifre güvenliği kontrolleri
  - Çift tablolu doğrulama sistemi
- Ürün yönetim arayüzü
  - Yeni ürün ekleme
  - Mevcut ürünleri güncelleme
  - Ürün silme
  - ID ile ürün arama
  - Tüm ürünleri görüntüleme

## Teknik Detaylar

- **Framework**: .NET Windows Forms
- **Veritabanı**: SQL Server Express
- **Geliştirme Ortamı**: Visual Studio 2017+

## Veritabanı Yapısı

Uygulama üç ana tablo kullanır:
- `Users`: Temel kullanıcı bilgileri
- `KullaniciBilgiler`: Kullanıcı doğrulama bilgileri
- `Urun`: Ürün bilgileri ve detayları

## Kurulum

1. SQL Server Express'de `gpproje` adında veritabanı oluşturun
2. Connection string'i proje dosyalarında ayarlayın:
   ```
   Data Source=.\SQLEXPRESS;Initial Catalog=gpproje;Integrated Security=True
   ```
3. Visual Studio'da projeyi derleyin ve çalıştırın

## Uygulama Akışı

1. Açılış ekranı (`intro.cs`)
2. Giriş ekranı (`login.cs`)
3. Ana sayfa (`anasayfa.cs`)
4. Ürün yönetimi (`urun.cs`)

## Güvenlik Özellikleri

- Kayıt sırasında şifre doğrulama
- Minimum şifre uzunluğu kontrolü
- Kullanıcı adı benzersizlik kontrolü
- SQL injection koruması (Parameterized queries)

## Hata Yönetimi

- Veritabanı bağlantı hataları için try-catch blokları
- Kullanıcı dostu hata mesajları
- Form validasyonları
![kayıtolmaformu](https://github.com/user-attachments/assets/92a70b85-0eaf-473f-8fb8-d65c61768e36)
![loginformu](https://github.com/user-attachments/assets/430a3280-df8c-4881-b388-8bddd9c44b37)
![geçisekranıformu](https://github.com/user-attachments/assets/a072f738-f0c6-4ff4-914f-9129dddacb7a)
![urunkontrolformu1](https://github.com/user-attachments/assets/75f49324-fd7b-4f6d-b3c5-358b303a605f)

