﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDesciptionInValid = "Araba açıklaması Geçersiz";
        public static string CarGetAllListed = "Tüm Arabalar Listelendi.";
        public static string CarGetAllByBrandListed = "Markalara Göre Arabalar Listelendi";
        public static string CarGetByColor = "Renklere Göre Arabalar Listelendi";
        public static string CarGetByIdListed = "Arabalar Id'ye Göre Listelendi";
        public static string CarGetByUnitPriceListed = "Fiyatlara Göre Arabalar Listelendi";
        public static string CarGetCarDetailsListed = "Arabanın Detayları Listelendi";
        public static string MaintenanceTime = "Sistem Bakım Saati.";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CompanyNameInValid = "Şirket İsmi 5'den Büyük Olmalıdır.";
        public static string RentalAdded = "Araba Eklendi";
        public static string RentalReturnDateNull = "Araba Tarihi Geçersiz";
        public static string RentalDeleted = "Araba Silindi";
        public static string RentalCarById = "Id'ye Göre Araba Getirildi";
        public static string UserNameInValid = "Kullanıcı İsmi Geçersiz";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserIdListed = "Kullancı Id'ye Göre Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";
        internal static string ColorsListed="Renkler Listelendi";
        internal static string BrandsListed="Markalar Listelendi.";
        internal static string UserAdded="Kullanıcı Başarıyla Eklendi";
        internal static string CustomerIdListed="Müşteri Id'ye Göre Listelendi";
        internal static string RentalListed="Kiralamalar Listelendi";
    }
}
