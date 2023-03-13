using api_service.Model.Base;

namespace api_service.Model
{
    public class Rating:IEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public Item Item { get; set; }

        public int ItemId { get; set; }

        public User User { get; set; }

        public int? UserId { get; set; }

    }
}
