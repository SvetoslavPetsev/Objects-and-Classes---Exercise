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

        public string DispleyContent;

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newContent)
        {
            this.Author = newContent;
        }

        public void Rename(string newContent)
        {
            this.Title = newContent;
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
            List<string> article = Console.ReadLine().Split(", ").ToList();

            Article articleObjekt = new Article(article[0], article[1], article[2]);

            int numberOfInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInput; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string currCommand = input[0];
                input.Remove(currCommand);
                string newContent = string.Join(" ", input);

                if (currCommand == "Edit:")
                {
                    articleObjekt.Edit(newContent);
                }
                else if (currCommand == "ChangeAuthor:")
                {
                    articleObjekt.ChangeAuthor(newContent);
                }
                else if (currCommand == "Rename:")
                {
                    articleObjekt.Rename(newContent);
                }
            }

            Console.WriteLine(articleObjekt.ToString());
        }
    }
}
