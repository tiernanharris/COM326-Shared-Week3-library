using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    


    public class Book
    {
        private string title;
        private string author;
        private string isbn;

       public string Title
        {
            get { return title; }
            set
            {
                if(!value.Any(char.IsDigit) && value != "")
                {
                   title = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }
        public string Author
        {
            get { return author; }
            set
            {
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value.Any(char.IsDigit) && value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
