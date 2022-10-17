2022-10-13 1209
Started a new progect called Barbie_Dolls.
Created by Tarang Patel.
I connected it with git and changed its check-box to public.

I created the readme file.
I commit the changes in git and push it too.

finding properties of Dolls.


2022-10-13 1234
Found seven fields.
updated it in program.cs file
Commited the code and push to github.

2022-10-13 0111
Changed the version of all nuget Packages.
commite the code and push to github.
Also I forgot to add namespace in Dolls.cs so I added it 
Again commite it to github.

2022-10-13 0130
Made a new class called Barbie_dollsContext.cs indata folder
Also I changed the name of Dolls.cs file to doll.cs.
Commite to Git.

2022-10-13 0149
Made changes in startup.cs file and saved the changes
Also commite the chnages to git.


2022-10-13 1314
Decided to start scafolding.

2022-10-13 1644
Completed the Scafolding.
Saved the changes and Commited to git.


Added Add-Migration InitialCreate in PMC
Used following Line in PMC
Update-Database -Context ApplicationDbContext
Completd Migration.
Completed Part-4 
Saved readme file and commite to github.

2022-10-13 1659
Started Part 5

2022-10-13 2208
Started part 5 again
Decided to write seeddata.
First of all, I wrote data in word first of all
Then coppied all data in seed data file.
saved seed-data and commited to git.

2022-10-13 2215
Changed the Program.cs file
Commited in git.


2022-10-13 2230
Testing the application on web browser.
getting problem in IIS Express...
Found the error snd solved it.
Checked the app and database on web app.
Completed the part 5.
Commited to git.

2022-10-13 2236
Started Part-6.
Changed file Doll.cs.


2022-10-13 2256
check all the parts in several files.
Check the application and edit it.
Completed part 6.
Commite in the git.
Starting part 7.

2022-10-13 2319
Added search in Index.cshtml as text box for searching Name of a doll
Changed code in Startup.cs file
check the app.

2022-10-13 2322
Decided to change the field of search...
want to search by material instead of name...

2022-10-13 2330
Completed search 
Commit to git.

2022-10-13 2350
Started adding Dropdown menu for material and search for name of doll
Made new class in models named "MovieGenreViewModel.cs".
save the changes and commited to git.
Updated DollControllers.cs.

2022-10-14 2420
Found mistake in Readme file 
I by mistakely added wronge date 22 instead of 13.
Also fund some errors in getting all error cleare for search in selection list
Finally completed all and git commite
yesssss, Completed part 7 
checked app and it worked successfully.

2022-10-14 2425
Starting part 8.
Added new field 
updated Dolls.cs
updated Index.cshtml
updated Create.cshtml
updated seeddata
Completed Part- 8.
Added comands in PMC.
Commited changes to git.

2022-10-14 0110
Deleted all the records From the database to get the rating field.
Then clossed my application as well as visual studio.
Again oppened it and update database and then I got the expected result and get the rating field.

2022-10-14 0118
Starting Part-9

2022-10-14 0159
Added validations accordingly in every field.
Saved and Commited in git.
Completed Part-9

2022-10-14 0350
Completed part 10
Checked all files and perform all possible tasks on appliactaion.
Application successfully created.
commite to github.

2022-10-14 0359
Adding new Razor View Page Called "About Us" in Home Folder.
Updated Layout.cshtml file.
Updated HomeController.cs file for showing AboutUs Page.
Commited to git.
Getting sleepy. Need Sleep. Good Night.

2022-10-14 12:20
Good morning.
Contineuing with css for page.
Got so many errors in adding images folde and getting image.

2022-10-14 1439
Found the Actual problem.
I firstly added folder of images in my local c drive.
The oppened the local folder in visual studio 2019 and then commit that to git so that i can get that images folder in my get reposetory.
Then i clone reposetory and then got error again .
As i added the image folder in Main folder I was not able to get image on my webpage, But I can see the alternative text of an image.
Then after some research I found that The folder needs to be in WWWroot directory.
And then I Moved the image folder in it and got the image on my webpage.
Finally now I am moving forword to add content in my about us page.
But sill I am stuck with the css problems.
Commite to git.

2022-10-14 1447
Taking Break for lunch.

2022-10-14 1703
Back to work.
Started adding content in About us Page.
Commit to Git.
Added Company Info


//----------------------------------------------------------------

2022-10-17 0222
After final test I have got error .. 

Which is this : That is why I created new project named - Apple_Dolls

PM> Update-Database -Context Barbie_DollsContext
Build started...
Build succeeded.
fail: Microsoft.EntityFrameworkCore.Database.Command[20102]
      Failed executing DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Doll] (
          [ID] int NOT NULL IDENTITY,
          [Name] nvarchar(45) NOT NULL,
          [Material] nvarchar(30) NOT NULL,
          [Height] decimal(18, 2) NOT NULL,
          [ReleaseDate] datetime2 NOT NULL,
          [SetTheme] nvarchar(20) NOT NULL,
          [AgeGroup] int NOT NULL,
          [Price] decimal(18, 2) NOT NULL,
          [Rating] decimal(18, 2) NOT NULL,
          CONSTRAINT [PK_Doll] PRIMARY KEY ([ID])
      );
Failed executing DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
CREATE TABLE [Doll] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(45) NOT NULL,
    [Material] nvarchar(30) NOT NULL,
    [Height] decimal(18, 2) NOT NULL,
    [ReleaseDate] datetime2 NOT NULL,
    [SetTheme] nvarchar(20) NOT NULL,
    [AgeGroup] int NOT NULL,
    [Price] decimal(18, 2) NOT NULL,
    [Rating] decimal(18, 2) NOT NULL,
    CONSTRAINT [PK_Doll] PRIMARY KEY ([ID])
);
Microsoft.Data.SqlClient.SqlException (0x80131904): There is already an object named 'Doll' in the database.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteNonQueryTds(String methodName, Boolean isAsync, Int32 timeout, Boolean asyncWrite)
   at Microsoft.Data.SqlClient.SqlCommand.InternalExecuteNonQuery(TaskCompletionSource`1 completion, Boolean sendToPipe, Int32 timeout, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry, String methodName)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteNonQuery()
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQuery(RelationalCommandParameterObject parameterObject)
   at Microsoft.EntityFrameworkCore.Migrations.MigrationCommand.ExecuteNonQuery(IRelationalConnection connection, IReadOnlyDictionary`2 parameterValues)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQuery(IEnumerable`1 migrationCommands, IRelationalConnection connection)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.Migrate(String targetMigration)
   at Microsoft.EntityFrameworkCore.Design.Internal.MigrationsOperations.UpdateDatabase(String targetMigration, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.UpdateDatabaseImpl(String targetMigration, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.UpdateDatabase.<>c__DisplayClass0_0.<.ctor>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.Execute(Action action)
ClientConnectionId:9239009d-5166-4c73-a5c1-92ad43117a6e
Error Number:2714,State:6,Class:16
There is already an object named 'Doll' in the database.



//-----------------------------------------------------------------------




