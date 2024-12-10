using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHobbies.Models
{
    public class Hobby
    {
        public string Name { get; set; } = string.Empty;

        [Range (0, 10)]
        public int FunRating { get; set; }

        public bool IsActive { get; set; }
    }
}
