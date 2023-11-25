using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Articles
{
    public class Article
    {
        //public Article(string title, string content, string author)
        //{
        //    this.Author = author;
        //    this.Content = content;
        //    this.Author = author;
        //}
        string title;
        string content;
        string author;

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string newContent)
        {
            this.Content = newContent;
            return this.Content;
        }
        public string ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
            return this.Author;
        }
        public string Rename(string newTitle)
        {
            this.Title = newTitle;
            return this.Title;
        }

        public override string ToString()
        {
            return String.Format($"{0} - {1}: {2}", this.Title, this.Content, this.Author);
        }
    }
}
