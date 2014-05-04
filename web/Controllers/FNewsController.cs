﻿using BLL.NewsBL;
using BLL.PhotoBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class FNewsController : Controller
    {
        //
        // GET: /News/
        string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();

        public ActionResult Index()
        {
            var news = NewsManager.GetNewsList(lang, 0);
            var photos = PhotoManager.GetListForFront((int)web.Areas.Admin.Helpers.PhotoType.News, lang);
            NewsWrapperModel m = new NewsWrapperModel(news, photos);
            return View(m);
        }

        public ActionResult Basin()
        {
            var news = NewsManager.GetNewsList(lang, 1);
            var photos = PhotoManager.GetListForFront((int)web.Areas.Admin.Helpers.PhotoType.News, lang);
            NewsWrapperModel m = new NewsWrapperModel(news, photos);
            return View(m);
        }

        //public ActionResult NewsContent(int hid)
        //{
        //    var news = NewsManager.GetNewsItem(hid);
        //    var allnews = NewsManager.GetNewsList(lang);
        //    NewsWrapperModel m = new NewsWrapperModel(allnews, news);
        //    return View(m);
        //}
    }
}
