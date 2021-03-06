﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaglikOcagi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SOHTSEntities : DbContext
    {
        public SOHTSEntities()
            : base("name=SOHTSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hasta> hasta { get; set; }
        public virtual DbSet<poliklinik> poliklinik { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<cikis> cikis { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<sevk> sevk { get; set; }
    
        public virtual int hasta_bilgileri_update(Nullable<int> dosyaNo, string ad, string soyad, string dogumYeri, Nullable<System.DateTime> dogumTarihi, string babaAd, string anneAd, string cinsiyet, string kanGrubu, string telNo, string adres, string yakinAdres, string krumScilNo, string krumAd, string yakinTelNo, string yakinKurumSicilNo, string yakinKurumAd, string tC, string medeniHal)
        {
            var dosyaNoParameter = dosyaNo.HasValue ?
                new ObjectParameter("DosyaNo", dosyaNo) :
                new ObjectParameter("DosyaNo", typeof(int));
    
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var dogumYeriParameter = dogumYeri != null ?
                new ObjectParameter("DogumYeri", dogumYeri) :
                new ObjectParameter("DogumYeri", typeof(string));
    
            var dogumTarihiParameter = dogumTarihi.HasValue ?
                new ObjectParameter("DogumTarihi", dogumTarihi) :
                new ObjectParameter("DogumTarihi", typeof(System.DateTime));
    
            var babaAdParameter = babaAd != null ?
                new ObjectParameter("BabaAd", babaAd) :
                new ObjectParameter("BabaAd", typeof(string));
    
            var anneAdParameter = anneAd != null ?
                new ObjectParameter("AnneAd", anneAd) :
                new ObjectParameter("AnneAd", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var kanGrubuParameter = kanGrubu != null ?
                new ObjectParameter("KanGrubu", kanGrubu) :
                new ObjectParameter("KanGrubu", typeof(string));
    
            var telNoParameter = telNo != null ?
                new ObjectParameter("telNo", telNo) :
                new ObjectParameter("telNo", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var yakinAdresParameter = yakinAdres != null ?
                new ObjectParameter("yakinAdres", yakinAdres) :
                new ObjectParameter("yakinAdres", typeof(string));
    
            var krumScilNoParameter = krumScilNo != null ?
                new ObjectParameter("KrumScilNo", krumScilNo) :
                new ObjectParameter("KrumScilNo", typeof(string));
    
            var krumAdParameter = krumAd != null ?
                new ObjectParameter("KrumAd", krumAd) :
                new ObjectParameter("KrumAd", typeof(string));
    
            var yakinTelNoParameter = yakinTelNo != null ?
                new ObjectParameter("YakinTelNo", yakinTelNo) :
                new ObjectParameter("YakinTelNo", typeof(string));
    
            var yakinKurumSicilNoParameter = yakinKurumSicilNo != null ?
                new ObjectParameter("YakinKurumSicilNo", yakinKurumSicilNo) :
                new ObjectParameter("YakinKurumSicilNo", typeof(string));
    
            var yakinKurumAdParameter = yakinKurumAd != null ?
                new ObjectParameter("YakinKurumAd", yakinKurumAd) :
                new ObjectParameter("YakinKurumAd", typeof(string));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var medeniHalParameter = medeniHal != null ?
                new ObjectParameter("MedeniHal", medeniHal) :
                new ObjectParameter("MedeniHal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("hasta_bilgileri_update", dosyaNoParameter, adParameter, soyadParameter, dogumYeriParameter, dogumTarihiParameter, babaAdParameter, anneAdParameter, cinsiyetParameter, kanGrubuParameter, telNoParameter, adresParameter, yakinAdresParameter, krumScilNoParameter, krumAdParameter, yakinTelNoParameter, yakinKurumSicilNoParameter, yakinKurumAdParameter, tCParameter, medeniHalParameter);
        }
    
        public virtual int hasta_cikis_veri_kayit(Nullable<int> dosya_no, Nullable<System.DateTime> sevk_tarih, Nullable<System.DateTime> cikis_tarihi, string odeme_sekli, string toplam_tutar, string taburcu)
        {
            var dosya_noParameter = dosya_no.HasValue ?
                new ObjectParameter("dosya_no", dosya_no) :
                new ObjectParameter("dosya_no", typeof(int));
    
            var sevk_tarihParameter = sevk_tarih.HasValue ?
                new ObjectParameter("sevk_tarih", sevk_tarih) :
                new ObjectParameter("sevk_tarih", typeof(System.DateTime));
    
            var cikis_tarihiParameter = cikis_tarihi.HasValue ?
                new ObjectParameter("cikis_tarihi", cikis_tarihi) :
                new ObjectParameter("cikis_tarihi", typeof(System.DateTime));
    
            var odeme_sekliParameter = odeme_sekli != null ?
                new ObjectParameter("odeme_sekli", odeme_sekli) :
                new ObjectParameter("odeme_sekli", typeof(string));
    
            var toplam_tutarParameter = toplam_tutar != null ?
                new ObjectParameter("toplam_tutar", toplam_tutar) :
                new ObjectParameter("toplam_tutar", typeof(string));
    
            var taburcuParameter = taburcu != null ?
                new ObjectParameter("taburcu", taburcu) :
                new ObjectParameter("taburcu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("hasta_cikis_veri_kayit", dosya_noParameter, sevk_tarihParameter, cikis_tarihiParameter, odeme_sekliParameter, toplam_tutarParameter, taburcuParameter);
        }
    
        public virtual int hasta_islemleri_secileni_sil(Nullable<int> dosyaNo, string poliklinik, string saat, string yapilanislem, string doktorKod, string miktar, string birimFiyat, string sira)
        {
            var dosyaNoParameter = dosyaNo.HasValue ?
                new ObjectParameter("dosyaNo", dosyaNo) :
                new ObjectParameter("dosyaNo", typeof(int));
    
            var poliklinikParameter = poliklinik != null ?
                new ObjectParameter("poliklinik", poliklinik) :
                new ObjectParameter("poliklinik", typeof(string));
    
            var saatParameter = saat != null ?
                new ObjectParameter("saat", saat) :
                new ObjectParameter("saat", typeof(string));
    
            var yapilanislemParameter = yapilanislem != null ?
                new ObjectParameter("yapilanislem", yapilanislem) :
                new ObjectParameter("yapilanislem", typeof(string));
    
            var doktorKodParameter = doktorKod != null ?
                new ObjectParameter("doktorKod", doktorKod) :
                new ObjectParameter("doktorKod", typeof(string));
    
            var miktarParameter = miktar != null ?
                new ObjectParameter("miktar", miktar) :
                new ObjectParameter("miktar", typeof(string));
    
            var birimFiyatParameter = birimFiyat != null ?
                new ObjectParameter("birimFiyat", birimFiyat) :
                new ObjectParameter("birimFiyat", typeof(string));
    
            var siraParameter = sira != null ?
                new ObjectParameter("sira", sira) :
                new ObjectParameter("sira", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("hasta_islemleri_secileni_sil", dosyaNoParameter, poliklinikParameter, saatParameter, yapilanislemParameter, doktorKodParameter, miktarParameter, birimFiyatParameter, siraParameter);
        }
    
        public virtual int hasta_islemleri_secileni_sil_V2(Nullable<int> dosyaNo, string poliklinik, string saat)
        {
            var dosyaNoParameter = dosyaNo.HasValue ?
                new ObjectParameter("dosyaNo", dosyaNo) :
                new ObjectParameter("dosyaNo", typeof(int));
    
            var poliklinikParameter = poliklinik != null ?
                new ObjectParameter("poliklinik", poliklinik) :
                new ObjectParameter("poliklinik", typeof(string));
    
            var saatParameter = saat != null ?
                new ObjectParameter("saat", saat) :
                new ObjectParameter("saat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("hasta_islemleri_secileni_sil_V2", dosyaNoParameter, poliklinikParameter, saatParameter);
        }
    
        public virtual int kullanici_kullaniciSil(string kullaniciKod)
        {
            var kullaniciKodParameter = kullaniciKod != null ?
                new ObjectParameter("KullaniciKod", kullaniciKod) :
                new ObjectParameter("KullaniciKod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kullanici_kullaniciSil", kullaniciKodParameter);
        }
    
        public virtual int kullanici_tanitma_update_islem(Nullable<int> kullaniciKod, Nullable<int> tC, string dogumYeri, string babaAd, string anneAd, string cepTel, string evTel, string ad, string soyad, string maas, Nullable<System.DateTime> isBaslama, Nullable<System.DateTime> dogumTarihi, string cinsiyet, string medeniHal, string kanGrubu, string unvan, string adres, string userName, string sifreKullanici, string yetki_durumu)
        {
            var kullaniciKodParameter = kullaniciKod.HasValue ?
                new ObjectParameter("KullaniciKod", kullaniciKod) :
                new ObjectParameter("KullaniciKod", typeof(int));
    
            var tCParameter = tC.HasValue ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(int));
    
            var dogumYeriParameter = dogumYeri != null ?
                new ObjectParameter("DogumYeri", dogumYeri) :
                new ObjectParameter("DogumYeri", typeof(string));
    
            var babaAdParameter = babaAd != null ?
                new ObjectParameter("BabaAd", babaAd) :
                new ObjectParameter("BabaAd", typeof(string));
    
            var anneAdParameter = anneAd != null ?
                new ObjectParameter("AnneAd", anneAd) :
                new ObjectParameter("AnneAd", typeof(string));
    
            var cepTelParameter = cepTel != null ?
                new ObjectParameter("CepTel", cepTel) :
                new ObjectParameter("CepTel", typeof(string));
    
            var evTelParameter = evTel != null ?
                new ObjectParameter("EvTel", evTel) :
                new ObjectParameter("EvTel", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var maasParameter = maas != null ?
                new ObjectParameter("Maas", maas) :
                new ObjectParameter("Maas", typeof(string));
    
            var isBaslamaParameter = isBaslama.HasValue ?
                new ObjectParameter("isBaslama", isBaslama) :
                new ObjectParameter("isBaslama", typeof(System.DateTime));
    
            var dogumTarihiParameter = dogumTarihi.HasValue ?
                new ObjectParameter("DogumTarihi", dogumTarihi) :
                new ObjectParameter("DogumTarihi", typeof(System.DateTime));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var medeniHalParameter = medeniHal != null ?
                new ObjectParameter("MedeniHal", medeniHal) :
                new ObjectParameter("MedeniHal", typeof(string));
    
            var kanGrubuParameter = kanGrubu != null ?
                new ObjectParameter("KanGrubu", kanGrubu) :
                new ObjectParameter("KanGrubu", typeof(string));
    
            var unvanParameter = unvan != null ?
                new ObjectParameter("Unvan", unvan) :
                new ObjectParameter("Unvan", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var sifreKullaniciParameter = sifreKullanici != null ?
                new ObjectParameter("SifreKullanici", sifreKullanici) :
                new ObjectParameter("SifreKullanici", typeof(string));
    
            var yetki_durumuParameter = yetki_durumu != null ?
                new ObjectParameter("yetki_durumu", yetki_durumu) :
                new ObjectParameter("yetki_durumu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kullanici_tanitma_update_islem", kullaniciKodParameter, tCParameter, dogumYeriParameter, babaAdParameter, anneAdParameter, cepTelParameter, evTelParameter, adParameter, soyadParameter, maasParameter, isBaslamaParameter, dogumTarihiParameter, cinsiyetParameter, medeniHalParameter, kanGrubuParameter, unvanParameter, adresParameter, userNameParameter, sifreKullaniciParameter, yetki_durumuParameter);
        }
    
        public virtual int poliklinik_sil(string poliklinikAd)
        {
            var poliklinikAdParameter = poliklinikAd != null ?
                new ObjectParameter("PoliklinikAd", poliklinikAd) :
                new ObjectParameter("PoliklinikAd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("poliklinik_sil", poliklinikAdParameter);
        }
    
        public virtual int poliklinik_update(string aciklama, string durum, string poliklinik)
        {
            var aciklamaParameter = aciklama != null ?
                new ObjectParameter("Aciklama", aciklama) :
                new ObjectParameter("Aciklama", typeof(string));
    
            var durumParameter = durum != null ?
                new ObjectParameter("Durum", durum) :
                new ObjectParameter("Durum", typeof(string));
    
            var poliklinikParameter = poliklinik != null ?
                new ObjectParameter("Poliklinik", poliklinik) :
                new ObjectParameter("Poliklinik", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("poliklinik_update", aciklamaParameter, durumParameter, poliklinikParameter);
        }
    
        public virtual int sevk_veri_ekleme_v2(Nullable<System.DateTime> sevk_tarih, Nullable<int> dosyaNo, string poliklinik, string saat, string yapilanislem, string doktorKod, string miktar, string birimFiyat, string sira, string toplamTutar, string taburcu)
        {
            var sevk_tarihParameter = sevk_tarih.HasValue ?
                new ObjectParameter("sevk_tarih", sevk_tarih) :
                new ObjectParameter("sevk_tarih", typeof(System.DateTime));
    
            var dosyaNoParameter = dosyaNo.HasValue ?
                new ObjectParameter("dosyaNo", dosyaNo) :
                new ObjectParameter("dosyaNo", typeof(int));
    
            var poliklinikParameter = poliklinik != null ?
                new ObjectParameter("poliklinik", poliklinik) :
                new ObjectParameter("poliklinik", typeof(string));
    
            var saatParameter = saat != null ?
                new ObjectParameter("saat", saat) :
                new ObjectParameter("saat", typeof(string));
    
            var yapilanislemParameter = yapilanislem != null ?
                new ObjectParameter("yapilanislem", yapilanislem) :
                new ObjectParameter("yapilanislem", typeof(string));
    
            var doktorKodParameter = doktorKod != null ?
                new ObjectParameter("doktorKod", doktorKod) :
                new ObjectParameter("doktorKod", typeof(string));
    
            var miktarParameter = miktar != null ?
                new ObjectParameter("miktar", miktar) :
                new ObjectParameter("miktar", typeof(string));
    
            var birimFiyatParameter = birimFiyat != null ?
                new ObjectParameter("birimFiyat", birimFiyat) :
                new ObjectParameter("birimFiyat", typeof(string));
    
            var siraParameter = sira != null ?
                new ObjectParameter("sira", sira) :
                new ObjectParameter("sira", typeof(string));
    
            var toplamTutarParameter = toplamTutar != null ?
                new ObjectParameter("toplamTutar", toplamTutar) :
                new ObjectParameter("toplamTutar", typeof(string));
    
            var taburcuParameter = taburcu != null ?
                new ObjectParameter("taburcu", taburcu) :
                new ObjectParameter("taburcu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sevk_veri_ekleme_v2", sevk_tarihParameter, dosyaNoParameter, poliklinikParameter, saatParameter, yapilanislemParameter, doktorKodParameter, miktarParameter, birimFiyatParameter, siraParameter, toplamTutarParameter, taburcuParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int yeni_hasta_kayit(string ad, string soyad, string dogumYeri, Nullable<System.DateTime> dogumTarihi, string babaAd, string anneAd, string cinsiyet, string kanGrubu, string telNo, string adres, string yakinAdres, string krumScilNo, string krumAd, string yakinTelNo, string yakinKurumSicilNo, string yakinKurumAd, string tC, string medeniHal)
        {
            var adParameter = ad != null ?
                new ObjectParameter("Ad", ad) :
                new ObjectParameter("Ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("Soyad", soyad) :
                new ObjectParameter("Soyad", typeof(string));
    
            var dogumYeriParameter = dogumYeri != null ?
                new ObjectParameter("DogumYeri", dogumYeri) :
                new ObjectParameter("DogumYeri", typeof(string));
    
            var dogumTarihiParameter = dogumTarihi.HasValue ?
                new ObjectParameter("DogumTarihi", dogumTarihi) :
                new ObjectParameter("DogumTarihi", typeof(System.DateTime));
    
            var babaAdParameter = babaAd != null ?
                new ObjectParameter("BabaAd", babaAd) :
                new ObjectParameter("BabaAd", typeof(string));
    
            var anneAdParameter = anneAd != null ?
                new ObjectParameter("AnneAd", anneAd) :
                new ObjectParameter("AnneAd", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var kanGrubuParameter = kanGrubu != null ?
                new ObjectParameter("KanGrubu", kanGrubu) :
                new ObjectParameter("KanGrubu", typeof(string));
    
            var telNoParameter = telNo != null ?
                new ObjectParameter("telNo", telNo) :
                new ObjectParameter("telNo", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var yakinAdresParameter = yakinAdres != null ?
                new ObjectParameter("yakinAdres", yakinAdres) :
                new ObjectParameter("yakinAdres", typeof(string));
    
            var krumScilNoParameter = krumScilNo != null ?
                new ObjectParameter("KrumScilNo", krumScilNo) :
                new ObjectParameter("KrumScilNo", typeof(string));
    
            var krumAdParameter = krumAd != null ?
                new ObjectParameter("KrumAd", krumAd) :
                new ObjectParameter("KrumAd", typeof(string));
    
            var yakinTelNoParameter = yakinTelNo != null ?
                new ObjectParameter("YakinTelNo", yakinTelNo) :
                new ObjectParameter("YakinTelNo", typeof(string));
    
            var yakinKurumSicilNoParameter = yakinKurumSicilNo != null ?
                new ObjectParameter("YakinKurumSicilNo", yakinKurumSicilNo) :
                new ObjectParameter("YakinKurumSicilNo", typeof(string));
    
            var yakinKurumAdParameter = yakinKurumAd != null ?
                new ObjectParameter("YakinKurumAd", yakinKurumAd) :
                new ObjectParameter("YakinKurumAd", typeof(string));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var medeniHalParameter = medeniHal != null ?
                new ObjectParameter("MedeniHal", medeniHal) :
                new ObjectParameter("MedeniHal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("yeni_hasta_kayit", adParameter, soyadParameter, dogumYeriParameter, dogumTarihiParameter, babaAdParameter, anneAdParameter, cinsiyetParameter, kanGrubuParameter, telNoParameter, adresParameter, yakinAdresParameter, krumScilNoParameter, krumAdParameter, yakinTelNoParameter, yakinKurumSicilNoParameter, yakinKurumAdParameter, tCParameter, medeniHalParameter);
        }
    }
}
