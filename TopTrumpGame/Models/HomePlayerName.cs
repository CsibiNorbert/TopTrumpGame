using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TopTrumpGame.Models
{
    public class HomePlayerName
    {
        [Required]
        public string PlayerName { get; set; }
        
    }
}