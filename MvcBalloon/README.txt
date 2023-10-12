// Author : Cristian Hernan Muller 
// Project: MvcBalloon - Assignment 1 
// Project Purpose: Generate a product catalogue allowing for CRUD operations 
// Date Created: 2023-10-10 1230 
// Date Finished: 2023-10-

//          IMPORTANT           //

// I have worked in this project since 2023-10-10 but I had issues that made me restart my project, in Github it will just show my last attempt but this project began before.

// Commented the "sslPort": 44320 located in Properties/launchSettings.json to be able to run the program and see it


//            LOG              //

- 2023-10-12

1:18 
Created the MvcBallon project and created a README.txt file...

1:18
Created a Github repository and connected it to the project...

1:20
Commented the sslPort field in the launchSettings.json to run the program...

1:21
Ran the program to make sure it works...

1:27
Created a controller for HelloWorld and updated it's content...

1:28
Testing the program to see if everything works...

1:38
Program works properly, moving to the next step...

1:39
Modified the index in HelloWorldController.cs to get everything ready to create a new View...

1:42
Created a new View item named index.cshtml and modified it's content...

2:07
Finished index.cshtml and created Welcome.cshtml while modifying it's content to make the view work...

2:09
Created a new model named Baloon.cs and added the necessary elements for each field on the table...

2:12
Installing the NuGet Package Manager to it's according version (3.1.32)...

2:20
Installed all the needed packages and created a new Data Folder with a MvcBalloonContext.cs Class...

2:30
Added a new scaffolding item succesfully and proceeded to Initiate the migration and it's update...

2:30
Both Migration and Updated worked properly and generated new files, proceeding to check them...

2:40
Program is running, proceeding to the next step...

3:40
Created the SeedData.cs Class and Pupulated it with elements for every field in the table of the program...

3:44
Running the program to see if the table was populated...

3:46
Program is working properly and the table has been populated. Proceeding to the next step...

4:02
Added new code that will specify the format of the decimal Price field in Balloon.cs...

4:06
After finishing the previos step I checked the code and everything is working properly and ready to move to the next step...

4:12
Modifying the Index method in BalloonsController.cs to turn it into a search bar... 

4:18
Testing the method while the program is running to see if it works...

4:19
Method is working. Moving to the next step...

4:23
Modified the same index method in BalloonsController.cs to search by id instead of using searchString...

4:28
Ran the code to test it out and it works. Now I will proceed with change it it back to searchString...

4:33
Created the search bar using a form and now I will run the program to see if works...

5:07
Created the BalloonSizeViewModel.cs Class to make a select list for the Size, this proccess involved the modification of BalloonsController.cs and Index.cshtml files. Now I will run the program to see if it works...

5:12
Started with the creation of a new rating field inside the Balloon.cs class which implied the modification of this file...

5:14
Modified the .cshtml files in which the Rating field would appear with the respective code to add it...

5:20
Modified SeedData.cs to give a rating to every product...

5:32
Opened the Package Manager Console to realize the migration for Rating and the update to the database.Everything worked correctly...

5:53
Started to add validations to each element insode the Balloons Class to make sure they meet specific criteria...

6:00
Forgot to modify the rating contents for .cshtml files such as Delete, Details and Edit.Everything is working properly now after running the program...

6:09
Tested the validations and they are working properly.Moving to the next step...

7:52
With everything finished and working, I made some styling to the website and created an img folder to store images...

7:53
With this work in progress, I have decided to give the last final touches and continue with a few more details tomorrow...