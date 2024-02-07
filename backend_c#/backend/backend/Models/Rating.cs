﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models {
    public class Rating {
        [Key]
        [Column(name:"Id")]
        public int Id { get; set; }

        [Column(name:"RatingText")]
        public string RatingText { get; set; }

        [Column(name:"RatingNumber")]
        public int RatingNumber { get; set; }

        [Column(name:"ProductId")]
        public Guid ProductId { get; set; }

        [Column(name: "ProducerId")]
        public Guid ProducerId { get; set; }

        [Column(name: "ConsumerId")]
        public Guid ConsumerId { get; set; }

        [Column(name:"CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column(name: "DeleteddAt")]
        public DateTime DeletedAt { get; set; }

    }
}
