using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Cuong.Infrastructure.SharedKernel;

namespace Cuong.Data.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : DomainEntity<string>
    {
        [StringLength(20)]
        public string AdvertistmentPageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [ForeignKey("AdvertistmentPageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }

        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
