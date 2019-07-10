using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace MS1.Controllers{
    [Route("api/[controller]")]
    public class CotacaoController : ControllerBase
    {
        // GET api/cotacao/<moeda>
        [HttpGet("{moeda}")]
        public double Get(string moeda)
        {
            Console.WriteLine($"get cotação -> {moeda}");
            return 3.86;
        }
    }
}