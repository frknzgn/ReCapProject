using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç veri tabanına eklendi.";
        public static string CarNameInvalid = "Araç ismi 5 karakterden fazla olmalı.";
        public static string CarListed = "Araç listelendi.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarDeleted = "Araç veri tabanından silindi.";
        public static string CarUpdated = "Araç Güncellendi.";
        public static string AddSuccess = "Ekleme İşlemi başarılı";
        public static string UpdateSuccess = "Güncelleme başarılı";
        public static string DeleteSuccess = "Silme işlemi başarılı";
        public static string ListSuccess = "Listeleme Başarılı";
        public static string DontAvailable = "Araç kiralanmak müsait değil.";
        public static string UserNotFound = "Kullanıcı Bulunamdı.";
        public static string PasswordError = "Parola Hatası";
        public static string LoginSuccess = "Başarılı Giriş.";
        public static string UserExists = "Kullanıcı Mevcut";
        public static string AvailableUser = "Kullanıcı mevcut Değil";
        public static string UserRegistered = "Kullanıcı Başarıyla Eklendi.";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
        public static string CarImageLimitExceded = "Daha fazla resim yükleyemezsiniz";
        public static string NoCarImages = "Araç resmi yok ";
        public static string AuthorizationDenied = "Yetkiniz yok ";
    }
}
