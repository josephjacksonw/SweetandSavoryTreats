# _Pierre's Sweet and Savory Treats_

#### By _**Joseph Jackson**_

#### _Program to add treats and flavors to a database in a many to many relationship!_

## Technologies Used

* _C#_
* _.NET_
* _MySQL_
* _HTML_
* _CSS_
* _Entity_
* _Identity_


## Description

_This application has user authentication, many to many relationships using MySQL, and MVC. The user is able to create an account, log in, and edit the data. They can create a flavor of treats, and assign them to treats they create. Data is stored using MySQL._

## Setup/Installation Requirements

* _In your terminal enter_
* _Clone the repository to your desktop_

* _Open the repository in Visual Studio Code_
* _In VS Code terminal, navigate to the SaSTreats folder_ 
* _In VS Code terminal, run_

```json
 $ dotnet restore
 ```

 * _Followed by,_

```json
 $ dotnet build
 ```

* _Create file named "appsettings.json" in the /SaSTreats folder_
* _Enter the following into the file_


```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=sastreats;uid=root;pwd=YOUR_PASSWORD;"
  }
}

```
* _Next in VS Code terminal, enter_

```json
 $ dotnet ef database update
 ```

* _In the terminal, to start the application, run_

```json
$ dotnet run
```

## Known Bugs

* _No known bugs_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_ 

Copyright (c) _2022_ _Joseph Jackson_