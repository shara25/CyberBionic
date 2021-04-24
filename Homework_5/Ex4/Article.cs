using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Article, содержащий следующие закрытые поля:
//  • название товара;
//  • название магазина, в котором продается товар;
//  • стоимость товара в гривнах.

namespace Ex4
{
    class Article
    {
        public string Name { get; set; }
        public string ShopName { get; set; }
        public double Cost { get; set; }

        public Article(string name,string shopName,double cost)
        {
            this.Name = name;
            this.ShopName = shopName;
            this.Cost = cost;
        }
    }
}
