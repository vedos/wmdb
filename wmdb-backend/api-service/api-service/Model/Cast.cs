using api_service.Model.Base;
using System.Collections.Generic;

namespace api_service.Model
{
    public class Cast: IEntity
    {
        public Cast()
        {
            this.Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string BirthDate { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}