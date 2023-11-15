using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookwormAPI.Domain.Entites
{
    public class BaseEntity
    {
        [Key]
        public int BookId {get; set;}

        public string Bookname { get; set;}

        public string BookType { get; set;}

        public string BookCategory { get; set;}

        public int BookStatus { get; set;}

        public int BookReview {  get; set;}

        public string BookSummary { get; set; }

        public DateTime BookUploadDate { get; set; }

        public Writer writer { get; set;}
      



    }
}
