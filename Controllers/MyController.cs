using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FighterApp.Controllers
{
    [ApiController]
    [Route("SFV")]
    public class MyController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepository _repository;

        public MyController(ILogger<WeatherForecastController> logger, IRepository repo)
        {
            _logger = logger;
            _repository = repo;
        }

        [HttpPost]
        [Route("Start/{id1}/{id2}")]
        public async Task<Game> StartGameAsync(int id1, int id2)
        {
            return await _repository.StartGame(id1, id2);
        }

        [HttpPost]
        [Route("Winner/{id}")]
        public async Task<Fighter> InputWinner(int id)
        {
            return await _repository.InputWinner(id);
        }
        [HttpPost]
        [Route("Loser/{id}")]
        public async Task<Fighter> InputLoser(int id)
        {
            return await _repository.InputLoser(id);
        }

        [HttpPost]
        [Route("AddAll")]
        public void AddAllCharactersToDb()
        {
            _repository.AddAllCharactersToDatabase();
        }
        [HttpPost]
        [Route("ResetAll")]
        public async Task<String> ResetAll()
        {
            return await _repository.ResetallCharacterData();
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Message"] = "Your application description page.";
            await _repository.StartGame(1, 2);
            return View();
        }


    }
}
