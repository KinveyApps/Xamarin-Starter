using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KinveyXamarin;

namespace KXStarterApp
{
	public partial class KXStarterAppPage : ContentPage
	{
		private string app_key = "";
		private string app_secret = "";
		private string user = "";
		private string pass = "";

		public KXStarterAppPage()
		{
			InitializeComponent();
			try
			{
				BuildClient();
			}
			catch (Exception e)
			{
				DisplayAlert("General Exception", e.Message, "OK");
			}
		}

		private async Task<Client> BuildClient()
		{
			Client.Builder cb = new Client.Builder(app_key, app_secret)
				//.setFilePath (NSFileManager.DefaultManager.GetUrls (NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User) [0].ToString ())
				.setFilePath(DependencyService.Get<ISQLite>().GetPath())
				.setOfflinePlatform(DependencyService.Get<ISQLite>().GetConnection());
				//.setLogger (delegate (string msg) { Console.WriteLine (msg); })

			return await cb.Build();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			try
			{
				if (!Client.SharedClient.IsUserLoggedIn())
				{
					await User.LoginAsync(user, pass);
				}

				DataStore<Book> dataStore = DataStore<Book>.Collection("books", DataStoreType.SYNC);

				Button button = (Button)sender;

				if (button.Text == "Add Book")
				{
					Book b = new Book();
					b.Title = "Crime and Punishment";
					b.Genre = "Fiction";
					await dataStore.SaveAsync(b);

					await DisplayAlert("Book Added!",
										"The button labeled '" + button.Text + "' has been clicked, and the book '" + b.Title + "' has been added.",
										"OK");
				}
				else if (button.Text == "Push")
				{
					DataStoreResponse dsr = await dataStore.PushAsync();
					await DisplayAlert("Local Data Pushed!",
										"The button labeled '" + button.Text + "' has been clicked, and " + dsr.Count + " book(s) has/have been pushed to Kinvey.",
										"OK");
				}
				else if (button.Text == "Pull")
				{
					List<Book> books = await dataStore.PullAsync();
					await DisplayAlert("Local Data Pulled!",
										"The button labeled '" + button.Text + "' has been clicked, and " + books.Count + " book(s) has/have been pulled from Kinvey.",
										"OK");
				}
				else if (button.Text == "Sync")
				{
					DataStoreResponse dsr = await dataStore.SyncAsync();
					await DisplayAlert("Local Data Synced!",
										"The button labeled '" + button.Text + "' has been clicked, and " + dsr.Count + " book(s) has/have been synced with Kinvey.",
										"OK");
				}
			}
			catch (KinveyException ke)
			{
				await DisplayAlert("Kinvey Exception",
				                   ke.Error + " | " + ke.Description + " | " + ke.Debug,
								   "OK");
			}
			catch (Exception e)
			{
				await DisplayAlert("General Exception",
								   e.Message,
								   "OK");
			}
		}
	}

	public interface ISQLite
	{
		SQLite.Net.Interop.ISQLitePlatform GetConnection();
		string GetPath();
	}
}

