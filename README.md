# Park API

## By Joseph Pearce

## Description

_Access state and national park information via this API._

<img src="ParkApi/wwwroot/assets/images/arches.jpg" style="float: left; margin-right: 10px;" />

* Full CRUD functionality.
* Pagination.
* API endpoints instructions.


## Path Parameters

| Parmeter | Type | Default | Description | 
|:--------- |:--------- |:-------- |:-------- |
| parkname | string | none | Return matches by name.| 
| state | string | none | Return any Park by State.| 
| type | string | none | Return matches by type of Park (State, National).| 

## Endpoints

Base URL: `http://localhost:5000`

## HTTP Request
```
- GET /api/parks
- POST /api/parks
- GET /api/parks/{id}
- PUT /api/parks/{id}
- DELETE /api/parks/{id}
```

## Example Query

There are multiple ways to query the API. To search by parkname or a specific rating(1-5), add the parameter(s) after `parks?` 
Example: `http://localhost:5000/api/parks?parkname=&rating=5`. Use an ampersand(&) to separate parameters.

## Sample JSON Response
```
 {
      "parkId": 3,
      "parkName": "Grand Teton National Park",
      "state": "Wyoming",
      "type": "National",
      "description": "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years",
      "rating": 5
  },
```

## Note on Pagination

To search by page and/or to limit the number of results per page, add `pages?` after `parks/`, then specity the pageNumber (which page you would like to see) and pageSize (how many results you would like per page. If pageSize is not specified, the default number of results per page is 10.

## Example Pagination Query
```
 
http://localhost:5000/api/parks/pages?pageNumber=2&pageSize=5

```

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

- Entity Framework Core
- .NET Core CLI
- ASP.NET Core Identity
- ASP.NET Core MVC
- .NET Core 2.2
- MySQL & MySQL Workbench
- C#
- Razor
- Visual Studio Code
- Git Version Control
- GitHub


## License
This software is licensed under the MIT license. Copyright (c) 2020 Joseph Pearce.
