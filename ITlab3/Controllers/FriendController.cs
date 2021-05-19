using ITlab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITlab3.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        static List<FriendModel> friendsList = new List<FriendModel>()
        {
            new FriendModel() { indeks=10, ime="Maja", mestonaziveenje="Resen"},
            new FriendModel() { indeks=100, ime="Katerina", mestonaziveenje="Bitola"},
            new FriendModel() { indeks=11, ime="Marko", mestonaziveenje="Skopje"}
        };

        public ActionResult GetAllFriends ()
        {
            return View(friendsList);
        }

        public ActionResult ShowFriends(int id)
        {
            FriendModel model = friendsList.ElementAt(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = friendsList.ElementAt(id);
            model.id = id;
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            friendsList.RemoveAt(id);
            return View("GetAllFriends", friendsList);
        }

        [HttpPost]
        public ActionResult Edit(FriendModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Edit", model);
            }
            var nov = friendsList.ElementAt(model.id);
            nov.indeks = model.indeks;
            nov.ime = model.ime;
            nov.mestonaziveenje = model.mestonaziveenje;
            return View("GetAllFriends", friendsList);
        }
        [HttpPost]
        public ActionResult AddNewFriend(FriendModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("AddNewFriend", model);
            }
            friendsList.Add(model);
            return View("GetAllFriends", friendsList);
        }
        public ActionResult AddNewFriend()
        {
            FriendModel model = new FriendModel();
            return View(model);
        }
    }
}