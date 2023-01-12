using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Microservice.Card.Domain.Dtos
{
    public class CardDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [DisplayName("Name")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "The Type is Required")]
        [RegularExpression(@"^(free|premium)$")]
        [DisplayName("Type")]
        public string? Type { get; set; }
    }
}
