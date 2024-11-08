//Create Read Update Delete aka CRUD
//only things we can do in dataprogramming

//CREATE
using System.Text;

string petFish = "puffer fish";

//Concatention --> a form of create too as it is creating a brand new string out of the one we already created
petFish = "porcupine " + petFish;

//TempLate LiteraL -->  allow us to create strings in complex fashions; it's just syntax to make your string writing a lot easier
//Console.WriteLine($"I AM BUYING {petFish}. YOU CANNOT STOP ME!!!!");

//Console.WriteLine(petFish);

//READ : how to read data in a console app
//Console.WriteLine() and Console.Write

//UPDATE
//More complex becuse you have to navigate the concept of immutability which means that something cannot be changed
//petFish[0] = "P"; --> a way that is used to change things in javascript, but it is not on the basis of the thing you try to change being immutable aka hard or not able to change
string newPetFish = petFish.Replace("porcupine", "blue dot");
//Console.WriteLine(newPetFish);
//We changed or updated the the variable petFish by reassigning it to a new variable and changing the value by using the .Replace


//DELETE --> difficult to actually delete strings that have been assigned value and put to memory
//String Builder --> a way to manipulate the sring without the C# compiler creating it over and over
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);
newCrustacean.Remove(0, 8); //using remove you can specify which part of the value in the variable you want to delete, so here we removed fiddler and only have crab left
Console.WriteLine(newCrustacean);