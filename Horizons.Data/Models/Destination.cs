﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Horizons.Data.Common;
// add changes
namespace Horizons.Data.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.DestinationNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.DestinationDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public string PublisherId { get; set; } = null!;
        public virtual IdentityUser Publisher { get; set; } = null!;

        [Required]
        public DateTime PublishedOn { get; set; }

        [Required]
        public int TerrainId { get; set; }
        public virtual Terrain Terrain { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<UserDestination> UsersDestinations { get; set; } = new HashSet<UserDestination>();
    }

}
