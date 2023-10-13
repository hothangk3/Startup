using Microsoft.AspNetCore.Mvc;
using startup.Models;

namespace startup.Components
{
    [ViewComponent(Name ="RecentPost")]
    public class RecentPostComponent : ViewComponent
    {
        private readonly DataContext _dataContext;
        public RecentPostComponent(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = (from p in _dataContext.Posts
                        where(p.IsActive == true ) && (p.Status == 1)
                        orderby p.PostID descending
                        select p).Take( 6 ).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", list));
        }
    }
}
