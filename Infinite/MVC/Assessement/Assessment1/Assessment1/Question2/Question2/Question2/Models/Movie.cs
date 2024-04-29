namespace Question2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class Movie
    {
       
        public int Mid { get; set; }
        public string MovieName { get; set; }
        public DateTime DateOfRelease { get; set; }
    }
}
