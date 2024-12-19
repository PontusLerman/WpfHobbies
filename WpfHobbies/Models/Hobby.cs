using System.ComponentModel.DataAnnotations;

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
