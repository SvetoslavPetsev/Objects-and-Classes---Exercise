using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            string a = this.Title + " - " + this.Content + ": " + this.Author;
            return a;
        }
    }
    class Program
    {
        static void Main()
        {

            int numberOfInput = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfInput; i++)
            {
                string[] article = Console.ReadLine().Split(", ").ToArray();

                string title = article[0];
                string content = article[1];
                string author = article[2];

                Article articleObjekt = new Article(title, content, author);

                articles.Add(articleObjekt);

            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "title":

                    articles = articles.OrderBy(x => x.Title).ToList();

                    break;
                case "content":

                    articles = articles.OrderBy(x => x.Content).ToList();

                    break;
                case "author":

                    articles = articles.OrderBy(x => x.Author).ToList();

                    break;
            }

            for (int i = 0; i < numberOfInput; i++)
            {
                Console.WriteLine(articles[i].ToString());
            }
        }
    }
}
