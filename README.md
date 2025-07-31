CarMekan - Araç Servis Takip Uygulaması

CarMekan, kullanıcıların araç bilgilerini girerek servis randevusu oluşturabildikleri, bakım ve onarım taleplerini seçebildikleri, ayrıca araç marka-model seçimlerini filtreleyebildikleri Windows Forms tabanlı bir araç servis takip programıdır.

Proje Amacı
• Araç tipine göre marka ve model seçimlerinin dinamik olarak yapılması

• Kullanıcıdan araç ve kişisel bilgilerin eksiksiz alınması

• Servis randevusu için uygun bakım ve istek türlerinin seçilebilmesi

• Girilen bilgilerin JSON dosyasına kaydedilerek kalıcı veri oluşturulması

• Kullanıcı dostu arayüz ve basit doğrulamalar ile hata önlemesi

Kullanılan Teknolojiler ve Araçlar
• C# Programlama Dili

• Windows Forms ile Grafik Arayüz Tasarımı

• Newtonsoft.Json kütüphanesi ile JSON dosya işlemleri

Projenin Özellikleri
• Araç Tipi Seçimi: Otomobil, Arazi-SUV-Pickup ve Minivan & Panelvan olarak kategoriler

• Marka ve Model Filtreleme: Araç tipine göre marka listesi, seçilen markaya göre modeller listeleniyor

• Detaylı Form Alanları: Ad, soyad, telefon, e-posta, araç plakası, şasi numarası, yakıt tipi, vites türü, renk, model yılı gibi bilgiler alınıyor

• Randevu Tarihi Seçimi: Tarih seçici kontrol ile kolay randevu planlama

• Bilgi Doğrulama: Telefon numarası ve e-posta adresi için basit kontroller yapılıyor, eksik ya da hatalı girişlerde kullanıcı uyarılıyor

• Veri Kaydetme: Girilen bilgiler JSON formatında dosyaya kaydediliyor, böylece veriler kalıcı oluyor

• Tema Seçimi: Açık ve koyu tema arasında geçiş yapılabiliyor

Nasıl Kullanılır?
1. Araç tipi seçilir, ardından marka ve model otomatik olarak listelenir.

2. Formdaki kişisel ve araç bilgileri eksiksiz doldurulur.

3. Bakım ve servis isteği varsa ilgili kutucuklar işaretlenip seçenekler belirlenir.

4. Randevu tarihi seçilir.

5. "Kaydet" butonuna basılarak bilgiler JSON dosyasına kaydedilir.

6. "Onayla" butonuna basıldığında randevu onaylanır ve kullanıcı bilgilendirilir.

7. Tema değiştirme butonu ile arayüzün görünümü ayarlanabilir.

Proje Dosyaları
• Form1.cs: Ana formun ve tüm kontrollerin kodlarının bulunduğu dosya

• ServisKaydi.cs: Servis kayıtlarını tutan model sınıfı

• servisler.json: Servis kayıtlarının saklandığı dosya (uygulama tarafından oluşturulur)

Proje Hakkında
Bu uygulama, araç sahiplerinin servis işlemlerini kolayca takip etmelerini sağlar. Projede temel Windows Forms kontrolleri ve JSON veri yönetimi kullanılmıştır. Öğrenme amaçlı yapılmış olup, temel programlama ve veri işleme becerilerini geliştirmeye yöneliktir.
