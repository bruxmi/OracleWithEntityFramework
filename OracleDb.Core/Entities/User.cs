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
    [Table("DevUser")]
    public class User : IEntity
    {
	    public User()
	    {
            this.Courses = new HashSet<Course>();
        }
		public int Id { get; set; }
        [MaxLength(300)]
        public string FirstName { get; set; }
        [MaxLength(300)]
        public string LastName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
