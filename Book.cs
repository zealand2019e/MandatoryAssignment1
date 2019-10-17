using System;

namespace MandatoryAssignment
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNo;
        private string _isbn;


        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Title should be more than 2 characters");
                }

                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int PageNo
        {
            get { return _pageNo; }
            set
            {
                if (value > 10 && value <= 1000)
                {
                    _pageNo = value;
                }
                else
                {
                    throw new ArgumentException("Your page number is out of range");
                }
            }
        }

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (value.Length == 13)
                {
                    _isbn = value;
                }
                else
                {
                    throw new ArgumentException("ISBN must be 13 Characters");

                }

            }
        }

        public Book(string title, string author, int pageNo, string isbn)
        {
            _title = title;
            _author = author;
            _pageNo = pageNo;
            _isbn = isbn;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} , Page No : {PageNo} , ISBN:{ISBN}";
        }
    }
}
