using System.Text.Json;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string
       key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T GetObjectFromJson<T>(this ISession session,
       string key)
        {
            var value = session.GetString(key);
            return value == null ? default :
           JsonSerializer.Deserialize<T>(value);
        }
    }

}
