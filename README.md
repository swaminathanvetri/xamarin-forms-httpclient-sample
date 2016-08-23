# xamarin-forms-httpclient-sample
Xamarin forms app using HttpClient package to invoke REST services

This repo contains the following projects

1. HttpClientDemo.csproj -> PCL for Xamarin Forms
2. HttpClientDemo.iOS.csproj -> Xamarin.Forms iOS project
3. HttpClientDemo.Droid.csproj -> Xamarin.Forms Android project
4. Todo-Web-Api -> Aspnet.core based web api

##Prerequisites

### Mac
1. Xamarin Studio - to run the xamarin forms app
2. dotnet core - to run the web api 

## Windows
1. Visual Studio - to run the Xamarin forms app
2. dotnet core - to run the web api

## Running the Web API

Make sure dotnet cli is installed, this can be done by running the below command

`dotnet --info`
Execute the below commands from the root folder **Todo-Web-Api** to run the web api

`dotnet restore`

`dotnet run`

The app should run under the port `5000`

## Running the Xamarin.Forms app

Open the solution `HttpClientDemo.sln` and build the solution in Xamarin Studio/Visual Studio
Set the iOS/Droid project as starup and run in the appropriate simulator/emulator
