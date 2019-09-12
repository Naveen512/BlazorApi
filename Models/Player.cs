using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.CRUD.Sample.Api.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CurrentAge { get; set; }
        public string Teams { get; set; }
        public string PlayingRole { get; set; }
        public string BattingStyle { get; set; }
        public string BowlingStyle { get; set; }
    }
}
