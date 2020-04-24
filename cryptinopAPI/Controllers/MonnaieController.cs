using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cryptinopAPI.Affaire.Services;
using cryptinopAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cryptinopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonnaieController : ControllerBase
    {
        IMonnaieService _monnaieService;
        

        public MonnaieController(IMonnaieService monnaieService)
        {
            _monnaieService = monnaieService;
        }

       [HttpGet]
        public IMonnaie Obtenir(int idMonnaie)
        {
           return _monnaieService.Obtenir(idMonnaie);

        }
    }
}