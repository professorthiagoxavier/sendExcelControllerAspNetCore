using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleAPI.Models
{
    public class Article
    {

        public string Autor { get; set; }
        public string Publicacao { get; set; }

        public string Language { get; set; }

        public List<References> References { get; set; }
    }
}

