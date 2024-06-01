namespace Ispit.Books.Models.Dbo
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }


        
        public Author Author { get; set; }


      
        public Publisher Publisher { get; set; }

        public ApplicationUser ApplicationUser { get; set; }



        public DateTime Created { get; set; }
    }
}
