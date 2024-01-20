using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using System.Text.Json.Serialization;

namespace ProcessorInfo.Models
{
    [Table("Brands")]
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public string PhotoUrl { get; set; }


        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Processor> Processors { get; set; }

        public Brand()
        {
            this.Processors = new HashSet<Processor>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
