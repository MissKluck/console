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

////READ : how to read data in a console app
//Console.WriteLine() and Console.Write

//UPDATE
////More complex becuse you have to navigate the concept of immutability which means that something cannot be changed
//petFish[0] = "P"; --> a way that is used to change things in javascript, but it is not on the basis of the thing you try to change being immutable aka hard or not able to change
//string newPetFish = petFish.Replace("porcupine", "blue dot");
//Console.WriteLine(newPetFish);
//We changed or updated the the variable petFish by reassigning it to a new variable and changing the value by using the .Replace


//DELETE --> difficult to actually delete strings that have been assigned value and put to memory
//String Builder --> a way to manipulate the sring without the C# compiler creating it over and over
StringBuilder newCrustacean = new StringBuilder();
//newCrustacean.Append("fiddler crab");
//Console.WriteLine(newCrustacean);
//newCrustacean.Remove(0, 8); //using remove you can specify which part of the value in the variable you want to delete, so here we removed fiddler and only have crab left
//Console.WriteLine(newCrustacean);

//Array CRUD
//Array for one specific datatype, so when you declare it before the square bracks, it's only that datatype you can use
//CREATE
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"]; //the most modern version of array

//READ
//Console.WriteLine(favoriteRats); //Gives you "System.String[]". Anything that has more than one or a string is iterable, meaning you can run through it. With Arrays you have to run through it, if not it will just return the method you are using. 
foreach (var rat in favoriteRats)
{
    Console.WriteLine(rat); //"rat" represents each individual rat, so we're telling the computer thaat we want to write them all out individually right after one another
}

//UPDATE
//the old school way to do it, we tell the computer which one we want to update by stating it's placement in the array, beginning with 0 as the first one
//favoriteRats[0] = "Fancy Rat"; 
//LINQ --> easier and better way to update. A powerful tool from microsoft
//don't need an entire course to learn it, just google how to use it; "update array Linq"
//Linq statement combined with sql can change at runtime, so we need to use a "var"

var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"));
//"where" is just a filter, in this instance we filter the array by everything that starts with the letter "b"
//the best way to filter, update and do whatever other change you want to an array

foreach (var rat in newFavoriteRats)
{
    Console.WriteLine(rat);
}

//DELETE
//gimme - probably doesn't exist, but if it does TELL ME