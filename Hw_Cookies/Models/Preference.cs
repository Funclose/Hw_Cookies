namespace Hw_Cookies.Models
{
	public class Preference
	{
		public string BackGroundColor { get; set; }
		public string FrontColor
		{ 
			get
			{
				switch (BackGroundColor)
				{
					case "Orange" or "Black" or "Blue": { return "White"; }
					default: { return "Black"; }
				}
			}
		}
	}
}
