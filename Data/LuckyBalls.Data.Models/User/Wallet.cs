namespace LuckyBalls.Data.Models.User
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LuckyBalls.Data.Common.Models;

    public class Wallet : BaseDeletableModel<string>
    {
        public Wallet()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreditsAmmount = 0m;
        }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal CreditsAmmount { get; set; }
    }
}
