namespace LibraryApplication.Objects
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Author { get; set; }
        public string Genre { get; set; }
        public int Page  { get; set; }
        public int Qauntity { get; set; }

        public Book(int id, string name, string author, string genre, int page, int qauntity)
        {
            Id = id;
            Name = name;
            Author = author;
            Genre = genre;
            Page = page;
            Qauntity = qauntity;
        }
      


    }
}
