using System.ComponentModel.DataAnnotations;

namespace BackGroundServiceMessage.Models
{
    public class Message
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }

    }


}