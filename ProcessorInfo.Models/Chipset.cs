﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProcessorInfo.Models
{
    [Table("Chipset")]
    public class Chipset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChipsetId { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public string PhotoUrl { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Processor> Processors { get; set; }

        public Chipset()
        {
            this.Processors = new HashSet<Processor>();
        }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
