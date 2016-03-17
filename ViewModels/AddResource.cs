using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fullcalendar.ViewModels
{
    public class AddResource
    {
        public string id { get; set; }

        [Required]
        [Display (Name = "Resource Name")]
        public string title { get; set; }
    }
}