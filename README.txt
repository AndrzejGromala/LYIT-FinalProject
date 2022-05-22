This is Project Module final project.
It is created with Entity Framework and MS SQL Server in Visual Studio using C#. 
This application is available here: carapp.somee.com

To make it work locally please clone this repository and open the application in Visual Studio. 
Then create a database in SQL Server and create a new database. Run the code in SQLQuery1.sql to create a table. 
Then go to Solution Explorer in Visual Studio and go to DataLayer and open CarModel.edmx file -> right click and select option update data base from model.
Configure the details of the database you created and follow the options to update the database. After the database is updated Entity framework will update the connection string in App.Config file which is also in datalayer. Copy the connections string and update the connection string in Web.config file. After that the application should build and run properly. If there is an issue wile running the application saying "problem with tbl.CarCollections go to the SQL server and change the name of the table from tbl.CarCollection to tbl.CarCollections and run the application again. 
