namespace LibraryApplication.Objects
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Author { get; set; }
        public int NumberOfPage   { get; set; }

        public Book(int id, string name, string author, int numberOfPage)
        {
            Id = id;
            Name = name;
            Author = author;
            NumberOfPage = numberOfPage;
        }
    }
}
