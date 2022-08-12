# Pierre's Sweet and Savory Treats

### This is a simple MVC website that allows authorized users to make changes to many to many related classes.

## By Maxwell Alvord

## Technologies Used

* C#
* .Net 6.0
* EntityFrameWork
* MySQL WorkBench
* CSS
* HTML

## Description 
This is a MVC Webpage that has many to many functionality within the MySQL database and the program built. As long as the user signs in with a valid email, the user may add Treats and/or Flavors. If not signed in the anonymous visitor can only read the data. 

## Setup/Installation Requirements 

* Clone this repo: <https://github.com/maxwellalvord/Pierre.Solution>
* cd Pierre.Solution   
* $ touch appsetting.json
* Open the appsetting.json file and enter:

```
{ 
  "ConnectionStrings": { 
    "DefaultConnection": "Server=localhost;Port=3306;database=[Database-Name];uid=root;pwd=[YOUR-PASSWORD];" 
  } 
}
```
* Download MySQL WorkBench
* $ dotnet tool install --global dotnet-ef --version 6.0.0
* $ cd Pierre 
* $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0   
* $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0   
* $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 6.0.0   
* $ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0   
* $ dotnet restore
* $ dotnet build
* $ dotnet ef migrations add Initial
* $ dotnet ef database update   
* $ dotnet run   
* Click on  <http://localhost:5000>

## Known Bugs 

* Width of webpage styling locked. 

## License
[MIT](https://opensource.org/osd)

Copyright &copy;
2022 Maxwell Alvord

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

<br>

## Contact Information
Contact me with questions and bugs at: <br>
[A link to my issues page on GitHub](https://github.com/maxwellalvord/maxwellalvord/issues)<br>
or email me at <a href = "mailto:maxwellalvord@gmail.com">maxwellalvord@gmail.com</a>