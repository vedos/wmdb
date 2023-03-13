using api_service.Model.Base;

namespace api_service.Model
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get;set; }
    }
}