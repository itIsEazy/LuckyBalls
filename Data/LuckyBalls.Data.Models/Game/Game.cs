namespace LuckyBalls.Data.Models.Game
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LuckyBalls.Data.Common.Models;

    public class Game : BaseDeletableModel<string>
    {
        public Game()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Rules { get; set; }

        [Required]
        public string CreatorFullName { get; set; }
    }
}
