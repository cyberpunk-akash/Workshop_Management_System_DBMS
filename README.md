# Workshop Management System
The desktop application aims to facilitate the process of supply chain
management. The software keeps track of all the commodities in the warehouse, their
source(supplier) and their destination(retailer). The manager will receive invoices from the supplier. The employees working in the warehouse can thus receive their work orders from the manager and accordingly they do the needful.

## Prerequisites:
1. Visual Studio 2019 - Community Version  
_It will be a big headache for you make the project run on some other verion of VS, so prefer having the 2019 version_
2. C#   
_You are prompted with a request to install C# while installing Visual Studio. Thus, ensure that it is installed_
3. MySQL 8.0 Command Line Client

## How to run the application after cloning?
1. Open the **schema** directory and refer the images to get an idea of the database schema.
2. Create a database with name **'wms'**.
3. Create tables and their attributes according to the images in the **schema** directory. You can also refer the **sqlqueries.txt** file, although some queries might be missing in it.
4. Once the database and it's tables are created, open the project in Visual Studio(through .sln file).
5. Connect the project to the database using the Server Explorer in Visual Studio.
6. The following are the details of the environment in which the project was created. <br />```username=root; password=kent; data source = localhost; database=wms```
Replace these values in the project appropriately according to your needs.
7. Run the project, the login page should appear.

## More guidelines:
1. If you want to implement PL/SQL, some basic queries are included in **sqlqueries.txt** file.
2. If you want to edit any table(**DataGridView** UI element) within the project, you need to select(click) on the particular data element that you want to edit. Then you have to click on the **Edit** button, which brings all the information of that particular tuple to the **TextBox**. You can now edit the data and once that's done click on the **Update** button.

## Contributors:
1. [Akash Hegde](https://github.com/cyberpunk-akash)
2. [Aashal Kamdar](https://github.com/terminatorash2199)
3. [Krutika Deshpande](https://github.com/krutikapd29)
4. [Akshat Tulsani](https://github.com/Tulsani)

**Thanks for viewing our work :)**
