using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
<<<<<<< HEAD
using MultiShop.WebUI.Services.CommentServices;
=======
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
using Newtonsoft.Json;

namespace MultiShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailReviewComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;
        public _ProductDetailReviewComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _commentService.CommentListByProductId(id);
            return View(values);
        }
    }
}
