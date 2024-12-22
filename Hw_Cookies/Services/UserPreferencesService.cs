using Hw_Cookies.Interfaces;
using Hw_Cookies.Models;
using System.Text.Json;

namespace Hw_Cookies.Services
{
	public class UserPreferencesService: IUserPreference
	{
		public Preference? GetUserPreferences(string key, HttpContext httpContext)
		{
			Preference? preference = null;
			if(httpContext.Request.Cookies.ContainsKey(key))
			{
				string value = httpContext.Request.Cookies[key];
				return JsonSerializer.Deserialize<Preference>(value);
			}
			return null;

		}
		public void SetUserPreferences(string key, HttpContext httpContext, Preference preference)
		{
			string value = JsonSerializer.Serialize< Preference>(preference);
			httpContext.Response.Cookies.Append(key, value);
		}
	}
}
