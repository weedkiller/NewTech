﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewTech.ProjectsNG.Web.Session;

namespace NewTech.ProjectsNG.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : ProjectsNGViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string skin)
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo, skin));
        }
    }
}