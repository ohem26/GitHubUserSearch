using GitHubMVC.Models;
using GitHubUserSearch.DataAccess.Interfaces;
using GitHubUserSearch.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubMVC.Controllers
{
    public class SearchUserController : Controller
    {
        public readonly IGitHubUserSearchSvc<GitHubUser, GitHubRepo> _igithubService;

        public SearchUserController(IGitHubUserSearchSvc<GitHubUser, GitHubRepo> igithubService)
        {
            _igithubService = igithubService;

        }


        // GET: SearchUser
        [HttpGet]
        public ActionResult SearchUser()
        {
            return View(new GitHubUserModel());
        }

        [HttpPost]
        public ActionResult SearchUser(GitHubUserModel model)
        {
            var gitHubUser = _igithubService.GetUser(model.UserName);
            model.Avatar = gitHubUser.Avatar;
            model.Location = gitHubUser.Location;
            model.GitHubRepos= gitHubUser.Repos;
            return View(model);
        }
    }
}