﻿using System.Collections.Generic;

namespace WindowsFormsCSE.Model
{
    public class Receipt
    {
        private List<Item> itemList;
        private string shopName;
        private string receiptString;

        public Receipt(string receiptString)
        {
            this.receiptString = receiptString;
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
            }
        }

        public Item this[int index]
        {
            get => itemList[index];
            set => itemList[index] = value;
        }

    }
}
