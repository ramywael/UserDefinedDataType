namespace Task
{
    internal class Program
    {

        public class Library
        {
           public List<Book> books=new List<Book>();

            public bool AddBook(Book book)
            {
                         
                    for(int i=0; i < books.Count; i++)
                    {
                        if(book.isbn == books[i].isbn)
                        {
                            Console.WriteLine("The Book is already here ");
                            return false;
                        }
                      
                    }
                book = new Book(book.title, book.author, book.isbn);
                books.Add(book);
                Console.WriteLine("Added");
                return true;
               
            }
            public Book SearchBook(string bookName)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (bookName == books[i].title)
                    {
                        return books[i]; 
                    }
                }
                return null; 
            }



            public bool BorrowBook(string bookName)
            {
                Book foundBook = SearchBook(bookName); 
                if (foundBook != null && foundBook.availability == true) 
                {
                    foundBook.availability = false; 
                    Console.WriteLine($"You have borrowed '{foundBook.title}'.");
                    return true;
                }

                Console.WriteLine($"Cannot borrow '{bookName}'. It may not be available.");
                return false;
            }



            public bool ReturnBook(string bookName)
            {
                Book foundBook = SearchBook(bookName);
                for (int i = 0; i < books.Count; i++)
                {
                    if (foundBook !=null && foundBook.availability == false)
                    {
                        books[i].availability = true;
                        Console.WriteLine($"The book {foundBook.title} is returned");
                        return books[i].availability;

                    }

                }
                Console.WriteLine($"The book {bookName} isnot borrowed");

                return false;
            }

        }

        public class Book
        {
            public string title;
            public string author;
            public string isbn;
            public bool availability;
            public Book(string title, string author, string isbn, bool availability = true)
            {
                this.title = title;
                this.author = author;
                this.isbn = isbn;
                this.availability = availability;
            }
            public void SetTitle(string title)
            {
                this.title = title;
            }
            public void SetAuthor(string author)
            {
                this.author = author;

            }
            public void SetIsbn(string isbn)
            {
                this.isbn = isbn;
            }
            public void SetAvailability(bool availability)
            {
                this.availability = availability;
            }

            public string GetTitle()
            {
                return this.title;
            }
            public string GetAuthor()
            {
                return this.author;
            }
            public string GetIsbn()
            {
                return this.isbn;
            }
            public bool GetAvailability()
            {
                return this.availability;
            }
            static void Main(string[] args)
            {
                Library library = new Library();

                // Adding books to the library
                library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

                // Searching and borrowing books

                Console.WriteLine("Searching and borrowing books...");
                library.BorrowBook("1984");
                library.BorrowBook("Harry Potter"); // This book is not in the library

                // Returning books
                Console.WriteLine("\nReturning books...");
                library.ReturnBook("The Great Gatsby");
                library.ReturnBook("Harry Potter"); // This book is not borrowed

            }
        }
    }
}
