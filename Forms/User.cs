using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    internal class User {
        [Key]
        public Guid id { get; set; }

        [StringLength(255)]
        public required string firstName { get; set; }

        [StringLength(255)] 
        public required string lastName { get; set; }

        public DateOnly? birthDate { get; set; }

        public char? gender { get; set; } = 'M';

        public DateTime createdAt { get; set; } = DateTime.Now;

        public override string ToString() {
            return $"User: {firstName} {lastName}; Birthdate: {birthDate:yyyy-MM-dd}; Gender: {gender}";
        }
    }
}
