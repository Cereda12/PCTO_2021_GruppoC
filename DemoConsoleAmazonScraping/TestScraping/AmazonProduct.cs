﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleScraping
{
    public class AmazonProduct
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Stringa non valida");
                _name = value;
            }
        }
        private decimal _price;
        public decimal price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prezzo non valido");
                _price = value;
            }
        }
        private string _description;
        public string description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Stringa non valida");
                _description = value;
            }
        }
        public AmazonProduct(string Name, decimal Price, string Description)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description))
                throw new Exception("Stringa non valida");
            this.name = Name;
            this.price = Price;
            this.description = Description;
        }
    }
}