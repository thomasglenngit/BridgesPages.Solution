<h1 align='center'><img width='900' height='450' src='https://i.ytimg.com/vi/mR6ejFFrcEE/maxresdefault.jpg'><br>


**<h1 align = 'center'>Bridges**


*<h2 align ='center'>Our first project building our own hard-coded api.*


<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a> •<a href='#known-bugs'> Bugs</a> •<a href='#protecting-your-data'> Protecting Data</a> •<a href='#cloning'> Cloning</a> •<a href='#app-settings'> AppSettings</a> •<a href='#database-with-migrations'> Database</a> •<a href='#postman-api-requests'> API</a></h3>


<h3 align='center'>We logged a few of the most important bridges of the world in our API and built functionality to organize them by span, location, architect and construction date. There is also a calculation for determining average spans in a given query.</h3>

# **REQUIREMENTS**

_[Postman](https://www.postman.com/)_

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

_[.Net Core v2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)_

# **SETUP**

## **CLONING**

* Copy the repo link as shown in the image below

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif 'How to clone repo')

* Paste the link in the field provided by VsCode as thown in the image below

* You will be prompted to open the directory once you have cloned it. Select 'open'

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')

<br>

# **APP SETTINGS**

**You need to update your username and password in the appsettings.json file.**

_By default these are set to user:root and an empty password. If you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

# **PROTECTING YOUR DATA**

* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.

* Step 2: commit that .gitignore file (this prevents your sensitive information like your API key being shown to others). **DO NOT PROCEED UNTIL YOU DO THIS!**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image-3.jpg 'Set up instructions')

<br>

# **POSTMAN API REQUESTS**

## TO GET AN ITEM

* Open Postman

* Set your request to type 'GET'

* http://localhost:5000/api/items/ (for index of all)

* http://localhost:5000/api/items/id (for specific item details)

* Hit Send

## TO ADD AN ITEM

* Open Postman

* Set your request to type 'POST'

* http://localhost:5000/api/items/

* Select Body Tab

* Select Raw Radio Button

* Select JSON from dropdown

* Write your addition to the database in the following format

<br>

``{itemId: 1, itemName: 'Mark', itemDate: '8/13/2020', itemDetails: 'big''}``

* Hit Send

## TO EDIT AN ITEM

* Open Postman

* Make a GET request for the id you wish to edit

* http://localhost:5000/api/items/id

* You can select the returned item data and paste that into your request body section for editing.

* Once you have completed your edits.

* Set your request to Put

* Hit Send

## TO DELETE AN ITEM

* Open Postman

* Set your route in Postman to the id you wish to delete

* Set your request to Delete

* Hit Send

<br>

<br>

<br>

# **USING PAGINATION**

* you can use routing in this structure when making your requests to limit the return data

* adjust the PageNumber and PageSize values in your request to do so

* http://localhost:5000/api/items/page?PageNumber=2&PageSize=5

<br>

<br>

# **DATABASE WITH MIGRATIONS**

with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet ef database update``

<br>

# **TECHNOLOGIES USED**

_[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_

_[CSS](https://en.wikipedia.org/wiki/Cascading_Style_Sheets)_

_[Bootstrap](https://getbootstrap.com/)_

_[Asp.Net MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)_

_[HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)_

_[Node.js](https://nodejs.org/en/)_

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

# **KNOWN BUGS**


_** as of:** _

<br>

# **INSTALL**

## **INSTALLING WITH DOTNET**


with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet watch run``

<br>

# **❤️Contributors**

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/frederick-ernest.jpeg' width='160px;'/><br /><sub><b>Frederick Ernest</b></sub>](https://www.linkedin.com/in/frederick-ernest/)<br />

<br>

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'
