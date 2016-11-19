using OracleDb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleDb.Core.Entities
{
    [Table("Course")]
    public class Course : IEntity
	{
        [MaxLength(300)]
		public string CourseName { get; set; }
		public int Id { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
    }
}
