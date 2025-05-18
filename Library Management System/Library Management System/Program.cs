using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
        interface IReservable
    {
        void ReserveItem();
        void CancelReservation();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book =new Book("book1","Basma","1",false,200);
         
            DVD dvd = new DVD("dvd1", "Basma", "2", false, 120);
         
            
            book.DisplayItemInfo();
            dvd.DisplayItemInfo();

            Library.DisplayLibraryName();

            Library library = new Library();
            library.AddItem(book);
            library.AddItem(dvd);
            library.DisplayAllItems();

        }
    }
    abstract class LibraryItem
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public string ItemId { get; set; }
        public bool IsBrowsed { get; set; }
        public LibraryItem(string title, string author, string itemId, bool isBrowsed)
        {
            this.Title = title;
            this.Author = author;
            this.ItemId = itemId;
            this.IsBrowsed = false;
        }

        public abstract void DisplayItemInfo();
        public bool BorrowItem()
        {
            IsBrowsed = true;
            return IsBrowsed;

        }
        public bool ReturnItem()
        {
            IsBrowsed = false;
            return IsBrowsed;
        }
    }
    class Book : LibraryItem,IReservable
    {
        public int PageCount { get; set; }
        public Book(string title, string author, string itemId,bool isBrowse, int pageCount)
    : base(title, author, itemId,isBrowse)
        {
            PageCount = pageCount;
        }

        public override void DisplayItemInfo()
        {
            Console.WriteLine($" from book{Title} {Author} {ItemId} {IsBrowsed}");
        }
        public void ReserveItem()
        {
            Console.WriteLine($"{Title} has been reserved.");
        }

        public void CancelReservation()
        {
            Console.WriteLine($"Reservation for {Title} has been cancelled.");
        }

    }
    class DVD : LibraryItem
    {
        public double Duration { get; set; }
        public DVD(string title, string author, string itemId, bool isBrowsed,double duration) : base(title, author, itemId, isBrowsed)
        {
            this.Duration = duration;
        }

        public override void DisplayItemInfo()
        {
            Console.WriteLine($" from dvd {Title} {Author} {ItemId} {IsBrowsed}");

        }
    }
    class Library
    {
       public  static string LibraryName = "City Library";
        List<LibraryItem> items = new List<LibraryItem>();
        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(LibraryItem item)
        {
            items.Remove(item);
        }
        public void DisplayAllItems()
        {
            foreach (LibraryItem item in items)
            {
                item.DisplayItemInfo();
            }
        }
        public string SearchByTitle(string title)

        {
            string res = "";
            foreach (LibraryItem item in items)
            {
                if (item.Title == title)
                {
                     res = item.Title;
                }
                else
                {
                    res ="";
                }
            }
            return res;
        }
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"{LibraryName}");
        }

    }

}
