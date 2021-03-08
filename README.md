![pierre's splash page image](PierresBakeryMvc/wwwroot/img/pierres-header.png)

# _Pierre's Bakery Vendor List_

#### _An MVC application that allows a fictional bakery owner to track their vendors and each vendor's associated orders_

#### By _**Chloe Loveall**_
<br>

![license](https://img.shields.io/github/license/chloeloveall/PierresBakeryMvc.Solution?color=blue&style=flat-square) &nbsp; ![top project language](https://img.shields.io/github/languages/top/chloeloveall/PierresBakeryMvc.Solution?style=flat-square) &nbsp; ![last github commit](https://img.shields.io/github/last-commit/chloeloveall/PierresBakeryMvc.Solution?style=flat-square) &nbsp; ![github pull requests](https://img.shields.io/github/issues-pr/chloeloveall/PierresBakeryMvc.Solution?style=flat-square) &nbsp; ![open issues](https://img.shields.io/github/issues-raw/chloeloveall/PierresBakeryMvc.Solution?style=flat-square) &nbsp; ![github contributors](https://img.shields.io/github/contributors/chloeloveall/PierresBakeryMvc.Solution?color=brightgreen&style=flat-square)

## Table of Contents

1. [Table of Contents](#table-of-contents)
2. [Description](#description)
4. [Technologies Used](#technologies-used)
5. [Setup and Installation Requirements](#setup-and-installation-requirements)
    * [Prior to Installation](#prior-to-installation)
    * [Installation](#installation)
    * [Unit Testing with MSTest](#unit-testing-with-ms-test)
6. [Specifications](#specifications)
7. [Known Bugs](#known-bugs)
8. [Contributing](#contributing)
9. [License](#license)
10. [Acknowledgements](#acknowledgements)
11. [Contact Information](#contact-information)

## Description

A detailed description 

## Technologies Used

* C#
* MSTest
* .NET 5.0
* Razor

## Setup and Installation Requirements

### Prior to Installation

* Confirm you have installed .NET installed - this will provide access to the C# language
  * [.NET for macOS](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer)
  * [.NET for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)
* Additionally, you may want to install a REPL to allow you to practice, test, and experiment with C#. Below are instructions for the ```dotnet script``` REPL:
  * Install ```dotnet script``` by running the following terminal command: ```$ dotnet tool install -g dotnet-script```
  * **NOTE:** If you just installed .NET 5, restart the terminal. (Otherwise, you will not be able to run the following command.) 
    * Enter ```$ dotnet script``` in your terminal and a prompt will open: ```>```
    * To exit the REPL press: Ctrl +C

### Installation
* Clone the repository with the following git terminal command: ```$ git clone https://github.com/chloeloveall/PierresBakeryMvc.Solution.git```
* Open the project directory in your terminal
* Navigate to the ```PierresBakeryMvc.Tests``` directory
    * To create ```obj``` directories in both production and test projects, run the terminal command: ```$ dotnet restore```
    * **NOTE**: Do not touch the code in either ```obj``` directory.
* To launch the program, run the terminal command: ```dotnet run```

### Unit Testing with MSTest
* Navigate to the ```PierresBakeryMvc.Tests``` directory
* Run the terminal command: ```$ dotnet test```
* If everything is set up correctly, you will see something similar to this: 
![MSTest Screenshot](img/mstest-screenshot.png)

## Specifications

| Behavior                                                         | Input                      | Output                     |
| ---------------------------------------------------------------- | :------------------------- | :------------------------- |
| Program will begin on a splash                                   | user runs program          | localhost:5000/            |
| User can click a link to be directed to a vendors page           | user clicks link           | localhost:5000/vendors     |
| User can add a vendor to a list                                  | "Suzie's Cafe              | "Suzie's Cafe"             |
| User can add multiple properties to each vendor                  |                            |                            |
| User can add an order to a vendor                                |                            |                            |
| User can add multiple properties to each order                   |                            |                            |
| User will be routed back to home page after vendor is added      |                            |                            |
| User can click vendor's name and view all associated orders      | user clicks "Suzie's Cafe" | localhost:5000/suziescafe  |

## Known Bugs

* None at this time

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated.

1. Fork the project on GirHub
    * Follow [Installation and Setup Requirements](#setup-and-installation-requirements) above
2. Create your Feature Branch: ```$ git checkout -b YourFeatureBranchName```
3. Commit your Changes ```$ git commit -m 'Add some Amazing Feature'```
4. Push to your feature branch on Github ```$ git push origin YourFeatureBranchName```
5. Open a Pull Request

## License

[MIT](LICENSE.md)

## Acknowledgements

* [Choose an open source license](https://choosealicense.com/)
* [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Shields](https://shields.io/)
* [Unplash: Photos for Everyone](https://unsplash.com/)

## Contact Information

_Chloe Loveall <chloeloveall@protonmail.com>_

![github followers](https://img.shields.io/github/followers/chloeloveall?style=social) &nbsp; ![github forks](https://img.shields.io/github/forks/chloeloveall/PierresBakeryMvc.Solution?label=Forks&style=social) &nbsp; ![github stars](https://img.shields.io/github/stars/chloeloveall/PierresBakeryMvc.Solution?style=social)

[Back to Top](#table-of-contents)