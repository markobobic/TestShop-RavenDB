using Newtonsoft.Json;

namespace TestShop_RavenDB.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static T Clone<T>(this T theObject)
        {
            string jsonData = JsonConvert.SerializeObject(theObject);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }
}
