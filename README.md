Giriş

Bu proje, bir kütüphane yönetim sistemi olarak tasarlanmış olup, kitapların, üyelerin ve ödünç alma işlemlerinin takip edilmesini sağlar. 

Kullanıcılar kitap ekleyebilir, üyeleri kaydedebilir, ödünç verme ve iade işlemleri yapabilir. Sistem, C# programlama dili ile geliştirilmiş bir masaüstü uygulamasıdır ve veritabanı entegrasyonu sayesinde verileri kalıcı olarak saklar. 

Proje, küçük ölçekli kütüphaneler veya eğitim kurumları için ideal bir araçtır. Kod yapısına bakıldığında, Entity Framework kullanılarak veritabanı işlemleri yönetilmekte ve Windows Forms ile kullanıcı dostu bir arayüz sunulmaktadır.


Özellikler


Kitap Yönetimi: Kitapları ekleme, güncelleme, silme ve arama işlemleri. Her kitap için ID, isim, yazar, tür, yayın yılı gibi detaylar saklanır.
(Örnek: ProductDalBook.cs dosyasında kitaplara özgü veri erişim katmanı tanımlanmıştır.)

Üye Yönetimi: Üyeleri kaydetme, düzenleme ve silme. Üye bilgileri arasında ID, isim, soyisim, iletişim bilgileri ve ödünç alınan kitaplar bulunur. 

(Örnek: ProductDalMember.cs ile üyelere özgü CRUD işlemleri.)

Ödünç Alma ve İade: Kitap ödünç verme, iade etme  gibi işlemler 

Veritabanı İşlemleri: Entity Framework ile otomatik veritabanı yönetimi, migrasyonlar ve sorgular. (LibraryContext.cs ile bağlam tanımlanır.)

Kullanıcı Arayüzü: Ana form (Form1) üzerinden navigasyon, liste görüntüleme ve detay formları (Form2) ile girişler.

Temel Varlık Sınıfları: Ortak özellikler için product.cs gibi sınıflar, kitap ve üye sınıflarını miras alır.

Konfigürasyon: App.config ile bağlantı dizeleri ve packages.config ile bağımlılık yönetimi.

Güvenlik ve Hata İşleme: Temel hata yakalama ve kullanıcı doğrulaması (kodda kısmen mevcut).

Proje, basit bir veritabanı tabanlı yönetim sistemi olarak, veri bütünlüğünü sağlamak için katmanlı mimari kullanır (DAL - Data Access Layer).

Kullanılan Teknolojiler

Dil ve Çerçeve: C# ile .NET Framework

UI: Windows Forms (Form1.cs, Form2.cs gibi form tasarımları).

Veritabanı: Entity Framework ORM (LibraryContext.cs, ProductDal*.cs).

Araçlar: Visual Studio IDE (.sln, .csproj dosyaları).

Bağımlılıklar: NuGet paketleri (packages.config'tan Entity Framework vb.).

Kurulum Gereklilikleri

Visual Studio 

SQL Server (yerel veya uzak, App.config'ta bağlantı ayarlanır).

Git (depo klonlama için).

Nasıl Çalıştırılır

Depoyu klonlayın: git clone https://github.com/enes1517/Kutuphane-Takip-Sistemi.git.

Visual Studio'da Library.sln dosyasını açın.

NuGet paketlerini geri yükleyin (Araçlar > NuGet Paket Yöneticisi > Paketleri Geri Yükle).

App.config'ta veritabanı bağlantısını güncelleyin (örneğin: <connectionStrings><add name="LibraryContext" 
                                                                                 connectionString="Server=localhost;Database=LibraryDB;Integrated Security=True;" providerName="System.Data.SqlClient"/></connectionStrings>).

Veritabanını oluşturun (eğer otomatik migrasyon yoksa, SQL script ile manuel).

Projeyi derleyin (Build > Build Solution).

Uygulamayı çalıştırın (F5 veya Debug > Start Debugging). Ana form (Form1) açılacak ve veritabanı bağlantısı test edilebilir.

Test için örnek veri ekleyin: Form üzerinden kitap/üye ekleyin ve işlemleri deneyin.
