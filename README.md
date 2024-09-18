 # Stok-Envanter Takip Otomasyonu
 ### Stok takibi, bilgisayar bakımı ve zimmetleme işlemlerini yapabileceğimiz bir otomasyon projesidir. </br> </br>
 **Kullanılan Teknolojiler:** </br> </br>
 `Veri Tabanı: MySQL (RDBMS)` </br>
 `IDE: Visual Studio` </br>
 `Dil: C# (Windows Form)` </br> </br>

 ## Uygulama İçi Görüntüler ve Açıklamaları </br>
 **Kullanıcı Giriş Ekranı** </br>
<img width="422" alt="giriş" src="https://github.com/user-attachments/assets/f2a3bff0-5202-487b-9966-484ea9bcda2f">
<img width="394" alt="Giriş Ekranı" src="https://github.com/user-attachments/assets/85c2efd5-5d98-40c1-960e-ae4e5bc434a1"> </br>
*Yukarıdaki görseller proje başladığında ilk olarak karşılaştığımız ekranın görüntüleridir. Burada kişi kullanıcı adı ve şifresiyle birlikte giriş yapabilmektedir. Burada dikkat edilmesi gereken konu görevini boş bırakmamalı ve doğru görev adı seçilmelidir. Yanlış yapılan seçim işleminde uygulama hata vermektedir. Giriş yapan kullanıcılar için üç adet görev tipi vardır. Bunlar: Bakımcı, Stokçu ve Vardiya Amiri şeklindedir. Görsel 1’de yapılabilecek seçim işlemleri görülmektedir. Görsel 2 de ise kullanıcı girişi gösterilmektedir. ‘Mustafa’ kullanıcısı bakımcı olduğu için giriş işlemi başarılı bir şekilde gerçekleştirilmiştir.* </br> </br>

**Admin Giriş Ekranı** </br>
<img width="268" alt="Admin Giriş" src="https://github.com/user-attachments/assets/a95935c9-7742-4c21-b45b-9e4350d16381">
<img width="359" alt="admin" src="https://github.com/user-attachments/assets/9dd9f206-677f-4985-8ba9-24a6c305ae9b"> </br> 
*Yukarıdaki görseller uygulamaya admin olarak giriş yapmak isteyen kişini karşılaşacağı ekranları göstermektedir. İlk görselde admin kullanıcı adı ve şifresiyle birlikte giriş yapabilmektedir. Burada önemli olan nokta, admin yapmak istediği işlemi seçebilmektedir. Admin kullanıcısının seçebileceği üç adet seçenek mevcuttur. Bunlar: PC Bakımı, Log ve Zimmet şeklindedir. Admin seçtiği işlem sonrasında ilgili ekrana yönlendirilir.*</br> </br>


**Malzeme Kullanma Ekranı (Bakımcı & Vardiya Amiri)** </br>
<img width="506" alt="Bakımcı Ekranı I" src="https://github.com/user-attachments/assets/31de37bc-1928-4ff8-8572-ff3973553a62">
<img width="506" alt="Bakımcı Ekranı II" src="https://github.com/user-attachments/assets/8304c1e9-efd9-431c-b72f-6220e2abbd2c">
<img width="506" alt="Bakımcı Ekranı III" src="https://github.com/user-attachments/assets/5ce1bc7c-f94c-4a47-9d4a-97f990349ecb">
<img width="507" alt="Amir I" src="https://github.com/user-attachments/assets/fc19d584-d71b-4d91-b499-0cad1825abfd"> </br>
*Başarılı gerçekleşen giriş işleminden sonra bakımcı aşağıdaki ekranla karşılaşır. Burada
malzemeler(materiasl) tablosundaki veriler gözükmektedir. Bakımcı kullanacağı malzemeyle alakalı
bilgileri doğru bir şekilde girmelidir. Doğru bilgileri nasıl gireceği uyarı mesajında açıklanmıştır. Giriş yapabilecek bir diğer kullanıcı tipi de Vardiya Amiridir. Giriş işlemi başarılı bir şekilde
gerçekleştirildikten sonra Vardiya Amiri, Bakımcı ile aynı ekrana yönlendirilmektedir. Vardiya Amiri
aynı Bakımcı gibi malzeme alımını gerçekleştirmektedir. Log ekranında da ‘Vardiya Amiri Kullandı’
şeklinde kayıt tutulmaktadır.* </br> </br>


**Malzeme Ekleme Ekranı (Stokçu)** </br>
<img width="506" alt="Stokçu I" src="https://github.com/user-attachments/assets/aafea1b9-d0f1-44a9-9ef3-009865416d9e">
<img width="507" alt="Stokçu II" src="https://github.com/user-attachments/assets/51d130ba-d7d1-4c5c-9ec3-0eef17861c6c">
<img width="506" alt="Stokçu III" src="https://github.com/user-attachments/assets/c163f813-fb85-419e-adcb-a06975d5d298">
<img width="505" alt="Stokçu IV" src="https://github.com/user-attachments/assets/8936a9d6-bfd0-47c8-8f11-b7acfcd67157">
<img width="506" alt="Stokçu V" src="https://github.com/user-attachments/assets/4bf476a2-5e7f-4db9-99ac-22725ca7eb70"> </br>
*Stokçu olarak giriş yapan kullanıcı yukarıdaki ilk ile karşılaşmaktadır. Sol üst
tarafta giriş yapanın bilgileri bulunmaktadır. Bu ekranda da kullanıcı ‘materials’ tablosundaki verileri
görebilmektedir. Stokçuya işlemleri nasıl yapabileceği hakkında uyarı verilmiştir. Stokçu ikinci görselde
bulunan ‘Malzeme ID’ ve ‘Malzeme Stok Adedi’ bilgilerini girerek ‘materials’ tablosundaki verileri
güncelleyebilmektedir. Stokçu olarak giriş yapan kullanıcı aynı zamanda yeni bir malzeme ekleyebilmektedir.
Üçüncü görselde bulunan tüm bilgileri doğru bir şekilde girerek ‘materials’ tablosuna yeni veri girişi
yapmış olur. Yukarıdaki yenileme butonuna tıklanarak girişi yapılan malzemenin eklendiği
görülebilmektedir. Bu da dördüncü görselde gösterilmiştir. Stokçu olarak giriş yapan kullanıcı son olarak ‘materials’ tablosunda bulunan
malzemelerden birini silebilmektedir. Malzemeyi silebilmek için ‘Malzeme ID’ değerini girmesi yeterli
olacaktır. Son görselde bu işlem gösterilmiştir. Yenileme butonuna tıklayarak silme işinin
gerçekleştiğini görebilir. </br> </br>


**Log Ekranı** </br>
<img width="575" alt="Log Ekranı" src="https://github.com/user-attachments/assets/da073800-c790-4970-a8d9-4a52d53eee89"> </br>
*Admin olarak giriş yapan kullanıcının gidebileceği üç adet sayfa vardı. Bunlardan biri de log
ekranıdır. Admin bu ekranda malzemeler üzerindeki işlemleri görebilmektedir. Hangi kullanıcı hangi
malzemeyi hangi amaçla aldı bu bilgilere erişebilmektedir. Buradaki veriler ‘users’, ‘materials’ ve
‘usagelogs’ tablolarının birleştirilmesiyle gösterilmektedir. Buradaki karmaşık sorguyu tekrar tekrar
çalıştırmamak için bir view tanımlanmıştır. Bu sayede işlem daha basite indirilmiştir. Tablonun altında
bulunan filtrele butonu sayesinde tarih bilgisine göre filtreleme işlemi yapılabilmektedir.* </br> </br>


**Bilgisayar Bakım Ekranı** </br>
<img width="267" alt="PC ID SEÇ" src="https://github.com/user-attachments/assets/9a9a4343-51e8-4607-a18e-2a40782a2d62"> </br>
<img width="341" alt="PC Bakım Ekranı" src="https://github.com/user-attachments/assets/5b22cc50-da25-48bf-8e9e-ed3015722356"> </br>
<img width="340" alt="Pc Bakım Ekranı Uyarı Mesajı" src="https://github.com/user-attachments/assets/baa75448-31c8-4a4d-8ee2-1b1cb0215bb9"> </br>
*Admin kullanıcısının seçim yapabileceği bir diğer alan da bilgisayar bakım ekranıydı. PC
Bakım seçimi yapıldıktan sonra karşımıza ilk görseldeki ekran gelmektedir. Admin burada bilgisayar
id’sini doğru bir şekilde girdikten sonra bilgisayar bakım ekranına yönlendirilir. Bilgisayar id’sinin
doğru bir şekilde girilmesi önemlidir aksi taktirde hata alınır. Admin kullanıcısı doğru giriş yaptıktan sonra karşısına çıkacak ekran ikinci görselde
gösterilmiştir. Buradaki bilgiler de view’den gelmektedir (maintenanceview). Ekranda bilgisayarı
kullanan kişinin bilgileri ve bilgisayar bakım tarihi gösterilmektedir. Eğer bakım tarihine 5 günden az
kaldıysa üçüncü görselde görüldüğü gibi uyarı ışığı vermektedir. Bakım tamamlandıktan sonra butona
basılır ve yani bakım tarihi altı ay sonrası olacak şekilde ayarlanmış olur.* </br> </br>


**Zimmet Formları Ekranı** </br>
<img width="250" alt="Zimmet Girişi" src="https://github.com/user-attachments/assets/280d0190-2b5e-4092-aa65-23b1bc8cd8ad">
<img width="616" alt="Bilgisayar Zimmet Formu" src="https://github.com/user-attachments/assets/7616c274-128e-4216-ba4a-574571bb827b"> </br>
*Admin kullanıcısının erişebileceği son sayfa da zimmet formlarıyla alakalı işlemler
yapabileceği sayfadır. İlk görselde ofis çalışanlarının girişi gerçekleştirilerek veri tabanına kayıtları
yapılır. Eğer çalışan veri tabanına kayıtlı ise ve aynı kullanıcı eklenmek istenirse hata alınır. Yeni
çalışanın kaydı yapıldıktan sonra çalışan adına bir dosya oluşturulur. Oluşturulan dosyanın içerisine
ise hazır kullanılan bilgisayar zimmet formu Word dosyası ikinci görseldeki gibi) kopyalanır. Admin, buradan
kimin zimmet formu var ya da yok gibi bir çıkarımda bulunabilir.*
