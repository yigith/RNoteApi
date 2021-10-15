using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RNoteApi.Data
{
    public class Note
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        public DateTime? ModifiedTime { get; set; }
    }
}
