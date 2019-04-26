using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchDatabase
{
    class Person
    {
        [Required]
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string TwitchUN { get; set; }

        public string LeagueUN { get; set; }

        public string DiscordUN { get; set; }

        public string InstagramUN { get; set; }

        public string TwitterUN { get; set; }

        [Required]
        public bool isSubscribed { get; set; }

        public int Tier { get; set; }

    }
}
