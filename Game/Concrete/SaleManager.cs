using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrete
{
    class SaleManager:ISaleManager
    {
        public void Add(Sale sale)
        {
            Console.WriteLine(sale.SaleId+" Id'li "+sale.SaleName+" adlı kampanya eklendi.");
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine(sale.SaleId + " Id'li " + sale.SaleName + " adlı kampanya silindi.");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine(sale.SaleId + " Id'li " + sale.SaleName + " adlı kampanya güncellendi.");
        }
    }
}
