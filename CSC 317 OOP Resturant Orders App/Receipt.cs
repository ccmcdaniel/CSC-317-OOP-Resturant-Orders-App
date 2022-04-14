using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_317_OOP_Resturant_Orders_App
{
    [Serializable]
    public class Receipt
    {
        private string[] _orderedItems;
        public string? ReceiptId { get; set; }
        public string? Server { get; set; }
        public string? TableNumber { get; set; }

        public string[]? OrderedItems 
        {
            get
            {
                return _orderedItems;
            }

            set
            {
                _orderedItems = new string[value.Length];

               for(int i = 0; i < value.Length; i++)
                    _orderedItems[i] = value[i];
                    
            }
        
        }  
        
    }
}
