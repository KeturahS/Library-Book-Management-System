
//Keturah Shlomo 313922783 and Shilat Haya Yosefi 324964410

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryBookManagement.Form1;
using static System.Collections.Specialized.BitVector32;



namespace LibraryBookManagement
{


    public partial class Form1 : Form
    {
        public List<Book> BookList = new List<Book>();
        public List<int> Unique_Isbn_list = new List<int>();



        public Form1()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void background_library_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //This is the function for adding a book to the library
        private void btnAddBook_Click(object sender, EventArgs e)
        {




            int result;

            bool success1 = int.TryParse(txtISBN.Text, out result);

            if (!success1)
            {
                MsgBOX.Show("All fields must be filled, pay attention that the ISBN must be an integer and that the Publication year must be between 1900 and 2023", "");
                return;


            }

            int result1;

            bool success2 = int.TryParse(txtPublishedYear.Text, out result1);

            if (!success2)
            {
                MsgBOX.Show("All fields must be filled, pay attention that the ISBN must be an integer and that the Publication year must be between 1900 and 2023", "");
                return;

            }
            else
            {
                if (result1 < 1900 || result1 > 2023)
                {
                    MsgBOX.Show("Publication year must be between 1900 and 2023", "");
                    return;

                }
            }


            int ISBN = Convert.ToInt32(txtISBN.Text);

            string bookTitle = txtTitle.Text;

            string bookAuthor = txtAuthor.Text;


            int Publication_date = Convert.ToInt32(txtPublishedYear.Text);

            string Category = CboxCategory.Text;

            string BookStatus = CboxStatus.Text;



            Book book = new Book(ISBN, bookTitle, bookAuthor, Publication_date, Category, BookStatus);

            if (bookTitle == "" || bookAuthor == "" || CboxCategory.SelectedItem.ToString() == "" || BookStatus == null)
                MsgBOX.Show("You must fill all the fields!","Fill all fields");
            else
            {
                BookList.Add(book);
                MsgBOX.Show("Book has been added", "");    
            }

        }



        private string ReturnAllBooks()
        {
            StringBuilder allBooks = new StringBuilder();

            int book_amount = 1;
            foreach (Book book in BookList)
            {
                allBooks.AppendLine(book_amount + ". ");
                allBooks.AppendLine(book.returnInfo());
                book_amount++;
            }

            return allBooks.ToString();
        }

       
        private async void AutamatedInput_Click(object sender, EventArgs e)
        {

            await Task.Run(() => TenThousandBooks(BookList));


            MsgBOX.Show("10000 books have been added.", "");



        }

        //This is the function used for the autamated imput of 10000 books

        public List<Book> TenThousandBooks(List<Book> booklist)
        {

            Random random = new Random();


            List<string> Titles = GetMorePopularBookTitles();
            int Titles_amount = Titles.Count;


            List<string> Authors = GetPopularBookAuthors();
            int Authors_amount = Authors.Count;

            List<string> Statuses = GetStatus();


            List<string> Categories = GetCategories();

            //Making sure all the ISBN numbers are unique

            for (int i = 0; i < 10000; i++)
            {

                int isbn = random.Next(1000, 1000000000);


                while (Unique_Isbn_list.Contains(isbn))
                {
                    isbn = random.Next(1000, 1000000000);
                }

                Unique_Isbn_list.Add(isbn);


                int index1 = random.Next(Titles_amount);
                string book_title = Titles[index1];

                int index2 = random.Next(Authors_amount);
                string book_auther = Authors[index2];

                int index3 = random.Next(4);
                string category = Categories[index3];

                int index4 = random.Next(2);
                string status = Statuses[index4];

                Book book = new Book(isbn, book_title, book_auther, random.Next(1900, 2024), category, status);
                booklist.Add(book);



            }
            return booklist;


        }

        private static List<string> GetCategories()
        {
            return new List<string>
            { "Science Fiction","Novel","History", "Biography"};


        }


        private static List<string> GetStatus()
        {
            return new List<string>
            { "Available", "Borrowed"};


        }



        private static List<string> GetMorePopularBookTitles()
        {
            return new List<string>
        {
            "To Kill a Mockingbird",
            "1984",
            "The Great Gatsby",
            "The Catcher in the Rye",
            "The Hobbit",
            "Fahrenheit 451",
            "Pride and Prejudice",
            "Animal Farm",
            "Harry Potter and the Sorcerer's Stone",
            "Lord of the Flies",
            "Jane Eyre",
            "Brave New World",
            "Wuthering Heights",
            "The Odyssey",
            "The Brothers Karamazov",
            "Crime and Punishment",
            "War and Peace",
            "The Adventures of Huckleberry Finn",
            "Moby Dick",
            "Anna Karenina",
            "The Iliad",
            "Les Misérables",
            "A Tale of Two Cities",
            "Great Expectations",
            "Little Women",
            "Gone with the Wind",
            "The Catcher in the Rye",
            "The Grapes of Wrath",
            "The Old Man and the Sea",
            "Of Mice and Men",
            "One Hundred Years of Solitude",
            "The Sound and the Fury",
            "A Farewell to Arms",
            "The Lord of the Rings",
            "Catch-22",
            "Slaughterhouse-Five",
            "Lolita",
            "The Picture of Dorian Gray",
            "Don Quixote",
            "The Kite Runner",
            "The Chronicles of Narnia",
            "The Shining",
            "Dracula",
            "Frankenstein",
            "The Scarlet Letter",
            "Treasure Island",
            "The Da Vinci Code",
            "Memoirs of a Geisha",
            "Life of Pi",
            "The Alchemist",
            "The Hunger Games",
            "Twilight",
            "The Fault in Our Stars",
            "Divergent",
            "The Maze Runner",
            "The Girl with the Dragon Tattoo",
            "The Book Thief",
            "A Game of Thrones",
            "The Handmaid's Tale",
            "The Help",
            "The Road",
            "Beloved",
            "Invisible Man",
            "Native Son",
            "Things Fall Apart",
            "The Color Purple",
            "The Secret Life of Bees",
            "Water for Elephants",
            "The Lovely Bones",
            "The Time Traveler's Wife",
            "Outlander",
            "The Pillars of the Earth",
            "The Guernsey Literary and Potato Peel Pie Society",
            "The Night Circus",
            "The Goldfinch",
            "Gone Girl",
            "The Girl on the Train",
            "Big Little Lies",
            "The Woman in the Window",
            "Where the Crawdads Sing",
            "Educated",
            "Becoming",
            "The Immortal Life of Henrietta Lacks",
            "Unbroken",
            "Wild",
            "Into the Wild",
            "Sapiens: A Brief History of Humankind",
            "The Glass Castle",
            "The Wright Brothers",
            "Steve Jobs",
            "Elon Musk: Tesla, SpaceX, and the Quest for a Fantastic Future",
            "Quiet: The Power of Introverts in a World That Can't Stop Talking",
            "The Power of Habit",
            "Thinking, Fast and Slow",
            "Outliers: The Story of Success",
            "The Tipping Point: How Little Things Can Make a Big Difference",
            "Freakonomics: A Rogue Economist Explores the Hidden Side of Everything",
            "Guns, Germs, and Steel: The Fates of Human Societies",
            "The 7 Habits of Highly Effective People",
            "The Wind-Up Bird Chronicle",
            "Norwegian Wood",
            "Kafka on the Shore",
            "1Q84",
            "The Elephant Vanishes",
            "After Dark",
            "Sputnik Sweetheart",
            "South of the Border, West of the Sun",
            "Dance Dance Dance",
            "The Adventures of Sherlock Holmes",
            "The Hound of the Baskervilles",
            "A Study in Scarlet",
            "The Sign of the Four",
            "The Valley of Fear",
            "His Last Bow",
            "The Return of Sherlock Holmes",
            "The Memoirs of Sherlock Holmes",
            "The Case-Book of Sherlock Holmes",
            "The Adventures of Tom Sawyer",
            "The Adventures of Huckleberry Finn",
            "Tom Sawyer Abroad",
            "Tom Sawyer, Detective",
            "Pudd'nhead Wilson",
            "The Prince and the Pauper",
            "A Connecticut Yankee in King Arthur's Court",
            "The Mysterious Stranger",
            "The Man Who Was Thursday",
            "The Napoleon of Notting Hill",
            "The Ball and the Cross",
            "Manalive",
            "The Club of Queer Trades",
            "The Poet and the Lunatics",
            "The Flying Inn",
            "The Paradoxes of Mr. Pond",
            "The Hunger Games: Catching Fire",
            "The Hunger Games: Mockingjay",
            "The Twilight Saga: New Moon",
            "The Twilight Saga: Eclipse",
            "The Twilight Saga: Breaking Dawn",
            "Divergent: Insurgent",
            "Divergent: Allegiant",
            "The Maze Runner: The Scorch Trials",
            "The Maze Runner: The Death Cure",
            "The Maze Runner: The Kill Order",
            "The Girl Who Played with Fire",
            "The Girl Who Kicked the Hornet's Nest",
            "The Girl in the Spider's Web",
            "The Girl Who Takes an Eye for an Eye",
            "The Book of Dust: La Belle Sauvage",
            "The Book of Dust: The Secret Commonwealth",
            "The Book of Dust: Serpentine",
            "The Shadow of the Wind",
            "The Angel's Game",
            "The Prisoner of Heaven",
            "The Labyrinth of the Spirits",
            "The Historian",
            "The Swan Thieves",
            "Elizabeth Kostova",
            "The Night Watch",
            "The Day Watch",
            "The Twilight Watch",
            "The Last Watch",
            "Metro 2033",
            "Metro 2034",
            "Metro 2035",
            "The Master and Margarita",
            "Heart of a Dog",
            "The White Guard",
            "The Fatal Eggs",
            "The Wonderful Wizard of Oz",
            "The Marvelous Land of Oz",
            "Ozma of Oz",
            "Dorothy and the Wizard in Oz",
            "The Road to Oz",
            "The Emerald City of Oz",
            "The Patchwork Girl of Oz",
            "Tik-Tok of Oz",
            "The Scarecrow of Oz",
            "Rinkitink in Oz",
            "The Lost Princess of Oz",
            "The Tin Woodman of Oz",
            "The Magic of Oz",
            "Glinda of Oz",
            "The Secret Garden",
            "A Little Princess",
            "Little Lord Fauntleroy",
            "The Lost Prince",
            "The Shuttle",
            "The Making of a Marchioness",
            "The Head of the House of Coombe",
            "A Lady of Quality",
            "The Little Hunchback Zia",
            "The One I Love",
            "The Wonderful Adventures of Nils",
            "Further Adventures of Nils",
            "The Brothers Lionheart",
            "Ronia the Robber's Daughter",
            "Pippi Longstocking",
            "Pippi Goes on Board",
            "Pippi in the South Seas",
            "The Six Bullerby Children",
            "Seacrow Island",
            "The Children of Noisy Village"
        };
        }


        private static List<string> GetPopularBookAuthors()
        {
            return new List<string>
        {
            "William Shakespeare",
            "Mark Twain",
            "Charles Dickens",
            "J.K. Rowling",
            "George Orwell",
            "Jane Austen",
            "J.R.R. Tolkien",
            "Ernest Hemingway",
            "F. Scott Fitzgerald",
            "Harper Lee",
            "Leo Tolstoy",
            "Gabriel Garcia Marquez",
            "Fyodor Dostoevsky",
            "John Steinbeck",
            "Homer",
            "James Joyce",
            "Emily Bronte",
            "Charlotte Bronte",
            "Virginia Woolf",
            "T.S. Eliot",
            "Joseph Conrad",
            "Herman Melville",
            "Arthur Conan Doyle",
            "Agatha Christie",
            "Edgar Allan Poe",
            "Jack London",
            "Nathaniel Hawthorne",
            "Lewis Carroll",
            "Rudyard Kipling",
            "George Eliot",
            "Henry James",
            "Victor Hugo",
            "Alexandre Dumas",
            "Franz Kafka",
            "Thomas Mann",
            "Marcel Proust",
            "Anton Chekhov",
            "Vladimir Nabokov",
            "James Baldwin",
            "Toni Morrison",
            "Margaret Atwood",
            "Kurt Vonnegut",
            "Aldous Huxley",
            "Ray Bradbury",
            "Isaac Asimov",
            "Philip K. Dick",
            "Robert Heinlein",
            "Arthur C. Clarke",
            "H.G. Wells",
            "Ursula K. Le Guin",
            "Neil Gaiman",
            "Stephen King",
            "Douglas Adams",
            "J.D. Salinger",
            "Haruki Murakami",
            "Kazuo Ishiguro",
            "Salman Rushdie",
            "Orhan Pamuk",
            "Isabel Allende",
            "Gabriel Garcia Marquez",
            "Carlos Ruiz Zafon",
            "Paulo Coelho",
            "Chinua Achebe",
            "Ngugi wa Thiong'o",
            "Wole Soyinka",
            "Kenzaburo Oe",
            "Yasunari Kawabata",
            "Banana Yoshimoto",
            "Jorge Luis Borges",
            "Julio Cortazar",
            "Mario Vargas Llosa",
            "Roberto Bolano",
            "Umberto Eco",
            "Italo Calvino",
            "Gunter Grass",
            "Patrick Suskind",
            "Milan Kundera",
            "Jaroslav Hasek",
            "Bohumil Hrabal",
            "Rainer Maria Rilke",
            "Hermann Hesse",
            "Johann Wolfgang von Goethe",
            "Friedrich Nietzsche",
            "Franz Grillparzer",
            "Thomas Bernhard",
            "Robert Musil",
            "Elias Canetti",
            "J.M. Coetzee",
            "Nadine Gordimer",
            "Alan Paton",
            "Chimamanda Ngozi Adichie",
            "Ben Okri",
            "Yaa Gyasi",
            "Naguib Mahfouz",
            "Orhan Pamuk",
            "Elif Shafak",
            "Amos Oz",
            "Etgar Keret",
            "Yuval Noah Harari",
            "David Grossman",
            "Shimon Adaf",
            "Dalia Rabikovitch",
            "Ronit Matalon",
            "Aharon Appelfeld",
            "S. Y. Agnon",
            "Yehuda Amichai",
            "Amos Kenan",
            "Yoram Kaniuk",
            "Daniella Carmi",
            "Mordecai Richler",
            "Alice Munro",
            "Margaret Atwood",
            "Michael Ondaatje",
            "Mordecai Richler",
            "William Faulkner",
            "Flannery O'Connor",
            "Tennessee Williams",
            "Truman Capote",
            "James Patterson",
            "Dan Brown",
            "John Grisham",
            "Tom Clancy",
            "Michael Crichton",
            "Ken Follett",
            "J.R.R. Tolkien",
            "C.S. Lewis",
            "E.B. White",
            "Dr. Seuss",
            "Roald Dahl",
            "Maurice Sendak",
            "Shel Silverstein",
            "Eric Carle",
            "Beatrix Potter",
            "J.M. Barrie",
            "L. Frank Baum",
            "P.L. Travers",
            "Lewis Carroll",
            "A.A. Milne",
            "J.K. Rowling",
            "Suzanne Collins",
            "Rick Riordan",
            "Stephenie Meyer",
            "Veronica Roth",
            "Ransom Riggs",
            "Cassandra Clare",
            "J.R. Ward",
            "George R.R. Martin",
            "Brandon Sanderson",
            "Patrick Rothfuss",
            "Robert Jordan",
            "Terry Goodkind",
            "Terry Pratchett",
            "Robin Hobb",
            "Joe Abercrombie",
            "Brent Weeks",
            "Gail Carriger",
            "Naomi Novik",
            "Brian Sanderson",
            "Neil Stephenson",
            "Richard K. Morgan",
            "William Gibson",
            "Philip Pullman",
            "Cinda Williams Chima",
            "Sarah J. Maas",
            "Leigh Bardugo",
            "Laini Taylor",
            "Kendare Blake",
            "Marie Lu",
            "Sabaa Tahir",
            "Holly Black",
            "Victoria Aveyard",
            "Maggie Stiefvater",
            "Julie Kagawa",
            "V.E. Schwab",
            "Rick Yancey",
            "E. Lockhart",
            "Lauren Oliver",
            "Rainbow Rowell",
            "Gillian Flynn",
            "Paula Hawkins",
            "Liane Moriarty",
            "Tana French",
            "Kate Atkinson",
            "Ruth Ware",
            "Karin Slaughter",
            "Lisa Gardner",
            "Harlan Coben",
            "Michael Connelly",
            "Lee Child",
            "Tess Gerritsen",
            "Kathy Reichs",
            "Sara Paretsky",
            "Sue Grafton",
            "Patricia Cornwell",
            "Janet Evanovich",
            "Mary Higgins Clark",
            "Jodi Picoult",
            "Nicholas Sparks",
            "Colleen Hoover",
            "Debbie Macomber",
            "Nora Roberts",
            "Danielle Steel",
            "Sophie Kinsella",
            "Meg Cabot",
            "Emily Giffin",
            "Jennifer Weiner",
            "Marian Keyes"
        };
        }

        private void Library_book_report_Click(object sender, EventArgs e)
        {

            Stopwatch stopwatch = new Stopwatch();

            // Start timing
            stopwatch.Start();

            // Call the function you want to measure
            BookList = sort5(BookList);

            // Stop timing
            stopwatch.Stop();

            // Get the elapsed time as a TimeSpan value
            TimeSpan ts = stopwatch.Elapsed;

            string reportText = ReturnAllBooks();

            // Creating a new instance of FormBookReport
            FormBookReport reportForm = new FormBookReport();


            StringBuilder General_info = new StringBuilder();


            BookSorter sorter = new BookSorter();

            General_info.AppendLine("RunTime " + ts.TotalMilliseconds + " ms" + Environment.NewLine + Environment.NewLine);

            string averageYear = sorter.PublishedYearAverage(BookList).ToString();

            if (averageYear == "0")
            {
                averageYear = "No books to calculate!";
            }
            General_info.AppendLine("Library Report:" + Environment.NewLine + "Total amount of books: " + BookList.Count.ToString() + Environment.NewLine + "Average publication year: " + averageYear + Environment.NewLine + "Amount of available books: " + Available_books().ToString());

            reportForm.SetReportTitle(General_info.ToString());


            // Setting the text of the new form
            reportForm.SetReportText(reportText);


            // Show the new form as a dialog
            reportForm.ShowDialog();


        }


        private int Available_books()
        {

            int count = 0;
            foreach (Book book in BookList)
            {
                if (book.Availability())
                    count++;

            }

            return count;

        }


       
        private BookSorter bookSorter = new BookSorter();

        public List<Book> sort5(List<Book> books)
        {

            return bookSorter.SortBooksDescending(books);


        }
    }




    // Third Bubble sort attempt with optimizations
    /*
    private void Bubble_sort3()
    {

        int reduct = 0;

        int amount = BookList.Count;

        Boolean switches_made = false;

        for (int i = 0; i < amount; i++)
        {

            for (int j = 0; j < amount - 1 - reduct; j++)
            {

                if (BookList[j].getYear() < BookList[j + 1].getYear())
                {
                    Book temp = BookList[j];
                    BookList[j] = BookList[j + 1];
                    BookList[j + 1] = temp;

                    switches_made = true;

                }
            }
            reduct++;

            if (!switches_made)
            {
                i = amount;

            }               

        }
    }

    */


    // Second Bubble sort attempt with optimizations
    /*
    private void Bubble_sort2()
    {

        int reduct = 0;

        int amount = BookList.Count;
        for (int i = 0; i < amount; i++)
        {

            for (int j = 0; j < amount - 1 - reduct; j++)
            {

                if (BookList[j].getYear() < BookList[j + 1].getYear())
                {
                    Book temp = BookList[j];
                    BookList[j] = BookList[j + 1];
                    BookList[j + 1] = temp;

                }


            }

            reduct++;

        }


    }
    */





    // First Bubble sort attempt with run time of n^2
    /*
            private void Bubble_sort1()
            {
                int amount = BookList.Count;
                for (int i = 0; i < amount; i++)
                {

                    for (int j = 0; j < amount-1; j++)
                    {

                        if (BookList[j].getYear() < BookList[j + 1].getYear() )
                        {
                            Book temp = BookList[j];
                            BookList[j] = BookList[j + 1];
                            BookList[j + 1] = temp;

                        }

                    }

                }
            }

            */



    public class BookSorter
    {
        //The final sorting method we wrote:
        public List<Book> SortBooksDescending(List<Book> books)
        {
            int Length = books.Count;
            if (Length < 2)
                return books;
            // Base case: array is already sorted
            int mid = Length / 2;
            List<Book> left = books.GetRange(0, mid);
            List<Book> right = books.GetRange(mid, Length - mid);

            SortBooksDescending(left);
            SortBooksDescending(right);

            int i = 0, j = 0, k = 0;
            while (i < left.Count && j < right.Count())
            {
                if (left[i].getYear() > right[j].getYear())
                {
                    books[k++] = left[i++];
                }
                else
                {
                    books[k++] = right[j++];
                }
            }

            while (i < left.Count) books[k++] = left[i++];

            while (j < right.Count) books[k++] = right[j++];

            return books;




        }

        //This is the average function of the publishment years
        public int PublishedYearAverage(List<Book> Books)
        {
            
            if (Books.Count == 0) return 0;

            int sum = 0;

            foreach (Book book in Books)
            {
                sum += book.getYear();
            }

            return sum / Books.Count;
            

        }


    }

    
    //This is the class of book with all the fields and methods needed for this library project
    public class Book
        {

            private int ISBN;
            private String Book_title;
            private String Book_author;
            private int Publication_date;
            private string Category;
            private string BookStatus;



            public Book(int ISBN, String Book_title, String Book_author, int Publication_date, string Category, string BookStatus)
            {
                this.ISBN = ISBN;
                this.Book_title = Book_title;
                this.Book_author = Book_author;
                this.Publication_date = Publication_date;
                this.Category = Category;
                this.BookStatus = BookStatus;


            }

            public Book() 
            {
                Random random = new Random();

                Publication_date = random.Next(1900,2024);

                int isbn = random.Next(1000, 20000);


                List<int> Unique_Isbn_list = new List<int>();

                while (Unique_Isbn_list.Contains(isbn))
                {
                    isbn = random.Next(1000, 40000);
                }

                ISBN = isbn;
                


            }



            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Book otherBook = (Book)obj;
                return Publication_date == otherBook.Publication_date;
            }

            // Override GetHashCode to be consistent with Equals
            public override int GetHashCode()
            {
                return Publication_date.GetHashCode();
            }




            public Boolean Availability()
            {
                return BookStatus == "Available";
            }

            public int getYear()
            { return Publication_date; }

            public int getISBN()
            {

            return ISBN; }

            public string returnInfo()

            {
                String info = "Publication date: " + Publication_date + ", ISBN: " + ISBN + ", Book title: " + Book_title + ", Book author: " + Book_author +
                     ", Category: " + Category + ", Book status: " + BookStatus + Environment.NewLine+ Environment.NewLine;

                return info;
            }

            public void setISBN(int ISBN)
            { this.ISBN = ISBN; }

            public void setTitle(string Book_title)
            {
                this.Book_title = Book_title;
            }

            public void setAuthor(string Book_author)
            { this.Book_author = Book_author; }

            public void setPublicationYear(int PublicationDate)
            { this.Publication_date = PublicationDate; }

            public void setCategory(string Category)
            { this.Category = Category; }

            public void setBookStatus(string bookStatus)
            {
                this.BookStatus = bookStatus;
            }


        }

     
    }








