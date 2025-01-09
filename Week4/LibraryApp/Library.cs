using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Library
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageNumber { get; set; }
        public string Publisher { get; set; }
        public DateTime RegisterDate { get; set; }

        public Library()
        {
            RegisterDate = DateTime.Now;
        }

        public Library(string bookName, string authorName, int pageNumber, string publisher)
        {
            BookName = bookName;
            AuthorName = authorName;
            PageNumber = pageNumber;
            Publisher = publisher;
            RegisterDate = DateTime.Now;
        }

        public void SaveBook() 
        {
            Console.WriteLine($"{AuthorName} {AuthorSurname} isimli yazarın {PageNumber} sayfalık {Publisher} yayınevi tarafından basılan {BookName} adındaki kitabı {RegisterDate.ToShortDateString()} tarihinde sisteme kaydedilmiştir.");
        }
    }
}
