using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal  class ShoppingCart
    {
        public List<Item> _items;
        public Item this[int index]
        {
            get
            {
                return _items[index];
            }
            set 
            {  
                _items[index] = value;
            }
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
    }
}
