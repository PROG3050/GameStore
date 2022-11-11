﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace GameStore.Models.ExtensionModels
{
    public static class SessionExtensionMethods
    {
        public static void SetObject<T>(this ISession session, string key, T value) =>
            session.SetString(key, JsonConvert.SerializeObject(value));

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
