using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ReCap.Business.Constants
{
    public static class Messages
    {
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Araba listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CarInUse = "Araba kirada";
        public static string CarRentable = "Araç kiralandı";
        public static string UserAdded = "Araç eklendi";
        public static string UserDeleted = "Araç silindi";
        public static string UserListed = "Araçlar listelendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageMaximum = "Araba resim sayısı en fazla 5 olabilir";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kaydoldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
