# **Market Otomasyonu**
Ürünlerin mal kabulünün ve satışının gerçekleştirildiği, stok ve satış bilgisinin izlenebildiği bir Windows Forms uygulaması.

Mal Kabul kısmında her ürünün kendisine ait bir kategorisi bulunmaktadır. Bir ürünün tanımı yapıldıktan sonra, tekrar aynı ürün eklenecekse, olan ürünün stoğuna ekleme yapılır. Rapor kısmında ürün veya kategori bazlı satışlar günlük, aylık ve yıllık olarak izlenebilmektedir.

## Öngereklilikler

>  - Visual Studio 2017
>   - SQL Server 2017 LocalDB
>   - .Net Framework 4.5 (en az)

**Projeyi çalıştırmadan önce,**
> - Solution'a sağ tıklayarak Restore NuGet Packages'i tıklayarak, projede kullanılan paketleri yükleyin.
> - NuGet Package Manager Console'da Default Project'i Market.DAL yapın ve **update-database** komutunu girerek projenin kullanılacağı veritabanını oluşturun.

**Kullanılan Teknolojiler**

> -   NTier Project Pattern
> -   Repository Entity Pattern
> -   EntityFramework Code First
> -   Windows Forms
> -   iTextSharp (Satış bilgisini, yani fişi PDF olarak yazdırmak için)
