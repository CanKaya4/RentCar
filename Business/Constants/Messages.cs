using Entities.Concrete;
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
        public static string CarGetAllByBrandListed="Markalara Göre Arabalar Listelendi";
        public static string CarGetByColor="Renklere Göre Arabalar Listelendi";
        public static string CarGetByIdListed="Arabalar Id'ye Göre Listelendi";
        public static string CarGetByUnitPriceListed="Fiyatlara Göre Arabalar Listelendi";
        public static string CarGetCarDetailsListed="Arabanın Detayları Listelendi";
        public static string MaintenanceTime = "Sistem Bakım Saati.";
        internal static string CustomerAdded="Müşteri Eklendi";
        internal static string CustomerListed ="Müşteri Listelendi";
        internal static string CompanyNameInValid="Şirket İsmi 5'den Büyük Olmalıdır.";
        internal static string RentalAdded;
        internal static string RentalReturnDateNull;
        internal static string RentalDeleted;
        internal static string RentalCarById;
    }
}
