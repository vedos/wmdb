using api_service.Data;
using api_service.Model;
using api_service.Model.RestModels;
using api_service.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System.Linq;

namespace api_service.Repositories
{
    public class ItemRepository : BaseRepository<Item, EFContext>
    {
        private EFContext _context;
        public ItemRepository(EFContext context) : base(context)
        {
            _context = context;
        }

        public Rating Rate(Rate rate)
        {

            var rating = new Rating();
            rating.ItemId = rate.ItemId;
            rating.Value = rate.Rating;
            
            _context.Ratings.Add(rating);
            _context.SaveChanges();


            var result = _context.Ratings.Where(x => x.Id == rating.Id)
                .Include(x=>x.Item)
                .SingleOrDefault();

            return result;
        }

        public IPagedList<ItemOut> GetItems(string category, string search, int page, int pageSize)
        {
            var items = _context.Items.Where(x => 
            (x.Category.Tag == category ||
            category == null)            
            &&
            (x.Title.ToLower().Contains(search != null? search.ToLower() : "") ||
             x.Description.ToLower().Contains(search != null ? search.ToLower() : ""))
            ).ToList();            

            var itemsOut = items.Select(x=> new ItemOut() { 
                Id= x.Id,
                Casts= x.Casts,
                Category= x.Category,
                CategoryId= x.CategoryId,
                Description= x.Description,
                ReleaseDate= x.ReleaseDate,
                Title= x.Title,
                Thumbnail = x.Thumbnail,
                Rating = _context.Ratings.Where(y => y.ItemId == x.Id).ToList().Count > 0 ? _context.Ratings.Where(y => y.ItemId == x.Id).Average(y=>y.Value) : 0
            } ).OrderByDescending(o=>o.Rating).ToPagedList(page, pageSize);

            return itemsOut;
        }
    }
}
