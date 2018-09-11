using System;
using System.Collections.Generic;
using System.Text;
using ModelLibr;

namespace ModelLib
{
    public class AutoSale
    {
        private string _name;
        private string _address;
        private List<Car> _cars;

        public AutoSale():this("Dummy","DummyStreet")
        {
        }

        public AutoSale(string name, string address)
        {
            _name = name;
            _address = address;
            _cars = new List<Car>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public List<Car> Cars
        {
            get => _cars;
            set => _cars = value;
        }

        public override string ToString()
        {
            String CarListStr = String.Join("Next car = ", Cars);
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}, {nameof(Cars)}: {CarListStr}";
        }
    }
}
