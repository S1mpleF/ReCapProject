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
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string AddError = "Ekleme Başarısız Oldu";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarDetails = "Araba Detayları Listelendi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandListed = "Markalar Listelendi";
        public static string BrandError = "Marka Eklenemedi";
        public static string BrandUpdateError = "Marka Güncellenemedi";


        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorAddError = "Renk Eklenemedi";

        public static string MaintenanceTime = "Sistem Şuan Bakımda.";
     
    }
}
