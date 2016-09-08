# Xamarin-Starter
A Kinvey starter application built on the Xamarin v3.0 SDK.

_Note: This starter app uses the [Kinvey Xamarin v3 Library](http://devcenter.kinvey.com/xamarin-v3.0)._

## Features

* Login a user.
* Save a book and push/pull/sync from Kinvey backend.

## Setup

1. Clone the repo.
2. Open `KXStarterApp.sln` in Xamarin Studio.
3. Set either KXStarterApp.iOS or KXStarterApp.Droid as startup project, depending on desired platform.
4. Build entire solution.
5. Create a user using the [console](http://console.kinvey.com) for your application.
6. Change `<app-key>` and `<app-secret>` in `KXStarterAppPage.xaml.cs`.

## Run

1. Run app in Xamarin Studio to target desired simulator/emulator.


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