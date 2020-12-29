using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softrayAPI.Models
{
    public class Article
    {
        public static List<Article> articles = new List<Article>(){
        new Article("1", "naslov", "podnaslov", "duzi tekst", "https://picsum.photos/400/500", "admin"),
        new Article("2", "naslov2", "podnaslov2", "duzi tekst2", "https://picsum.photos/400/500", "admin"),
        new Article("3", "naslov3", "podnaslov3", "duzi tekst3", "https://picsum.photos/400/500", "admin2"),
    };
        public string id { get; set; }
        public string naslov { get; set; }
        public string podnaslov { get; set; }
        public string tekst { get; set; }
        public string img { get; set; }
        public string owner { get; set; }


        public Article(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            this.id = v1;
            this.naslov = v2;
            this.podnaslov = v3;
            this.tekst = v4;
            this.img = v5;
            this.owner = v6;
        }

        
    }
}
