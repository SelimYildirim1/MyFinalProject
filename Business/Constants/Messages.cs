using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriye en fazla 10 ürün ekleyebilirsin";
        internal static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
