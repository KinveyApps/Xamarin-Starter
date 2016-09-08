# Xamarin-Starter
A Kinvey starter application built on the Xamarin v3.0 SDK.

_Note: This starter app uses the [Kinvey Xamarin v3 Library](http://devcenter.kinvey.com/xamarin-v3.0)._

## Features

* Login a user.
* Save a book and push/pull/sync from Kinvey backend.

## Setup

1. Create an app backend using the [console](http://console.kinvey.com) for your application.
2. Create a user (with password) using the [console](http://console.kinvey.com) for your application.
3. Clone the repo.
4. Open `KXStarterApp.sln` in Xamarin Studio.
5. Set either KXStarterApp.iOS or KXStarterApp.Droid as startup project, depending on desired platform.
6. Assign the App ID and App Secret from the created backend to the `app_key` and `app_secret` variables in `KXStarterAppPage.xaml.cs`.
7. Assign the username and password of the created user to the `user` and `pass` variables in `KXStarterAppPage.xaml.cs`.
8. Build entire solution.

## Run

By default, the type of data store created for the `books` collection is `DataStoreType.SYNC`.  In order to demonstrate this sync store capabilities, follow these steps:

1. Run app in Xamarin Studio to target desired simulator/emulator.
2. Click on the `Add Book` button.
3. Look at the [console](http://console.kinvey.com) data browser and notice that there is no book there.
4. Click the `Sync` button
5. Look again at the data browser in the console, and you should see one book added.

## License

Copyright (c) 2016 Kinvey Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
in compliance with the License. You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in
writing, software distributed under the License
is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
or implied. See the License for the specific language governing permissions and limitations under
the License.