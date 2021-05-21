﻿using CodesAndDragons.Domain.Models.Enums;

namespace CodesAndDragons.Domain.Models
{
    public class Player
    {
        #region Propriedades
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string CharName { get; set; }
        public Race CharRace { get; set; }
        public Class CharClass { get; set; }
        public string CharDescription { get; set; }
        public int LifePoints { get; set; }
        public int ArmorClass { get; set; }
        public string PlayerAttributtes { get; set; }
        #endregion
    }
}
