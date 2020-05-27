using Casino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Casino.Controllers
{
    public class HomeController : Controller
    {
        
      
       
        public ActionResult Index()
        {
            
            //StringBuilder sb = new StringBuilder();
            //List<Card> mylist = game.deck;
          

            return View();
        }


        public ActionResult StartGame(Game game)
        {
            game.StartGame();
            
            return RedirectToAction("GameFace");
        }

        // user hit
        public ActionResult UserHit(Game game)
        {
            game.UserHit();

            return RedirectToAction("GameFace");
        }

        public ActionResult GameFace(Game game)
        {
           

            return View(game);
        }

        // user stand
        public ActionResult Stand( Game game)
        {
            game.UserPushedStand();

            return RedirectToAction("GameFace");
        }


        public ActionResult StartBid(int amount, Game game)
        {
            game.startDeal(amount);
            game.coinFace = amount+"coin";

           return RedirectToAction("GameFace");
        }

        public ActionResult Deal(Game game)
        {
            game.Deal();

            return RedirectToAction("GameFace");
        }


        //reset the game
        public ActionResult Reset(Game game)
        {
            game.reset();
            return RedirectToAction("Index");
        }

        //coming soon page
        public ActionResult comingsoonPage()
        {
            return View();
        }
    }
}