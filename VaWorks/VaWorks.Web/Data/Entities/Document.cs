﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VaWorks.Web.Data.Entities
{
    public enum DocumentType
    {
        [Display(Name = "Material Standard")]
        MaterialStandard,
        [Display(Name = "Price Sheet")]
        PriceSheet
    }

    [Table("Documents")]
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }

        [Required]
        [Display(Name = "Display Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "File Name")]
        [MaxLength(250)]
        public string FileName { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public DocumentType DocumentType { get; set; }

        [Display(Name = "Document")]
        public byte[] FileData { get; set; }

        public string ContentType { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}