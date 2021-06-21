using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models.ViewModels
{
    public class SalesFormViewModel
    {
        public ICollection<Seller> Sellers { get; set; }
        public int IdSeller { get; set; }
        public DateTime DateSales { get; set; }
        public int Status { get; set; }
        public double Amount { get; set; }
        public  ICollection<ItemEnumStatus> SalesStatus { get; set; }
    }

    public class ItemEnumStatus {
        public int Indice { get; set; }
        public string Texto { get; set; }
    }
}
