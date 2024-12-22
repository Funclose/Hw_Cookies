using Hw_Cookies.Models;

namespace Hw_Cookies.Interfaces
{
	public interface IUserPreference
	{
		public Preference GetUserPreferences(string key, HttpContext httpContext);
		public void SetUserPreferences(string key, HttpContext httpContext, Preference preference);
	}
}
