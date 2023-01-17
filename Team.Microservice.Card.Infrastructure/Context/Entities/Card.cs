using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Infrastructure.Context.Entities;

namespace Team.Microservice.Card.Infrastructure.Context.Entities
{
    [Table("CARD")]
    public class Card : BaseEntity
    {
        [Column("NAME")]
        public string Name { get; set; } = string.Empty;
        [Column("TYPE")]
        public string Type { get; set; } = string.Empty;
    }
}
