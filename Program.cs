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

//For & ForEach
//OLD SCHOOL WAY forloop
//a for loop is very similar to a conveyer belt in a factory; the data is on a conveyer belt that moves them along, iterating them, one after the other. And when the data is on the conveyer belt, we can "operate" on them like a robotic arm can work on things on a conveyer belt while the belt is moving
//var i = 0 ; initialise a variable, tell it where we should start
//i < 10 ; control where the conveyer belt stops, how long the conveyer belt should run for --> we don't want it to iterate more than ten so therefore we tell it to stop at ten
//i++ ; incrementer, control how you go to the next item in the for loop
for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
//NEW SCHOOL WAY aka foreach
//whenever the right side is plural, it represents a collection aka more than one, "students" --> where you are going to put your array
//left side is always one, in this case "student", as it is what you use to write out in console.writeline
//else it is like the for loop except you don't have to worry about iteration aka where the things are in the array, you can just write them out directly
//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}

//NEW NEW SCHOOL aka LINQ
//students.ToList().ForEach(i => Console.WriteLine(i));
//Array.ForEach(students, element => Console.WriteLine(element));

//Counter
for (var i = 1; i <= 10; i++) //initilizing a 1 in place of a 0 which we did above means that we start the counting at 1 instead of 0. 
{
    Console.WriteLine(i);
}

string[] favoriteHairMetalBands = ["Van Halen", "Dokken", "Great White"];
for (var i = 0; i < favoriteHairMetalBands.Length; i++) //setting a .length means that c# calculates the length of the array for us and runs through to the end, so we don't have to state with numbers how long it's going to run for
{
    Console.WriteLine(favoriteHairMetalBands[i]); //we need to put [i] in the console.writeline so that C# can actually get access and run through the array instead of stating that it is part of an array; System.String[]
}

//Do the same thing as above, but easier
foreach (var band in favoriteHairMetalBands)
{
    Console.WriteLine(band);
}

//Do it again even easier!! :O
favoriteHairMetalBands.ToList().ForEach((i) =>
{
    Console.WriteLine("ForEach: " + i);
});

Array.ForEach(favoriteHairMetalBands, e => Console.WriteLine("Array.ForEach: " + e));

//IF ELSE STATEMENTS
if (true)
{
    Console.WriteLine("This code will ALWAYS run");
}

var aquariumStoreInvetory = "clownfish";

if ((aquariumStoreInvetory == "pufferFish") || (aquariumStoreInvetory == "clownfish"))
{
    Console.WriteLine("I will buy the pufferfish or the clownfish <3");
}
else
{
    Console.WriteLine("I will not buy anything!");
}

//<>
var fishTankPrice = 1001;
if (fishTankPrice <= 1000)
{
    Console.WriteLine("Buy tank");
}
else
{
    Console.WriteLine("Don't buy");
}

//method to use an if-statement to check what kind of type the variable is
var aquariumFish = "pufferfish";
if (aquariumFish is string) //this means that if the statement is a string, it is going to execute the code. if it's not a string, nothing happends and you'll know it's not a string
{
    Console.WriteLine("Aquarium fish is a string");
}

//ENUM 
//An enumeration type or enum type is a simple value type, like ints, string, double. They are constants, meaning that they cannot be changed. 
//example if(status == "code-red") vs if(status == Warning.CodeRed). Even though a string is immutable, meaaning it cant be changed, it still technically can be changed as we can reassign the value. That can't be done with enums, when you define it it is constant and it cannot be reassigned later in the project like a string can. 
//microsoft assigns an incrementing aka rising int value to lists of enums, so the first enum defined is 0, the second is 1 and so forth;
//example 
//enum Warning
//{
//    CodeRed, == 0
//    CodeBlue, == 1
//    CodeYellow == 2
//}

Console.WriteLine((int)Warning.CodeYellow);

var status = Warning.CodeYellow;

if (status == Warning.CodeYellow)
{
    Console.WriteLine("CODE YELLOW");
}
enum Warning
{
    CodeRed,
    CodeBlue,
    CodeYellow
}