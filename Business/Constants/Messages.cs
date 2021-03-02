using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi gerçekleşti";
        public static string Deleted = "Silme işlemi gerçekleşti";
        public static string Updated = "Güncelleme işlemi gerçekleşti";
        public static string UpdatedFailed = "Güncelleme işlemi gerçekleştirilmedi";
        public static string Rented = "Kiralama gerçekleşti";
        public static string RentOff = "Sözleşme iptal edildi";
        public static string RentUpdate = "Sözleşme güncellendi";
        public static string RentList = "Sözleşmeler Listelendi";
        public static string RentGet = "Sözleşme Getirildi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string ReturnDateNull = "Araba mevcut değil";
        public static string ColorsListed = "Renkler listelendi";
        public static string CantAdded = "Ekleme başarısız";
        public static string CarsListed = "Arabalar listelendi";
        public static string ColorAddInvalid = "Var olan Renk eklenemez";
        public static string BrandAddInvalid = "Var olan Marka eklenemez";
        public static string MaintenanceTime = "Bakım Zamanı!\nSize daha iyi bir hizmet verebilmek için çalışmalarımız devam ediyor...";
        public static string CarImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir.";
        public static string AuthorizationDenied = "Yetkiniz yoktur";
        public static string UserRegistered = "Kayıtlı başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş Token oluşturuldu";
    }
}
