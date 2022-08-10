//5 generic types T constraints:
// where T : IComparable -- specific Interface
// where T : Product -- specific class of any of its derived classes
// where T : struct -- value type
// where T : calss -- reference type
// where T : new() -- object that have a default constructor





using generics;

Console.WriteLine("Start");

//var number = new List();
//number.Add(10);

var book = new Book { Isbn="1111", Title="c# Advance"};
//var books = new Booklist();
//books.Add(book);

// we can use GenericList and give it the type
var numbers = new GenericList<int>();
numbers.Add(10);

var books=new GenericList<Book>();
books.Add(book);

//generic dictionary
var dictionary=new Dictionary<int, Book>();
dictionary.Add(10, book);



Console.WriteLine("Finished");
