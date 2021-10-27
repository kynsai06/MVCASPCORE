using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCharacter.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public decimal NetWorth { get; set; }
    }
}
