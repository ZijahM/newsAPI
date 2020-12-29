using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using softrayAPI.Models;

namespace softrayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        public List<Article> vijesti = Article.articles;

        [HttpGet]
        public List<Article> Get()
        {
            return vijesti;
        }

        [HttpPost, Authorize]
        public IActionResult InsertArticle (string id, string naslov, string podnaslov, string text, string img, string owner)
        {
            bool patched = false;

            //FOR THE UPDATE METHOD
            foreach (Article item in vijesti)
            {
                if (item.id==id)
                {
                    item.naslov = naslov;
                    item.podnaslov = podnaslov;
                    item.img = img;
                    item.tekst = text;
                    patched = true;
                    return StatusCode(201);
                }
            }
            //END OF UPDATE METHOD
            if (patched == false)
            {
                Article article = new Article(id, naslov, podnaslov, text, img, owner);
                this.vijesti.Add(article);
                return StatusCode(201);
            }
           return StatusCode(201);
        }

        [HttpDelete, Authorize]
        public IActionResult DeleteArticle(string ID)
        {
            this.vijesti.RemoveAll(articles => articles.id == ID);
            return StatusCode(200);
        }

        [HttpPatch, Authorize]
        public IActionResult EditArticle(string id, string naslov, string podnaslov, string text, string img)
        {
            foreach (Article item in vijesti)
            {
                if (item.id == id)
                {
                    item.naslov = naslov;
                    item.podnaslov = podnaslov;
                    item.tekst = text;
                    item.img = img;
                }
            }

            return StatusCode(200);
        }
    }
}