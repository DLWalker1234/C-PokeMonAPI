using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Models
{

    public class Pokemon
    {
        public int PokemonId { get; set; }

        public string PokemonName { get; set; }

        public string PokemonPrice { get; set; }

    }
}
