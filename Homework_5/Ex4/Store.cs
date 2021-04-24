using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Store, содержащий закрытый массив элементов типа Article.
//  Обеспечить следующие возможности:
//  • вывод информации о товаре по номеру с помощью индекса;
//  • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,
//  выдать соответствующее сообщение;

namespace Ex4
{
    class Store
    {
        private Article[] store;

        public Store(params Article[] article )
        {
            store = article;
        }

        public string this[int index]
        {
            get
            { 
                if (index >= 0 && index <= store.Length)
                {
                    return $"Имя продукта {store[index].Name}";
                }
                else
                {
                    return "Такого товара нет";
                }
            }
        }
        public string this[string name]
        {
            get
            {
                foreach (var item in store)
                {
                    if (item.Name == name)
                    {
                        return $"Товар: {item.Name}, {item.Cost},{item.ShopName}";
                    }
                    
                }
                return "Такого товара нет";
            }
        }
    }
}
