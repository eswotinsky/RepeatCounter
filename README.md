# Repeat Counter (C#)

A web app, built with C#, that allows users to enter two text strings and search for instances of the first within the second, returning the number found. This project was completed to satisfy the C# Week 2 Independent Code Review at [Epicodus](https://www.epicodus.com) in Seattle, WA.

## Installation

1. Install .NET, if not already present on your local machine.

2. Clone this repository.

3. In your preferred shell, navigate to the RepeatCounters folder and run the following commands:

 ```
 $ dotnet restore
 ```
(above not required for .NET Core 2.0 SDK or newer releases)

 ```
 $ dotnet run
 ```

4. Navigate to localhost:5000 in your preferred browser.

## Specifications

1. App routes users to the home page, which displays a form with two fields for entering text and a submit button.

2. When submitted, the form stores the input data from both fields. If both fields contain data, a new display area is created, showing user the number of times that the string entered in the first field was contained within the string entered in the second field.
    1. Example Input: "dog", "She took her dog for a walk, and they visited the dog park".
    2. Example Output: Your word appears 2 times.

3. If one or both fields contains no data when the form is submitted, nothing is displayed.

### Built With

* [Atom](https://atom.io/) - Open-source, hackable code editor running on the Electron framework.

### Support and Contact Details
If you encounter any bugs or would like to make suggestions regarding this project, please feel free to open an issue within the repository.

### License

This project is distributed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
