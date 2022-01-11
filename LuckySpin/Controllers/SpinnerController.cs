﻿using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {         // TODO: Receive a LuckyNumber object as a parameter called "Lucky" from DIJ
        // TODO: Modify the Index Action to return Lucky.Output as the Content
        public IActionResult Index()
        {
            //TODO: Receive the Routing id as a parameter called "luck"
            //TODO: Set LuckyNumber object's Luck property to the value of "luck" before returning the ContentResult            
            return new ContentResult { Content = "<h1>We're Ready to Spin</h1>", ContentType = "text/html" };
        }
    }
}
