using System.Text.Json;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetTAsync<T>(this HttpResponseMessage response) {

            if (!response.IsSuccessStatusCode) throw new ApplicationException($"Something went wrong calling the API: " +
                $"{response.ReasonPhrase}");

            var dataAsStrting = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsStrting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
