using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    // localhost:5000/groups
    [Route("groups")]
    public class GroupsController : Controller
    {
        private static long currentGroupId = 1;

        /// <summary>The group view model list</summary>
        private static readonly List<GroupViewModel> groupViewModelList
            = new List<GroupViewModel>{ new GroupViewModel{ Id = 1, Name = "A group view model"} };

        [HttpGet]
        [Route("")] //not neede Index used as default
        public IActionResult Index()
        {
            return View(groupViewModelList);
            // test string return Content("HelloGroups");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Details(long id)
        {
            GroupViewModel groupViewModel = groupViewModelList.SingleOrDefault(g => g.Id == id);

            if(groupViewModelList == null)
                return NotFound();

            return View(groupViewModel);
        }

        [HttpPost]
        [Route("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(long id, GroupViewModel model)
        {
            GroupViewModel groupViewModel = groupViewModelList.SingleOrDefault(g => g.Id == id);

            if (groupViewModel == null)
            {
                return NotFound();
            }

            groupViewModel.Name = model.Name;

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReally(GroupViewModel model)
        {
            model.Id = ++currentGroupId;
            groupViewModelList.Add(model);

            return RedirectToAction("Index");
        }
    }
}