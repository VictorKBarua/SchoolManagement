<h2>#School Management API application (.Net core onion architecture)</h2>
<h4>School Management is an api interface based .net core project designed based on onion architecture. We can start api integration from the first day without spending time on creating skeleton of the project.</h4> <br/>

 ![OnionArchitecture](https://github.com/VictorKBarua/Webcast-Euronext_Assignment/assets/57985914/d25f4cc3-feb0-43c4-a147-f8e4599f16b3)
<br/> <h3>Advantages of having Onion Architecture. </h3> 
<li>- Testibility: Unit test can be created for separate layers without an effect of other modules of the application. </li>
<li>- Loose Coupling: Loosely coupled application as the outer layer of the application always communicates with the inner layer via interfaces. </li>
<li>- Maintainable: Provides better maintainability as all the codes depend on layers or the center. </li>
<li>- Domain entities are core and center part. It can have access to both the database and UI layers. </li>
<li>- Internal layers never depend on the external layer. The code that may have changed should be part of an external layer.</li>
<h2>How to use and run this application.</h2>
<li>We will need postman to make api calls.</li>
<li>We will need Visual Studio 2022 for supporting .Net 6.</li>
<li>We will need a SQL server database.</li>
<li>We will need a SQL server management studio to access the database.</li>
<li><b>Sql server 2019</b> has been used for this project.</li>
<li><b>We can go for database first approach or Code first approach.</li>
<li>After opening the project configure our database connection string in appsetings.json file(API layer)</li>
<li>(For Code first approach)Open <b>Package manager console</b> under DAL/Repository layer the type <b>update-database</b> command for migration.</li>
<li>It will create our database and empty table according to connection string.</li>
<li>Run the application</li>

<h2>Technologies implemented:</h2>
<li>.Net 6.</li>
<li>Entityframework core 6.</li>
<li>Followed Domain driven design.</li 
<li>Dependency Injection.</li>
<li>Followed Seperation of Concern mechanism.</li>
<li>Implemented Unit test cases for relevant parts(Service layers). </li>
<li>Implemented customized validations in Service layers.</li>
<li>Implemented const qualifier for error messages through out the application. </li>
<li>Implemented try catch for error handling.</li>
<li>browse <b>https://localhost:XXXX/swagger/index.html</b> for api.</li>
