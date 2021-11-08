using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PeopleFinder.UI.Web.Models
{
    public class SearchModel
    {
        [DisplayName("Last name")]
        [Required]
        public string LastName { get; set; }

        public IEnumerable<Person> People { get; set; }
    }
}