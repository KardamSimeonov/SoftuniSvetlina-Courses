﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public virtual Album? Album { get; set; }

        [Required]
        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Writer? Writer { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<SongPerformer>? SongPerformers { get; set; }
    }
}