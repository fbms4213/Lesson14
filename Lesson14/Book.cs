using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14;

#nullable disable

public class Book
{
    public int Id { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }


    public Book(int id, string author, string title, string genre)
    {
        Id = id;
        Author = author;
        Title = title;
        Genre = genre;
    }


    public override string ToString()
        => @$"Id: {Id}
Author: {Author}
Title: {Title}
Genre: {Genre}
";

}
