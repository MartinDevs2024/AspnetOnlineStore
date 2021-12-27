using Microsoft.AspNetCore.Mvc;
using OrOnlineStore.DataAccess.Repository.FileManager;
using OrOnlineStore.DataAccess.Repository.IRepository;
using OrOnlineStore.Models.Comments;
using OrOnlineStore.Models.ViewModels;
using OrOnlineStore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrOnlineStore.Areas.UI.Controllers
{
    [Area("UI")]
    public class PostController : Controller
    {
        private readonly IRepo _repo;
        private readonly IFileManager _fileManager;

        public PostController(IRepo repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }
        public IActionResult Index(int pageNumber, string category, string search, string orderBy)
        {
            if (pageNumber < 1)
                return RedirectToAction("Index", new { pageNumber = 1, category });
            var posts = _repo.GetAllPosts(pageNumber, category, search, orderBy);
            return View(posts);
        }

        public IActionResult Detail(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }
        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Post", new { id = vm.PostId });

            var post = _repo.GetPost(vm.PostId);

            if (vm.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();

                post.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now

                });
                _repo.UpdatePost(post);
            }
            else
            {
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now,
                };
                _repo.AddSubComment(comment);

            }
            await _repo.SaveChangesAsync();

            return RedirectToAction("Detail", new { id = vm.PostId });
        }
    }
}
