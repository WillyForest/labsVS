using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using LeaderBoard.Models;


namespace LeaderBoard.Controllers
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class WApiController : Controller
    {
        private LeaderBoardEntities db = new LeaderBoardEntities();
        // GET api/<controller>

        public ICollection<Player> GetPlayer()
        {
            var players = (from Leaders in db.Leaders select Leaders).ToList();
            
            Collection<Player> p = new Collection<Player>();

            foreach (Leader l in players)
            {
                p.Add(new Player { Id = l.PlayerId, Name = l.Name });
            }
            return p;
        }
    }
}