using System;
using System.Collections.Generic;
using System.Reflection;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using GitHubUserSearch.DataAccess.Implementations;
using GitHubUserSearch.DataAccess.Interfaces;
using GitHubUserSearch.DataAccess.Model;
using System.Web.Mvc;


namespace GitHubMVC.App_Start
{
    public static class SimpleConfig
    {
        public static void RegisterComponents()
        {
            var container = new Container();
            container.Register<IGitHubSettings, GitHubSettings>();
            container.Register<IBaseUrl, GitHubBaseUrl>();
            container.Register<IGitHubUserSearchSvc<GitHubUser, GitHubRepo>, GitHubUserSearchSvc>();
            container.Verify();

            // 4. Store the container for use by the application
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}