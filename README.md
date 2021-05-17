# Giancarlo's Bakery

#### A simple console app that allows the user to order loaves of bread or pastries and returns the price for said items. 
### By Giancarlo Vigneri
---
## Technologies Used

>* _C#_
>* _.NET 5 SDK_

---
## Description 
The program will welcome the user to the bakery, inform them of the selections and the deals for the selections. It will ask if the user would like to 'purchase' bread, pastry, or exit the program altogether. Upon making a choice the user will be asked to enter an amount of said baked good. The program then returns the price of the order as well as the quantity of the baked good, and will present the user with the same greeting again, looping through the logic again. If the user is done they simply type exit and the transaction is finished. If the user mistypes a selection they must 'leave' the bakery and come back...Do not make an invalid selection or you WILL lose you place in the line!

## Installation Requirements/Setup

### Requirements

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.

### Running the Program:
1) Clone the repository: "https://github.com/Bobloblawlobslawbomb/normal-bakery-lamp"
2) Navigate to the 'normal-bakery-lamp/' directory on your computer
3) Open with your favorite text editor (Visual Studio Code, is a pretty sweet one)
4. To run the console app:
   - Navigate to `normal-bakery-lamp/Bakery` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `Bakery.csproj`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
5. To run tests:
   - Navigate to `normal-bakery-lamp/Bakery.Tests` in your command line.
   - Run the command `dotnet restore` to restore the dependencies that are listed in `Bakery.Tests.csproj`
   - Finally, run the command `dotnet test` to run the tests!

## Known Bugs

* _If the user does not enter an integer when prompted "How many {bread/pastries} would you like?", the program will throw an error and end._
---

## License [GPL] (https://choosealicense.com/licenses/gpl-3.0/)
_if you do run into any issues or have questions, ideas, or concerns; I would greatly encourage you to send feedback or make a contribution to the code_

---

## Contact Information
_Contact Giancarlo Vigneri at: bobloblaw.vigneri@gmail.com_ 

(I went to the zoo and saw a baguette in a cage. I was told that it was bread in captivity.)