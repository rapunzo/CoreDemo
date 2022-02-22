using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,Username="Mansur"
                },
                new UserComment
                {
                    Id = 2,Username="Emrah"
                },
                new UserComment
                {
                    Id = 3,Username="Akif"
                }
            };
            return View(commentValues);
        }
    }
}
