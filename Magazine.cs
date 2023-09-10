using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Magazine
    {
        public string Name;
        public string Genre;
        public int Pages;
        public int PublicationDate;

        public Magazine(string name, string genre, int pages, int publicationDate)
        {
            Name = name;
            Genre = genre;
            Pages = pages;
            PublicationDate = publicationDate;
        }

        public override bool Equals(object obj)
        {
            return obj is Magazine magazine &&
                   Name == magazine.Name &&
                   Genre == magazine.Genre;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Genre);
        }
    }
}
