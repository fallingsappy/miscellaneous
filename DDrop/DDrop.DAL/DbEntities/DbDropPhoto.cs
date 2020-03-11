﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDrop.DAL.DbEntities
{
    [Table("DropPhotos")]
    public class DbDropPhoto
    {
        [Key]
        public Guid DropPhotoId { get; set; }
        public string Name { get; set; }
        public int XDiameterInPixels { get; set; }
        public int YDiameterInPixels { get; set; }
        public int ZDiameterInPixels { get; set; }
        public virtual DbSimpleLine SimpleHorizontalLine { get; set; }
        public virtual DbSimpleLine SimpleVerticalLine { get; set; }
        public byte[] Content { get; set; }
        public virtual DbDrop Drop { get; set; }
        public string AddedDate { get; set; }

        public Guid CurrentSeriesId { get; set; }
        public DbSeries CurrentSeries { get; set; }
    }
}
