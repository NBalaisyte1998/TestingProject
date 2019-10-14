# WeatherApiTestingProject
This is a repository for a one day project at Sparta Global during which we had to write unit tests for a Weather API( OpenWeatherMap.org   ).


# General information
The project required using particular NuGets and software which will be defined in more depth in the prerequisites. In addition, the special environment had to be set for the testing which will be explained step-by-step in the setup section.


# Prerequisites
Postman

Gitbash 

Visual Studio 2019

Newtonsoft.Json

NUnit

NUnit3TestAdapter 

RestSharp


# Set Up for the tests

1) Clone this git repository https://github.com/NBalaisyte1998/TestingProject.git 

2)Open WeatherProject.sln

3)Build the project by clicking on Build -> Build Solution on the menu

4)Click on View -> Solution Explorer or press Ctrl+Alt+L to view the Solution Explorer

5)Right click on the 'WeatherAppTests' Project file in the Solution Explorer and click 'Manage NuGet Packages..."

6)Update NuGet packages/Check that all the packages are installed and updated (see parerequisites above)

7)Click on Test -> Windows -> Test Explorer to view the test window

8)Click on the green Run All button to execute all tests or Run button to execute selected tests in the Test Explorer


# Implementation

## WeatherAppService
The WeatherAppService class is a class that creates instances of the data handling and http manager classes acting as an entry point for access.
The service will call the DeserializeForecast method in the DTO in order to deserialize the JSON response received from the CallManager
## WeatherAppManager
Creates a new REST client to make requests to the API and return the response that is deserialized by the WeatherAppDTO class.
To create the request, data is retrieved from the OpenWeatherMapConfig class which reads from the app settings in the App.config file


