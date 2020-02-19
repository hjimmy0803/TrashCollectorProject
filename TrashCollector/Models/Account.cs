using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }

        [Display(Name = "Onetime Pickup")]
        DateTime OneTimePickup { get; set; }

        [Display(Name = "Suspend Account")]
        public bool IsSuspended { get; set; }

        [Display(Name = "Start Date")]
        DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        DateTime EndDate { get; set; }

        [Display(Name = "Balance")]
        public double Balance { get; set; } 



        





    }
}
