using Xamarin.Forms;
using SQLite.Net.Platform.XamarinIOS;
using Foundation;

[assembly: Dependency(typeof(SQLite_iOS))]
// ...
public class SQLite_iOS : KXStarterApp.ISQLite
{
	public SQLite_iOS() { }
	public SQLite.Net.Interop.ISQLitePlatform GetConnection()
	{
		return new SQLitePlatformIOS();
	}

	public string GetPath()
	{
		return NSFileManager
			.DefaultManager
			.GetUrls(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User)[0]
			.ToString();
	}
}
