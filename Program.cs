// See https://aka.ms/new-console-template for more information


//--------------------------------------------------------Challenge 1--------------------------------------------------------
//error: can not convert a string to a boolean
//"true" should be a boolean not a string, removed ""
bool amProgrammer = true; //can ignore amProgrammer error

//error: can not convert a double into an int
//27.9 is not a whole number, changed to 27
int Age = 27;


List<string> Names = new List<string>();
//Names = "Monica"; 
//error: can not convert
//adding a value to a list is not written the way it is at top, rewritten as below:
Names.Add("Monica");


Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there","0"); //0 is missing "", adding "" since data type should be a string to follow dictionary pattern


// This is a tricky one! Hint: look up what a char is in C#
//error: too many chatacters in character literal
//'MyName' can not be used in C# interchangeably, single '' can only have one letter inside them. Changed to " "
string MyName = "MyName";




//--------------------------------------------------------Challenge 2--------------------------------------------------------
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count-1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

//terminal error: index out of range
//starting value Numbers.Count is 6, but we technically only have 5 indexes so this is out of bounds
//to fix we have to do Numbers.Count-1






//--------------------------------------------------------Challenge 3--------------------------------------------------------
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}

//terminal error: index out of range
//foreach do not need to indicate MoreNumbers[i] the way for loops do because foreach deals with the values not in the index values
//change MoreNumbers[i]) to i




//--------------------------------------------------------Challenge 4--------------------------------------------------------
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        //num = 0;
    }
}

//error: can not assign to 'num'because it is 'foreach iteration variable'
//num = 0 is just setting the value but it is not setting its location first. One way to fix is with a for loop to have access
//to those index values. But we do not know what num=0 is going to do. Because Foreach values do not represent the location of the value, 
//we can not alter the value within a foreach loop
//we can comment it out till we get more info on what it trying to do 






//--------------------------------------------------------Challenge 5--------------------------------------------------------
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString[7] = "p";

//error: MyString[7] is getting an error that it can not be assigned, it is read only. (can not be edited aka left side of = is not supposed to be edited)
//strings are immutable, we can not change it by accessing it at a value which is what it is trying to do. (change index 7 to p)
//this is not a valid operation
//to fix this, we would need to get more ingo on what it was trying to do. (was it a typo? was it accessing a value to do something with it?)






//--------------------------------------------------------Challenge 6--------------------------------------------------------
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}

//we would not get an error with this, but there is something wrong with it.
//rand.Next(12); we can expect numbers between 0-11 since 12 is exclusive, but then we are saying if number == 12 console Hello
//we would never get Hello because whatever value is in () in a rand.Next is not going to be included which means if statement will never be triggered
//changed value to 13 in .next OR can also change if statement to a lower number (just changing either one to be in bounds)