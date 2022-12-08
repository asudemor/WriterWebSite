using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        private const string RegularExpression = @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$";

        [Key]
        public int BlogID { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression(RegularExpression, ErrorMessage = "{0} alanı sadece büyük ve küçük harflerden oluşabilir.")]
        [MinLength(5, ErrorMessage = "{0} 5 karakterden az olamaz."), MaxLength(20, ErrorMessage = "{0} 20 karakterden fazla olamaz.")]
        public string BlogTitle { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression(RegularExpression, ErrorMessage = "{0} alanı sadece büyük ve küçük harflerden oluşabilir.")]
        [MinLength(5, ErrorMessage = "{0} 5 karakterden az olamaz."), MaxLength(200, ErrorMessage = "{0} 200 karakterden fazla olamaz.")]
        public string BlogContent { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public string BlogPDF { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
