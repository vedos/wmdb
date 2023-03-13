using api_service.Model.Base;
using System;
using System.Collections.Generic;

namespace api_service.Model
{
    public class Item : IEntity
    {
        public Item()
        {
            this.Casts = new HashSet<Cast>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; } 
        public int CategoryId { get; set; } 
        public string Thumbnail { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Cast> Casts { get; set; }

    }
}
