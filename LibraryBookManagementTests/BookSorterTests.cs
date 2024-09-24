using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryBookManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookManagement.Tests
{
    [TestClass()]
    public class BookSorterTests
    {
        [TestMethod()]
        public void SortBooksDescendingTest()
        {

            List<Book> DemoBooks = new List<Book>();

            for (int i = 0; i < 100; i++)
            {

                DemoBooks.Add(new Book());
            }


            List<Book> DemoBooksCheck = new List<Book>(DemoBooks);


            List<int> DemoBooksYears = new List<int>();

            List<int> DemoBooksCheckYears = new List<int>();

            List<int> DemoBooksISBN = new List<int>();

            List<int> DemoBooksCheckISBN = new List<int>();

            BookSorter sorter = new BookSorter();

            DemoBooksCheck = sorter.SortBooksDescending(DemoBooksCheck);

            Assert.IsNotNull(DemoBooksCheck);

            for (int i = 0; i < 100; i++)
            {
                DemoBooksISBN.Add(DemoBooks[i].getISBN());
                DemoBooksCheckISBN.Add(DemoBooksCheck[i].getISBN());

                DemoBooksYears.Add(DemoBooks[i].getYear());
                DemoBooksCheckYears.Add(DemoBooksCheck[i].getYear());

            }

            DemoBooksYears.Sort();
            DemoBooksYears.Reverse();


            DemoBooksISBN.Sort();
            DemoBooksCheckISBN.Sort();



            CollectionAssert.AreEqual(DemoBooksISBN, DemoBooksCheckISBN);
            CollectionAssert.AreEqual(DemoBooksYears, DemoBooksCheckYears);



        }

        [TestMethod()]
        public void PublishedYearAverageTest()
        {


            Random random = new Random();

            int DEMIaverage = 0;
            int DEMIamount = random.Next(0,100);
            List<int> DEMIyears = new List<int>();


            for (int i = 0; i < DEMIamount; i++)
            {
                DEMIyears.Add(random.Next(1900, 2023));
            }

            DEMIaverage = (int)DEMIyears.Average();


            List<Book> DemoBooks = new List<Book>();

            for (int i = 0; i < DEMIamount; i++)
            {
                Book book = new Book();
                book.setPublicationYear(DEMIyears[i]);
                DemoBooks.Add(book); 

            }


            BookSorter sorter = new BookSorter();
            int AVERAGE = sorter.PublishedYearAverage(DemoBooks);



            Assert.AreEqual(DEMIaverage, AVERAGE);
        }
    }
}

