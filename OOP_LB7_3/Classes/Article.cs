using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OOP_LB7_3.Classes
{
    public class Article
    {
        public Article(string product, double price, string store,int index)
        {
            this._price = price;
            this._product = product;
            this._store = store;
            this._index = index;
        }

        private string _product;
        private double _price;
        private string _store;
        private int _index;

        public string Product
        {
            get { return _product; }
        }

        public string Price
        {
            get { return _price.ToString("C",CultureInfo.CurrentCulture); }
        }

        public string Store
        {
            get { return _store; }
        }

        public int Index
        {
            get { return _index; }
        }
    }
}
