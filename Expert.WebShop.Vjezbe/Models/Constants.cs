﻿namespace Expert.WebShop.Vjezbe.Models
{
    public static class Constants
    {
#if DEBUG

        // static readonly string BaseUrl = "https://localhost:7005/api";
        public static readonly string BaseUrl = "https://expertshopapi.azurewebsites.net/api";

#else
        public static readonly string BaseUrl = "https://expertshopapi.azurewebsites.net/api";
#endif
        public static readonly string ErrorMessage = "Ups! Ima neka greška";
    }
}