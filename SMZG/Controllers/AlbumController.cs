using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SMZG.Models;

namespace SMZG.Controllers
{
    public class AlbumController : SMZGControllerBase
    {
        // GET: Album
        public ActionResult Index()
        {  
            return View();
        }

        public ActionResult Detail(string albumName)
        {
            SetAlbumItemList(albumName);
            return View();
        }

        public ActionResult GridPageListJson()
        {
            try
            {
                string filepath = Server.MapPath("~/App_Data/TestAlbum.json");
                string json = GetFileJson(filepath);
                return Content(json);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ActionResult SwtychinaTime()
        {
            return View();
        }

        public ActionResult SwtychinaAlbum()
        {
            return View();
        }
    }
}