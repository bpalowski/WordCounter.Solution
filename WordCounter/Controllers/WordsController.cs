using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordsController : Controller
    {
      [HttpGet("/counter")]
        public ActionResult Index()
        {
          List<counter> allWords = counter.GetAll();
          return View(allWords);
        }
        [HttpGet("/counter/new")]
        public ActionResult Form()
        {
          return View();
    }
      [HttpPost("/counter")]
      public ActionResult Create()
      {
        counter newWord = new counter (Request.Form["word"],Request.Form["sentence"]);
        //newWord.Save();
        List<counter> allWords = counter.GetAll();
        //counter.ClearAll();
        return View("Index", allWords);
      }
      [HttpPost("/counter/delete")]
        public ActionResult DeleteAll()
        {
            counter.ClearAll();
            return View();
        }


      }
    }
