# CodeFirstYaklasimi
Migration Operations

Projemiz tamamlandıktan sonra direk veritabanında değişiklik yapmamız uygun olmaz, bu yüzden code dan
değişiklikleri yapmak zorundayız.

--
Package Manager Console
(Seçili Projeye Dikkat et Entity Framework un olduğu proje olması gerekiyor.)

Enable-Migrations -EnableAutomaticMigrations
---
(Migrations --Klasörü oluşur.)
Migrations - Configuration.cs
AutomaticMigrationsEnabled=true;
AutomaticMigrationDataLossAllowed=true; //veri kaybı olmaması için

Configuration.cs--> Seed() methodu -- her bir değişiklikten sonra bu method çalışır.


---
DatabaseContext-- Constructor da 
Database.SetInitializer(new MigrateDatabaseToLatestVersion
<DatabaseContext,Migrations.Configuration>());


--Yeni kolon ekledikten sonra veya değişiklik yaptıktan sonra
Add-Migration (migration_adi)

*sonrasında Migration klasörü oluşuyor. İçerisindede
adını biz veriğimiz migration class ı oluşuyor.

Up() --> bizim yaptığımız değişikliğin database uygulayan kod.
Down() --> uygulanamazsan geri alınması gereken kod


** Oluşan migration dosyası sonradan silinebilir. Her defasında çalışmayacak.
Migration dosyasının çalışması için değişiklik olması gerekiyor.
Sonra o deişikliği Add-Migration operasyonu ile eklemiş olmamız gerekiyor.


