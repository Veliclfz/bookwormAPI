namespace bookwormAPI.Application.ViewModels
{
    public class VM_BaseEntitiy_Create
    {
        public int BookId { get; set; }

        public string Bookname { get; set; }

        public string BookType { get; set; }

        public string BookCategory { get; set; }

        public int BookStatus { get; set; }

        public int BookReview { get; set; }

        public string BookSummary { get; set; }

        public DateTime BookUploadDate { get; set; }

        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterInfo { get; set; }
        public DateTime WriterBirthday { get; set; }
        public string WriterHomeTown { get; set; }
        public int WriterAge { get; set; }
    }
}