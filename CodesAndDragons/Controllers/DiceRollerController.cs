﻿using Microsoft.AspNetCore.Mvc;
using System;
namespace CodesAndDragons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceRollerController : ControllerBase
    {
        private readonly Random _rdn;

        public DiceRollerController(Random rdn)
        {
            _rdn = rdn;
        }

        // GET api/<DiceRollerController>/5
        [HttpGet("{dice},{rolls}")]
        public string Get(int dice, int rolls)
        {
            string response = "";
            int sum;
            int sumTot = 0;

            switch ((Models.Enums.Dices)dice)
            {
                #region d4
                case Models.Enums.Dices.d4:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 4);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                #endregion

                #region d6
                case Models.Enums.Dices.d6:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 6);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                #endregion

                #region d8
                case Models.Enums.Dices.d8:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 8);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                #endregion

                #region d10
                case Models.Enums.Dices.d10:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 10);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                #endregion

                #region d12
                case Models.Enums.Dices.d12:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 12);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                #endregion

                #region d20
                case Models.Enums.Dices.d20:

                    for (int i = 0; i < rolls; i++)
                    {
                        sum = _rdn.Next(1, 20);
                        response += $"{sum}, ";
                        sumTot += sum;
                    }
                    break;
                    #endregion
            }
            return $"Resultados: {response}Total: {sumTot}";
        }
    }
}