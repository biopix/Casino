using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Casino.Models
{
    public class GameBindModel :IModelBinder
    {
        private const string SessionKey = "Game";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Game game = null;

            if (controllerContext.HttpContext.Session != null)
            {
                game = (Game)controllerContext.HttpContext.Session[SessionKey];
            }
            if (game == null)
            {
                game = new Game();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[SessionKey] = game;
                }
            }
            return game;
        }
    }
}