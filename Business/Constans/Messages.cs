using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductnameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductListed="ürünler listelendi";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenmiyor";

        public static SerializationInfo AuthorizationDenied { get; internal set; }
    }
}
