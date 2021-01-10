﻿using System.Threading.Tasks;
using dotnet_rpg.Dtos.Fight;
using dotnet_rpg.services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FightController : Controller
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

    }
}

