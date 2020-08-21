# Park API

## By Joseph Pearce

## Description

_This project is an API that will list state and national parks. It have full CRUD functionality, pagination and documentation of API endpoints._

* Full CRUD functionality.
* Pagination.
* API endpoints instructions.


## Specifications

| Spec | Input | Output | 
|:--------- |:--------- |:-------- |
| The program will construct a database of Parks allowing the User to make entries | "ParkName" | "" | 


## Setup/Installation Requirements

* Clone this repository from GitHub https://github.com/pearcy/ParkAPI.Solution.git
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* To install the REPL dotnet script, run ```dotnet tool install -g dotnet-script``` in your terminal.
* Run ```dotnet restore``` in terminal to get all dependencies.
* Run the command ```dotnet build```.

#### Additional Setup/Installation Notes:

* You will need to have MySQL installed on your computer to start the database for this project.
* Once you have it installed open your terminal and run ```mysql -uroot -pepicodus```. This will start the mysql server on your computer.
* With mysql running in your terminal copy/paste the code snippet below.
* Run ```dotnet ef migrations add Initial``` and ```dotnet ef database update``` to create the schema and all required tables.
* Then you will have the database correctly set up and you can start the project in a separate terminal that the one running mysql by running ```dotnet run```.


## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

Please feel free to contact me through GitHub (username: pearcy) with any questions, ideas or concerns.  

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code
* Git and Git BASH
* MySQL Workbench
* MySQL Database
* API



## License
This software is licensed under the MIT license. Copyright (c) 2020 Joseph Pearce.
