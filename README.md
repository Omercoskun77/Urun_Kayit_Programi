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
![kayıtolmaformu](https://github.com/user-attachments/assets/0527fc10-8d29-4463-b33b-6dccfcf57fe1)
![loginformu](https://github.com/user-attachments/assets/3e225157-1298-43eb-956b-7062d2d0728e)
![geçisekranıformu](https://github.com/user-attachments/assets/13304af2-8a8d-4d55-a4e6-1019dabf3b94)
![urunkontrolformu1](https://github.com/user-attachments/assets/5d769c88-df22-4e38-9451-1676e6e810a4)




