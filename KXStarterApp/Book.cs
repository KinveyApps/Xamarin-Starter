using Newtonsoft.Json;
using KinveyXamarin;

namespace KXStarterApp
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Book : Entity
	{
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("genre")]
		public string Genre { get; set; }

		[JsonProperty("publish_date")]
		public string PublishDate { get; set; }
	}
}
