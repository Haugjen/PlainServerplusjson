using System;

namespace ModelLibr
{
    public class Car
    {
        private String _model;
        private String _color;
        private String _registrationNumber;

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public string RegistrationNumber
        {
            get => _registrationNumber;
            set => _registrationNumber = value;
        }

        public Car()
        {
        }

        public Car(string model, string color, string registrationNumber)
        {
            _model = model;
            _color = color;
            _registrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegistrationNumber)}: {RegistrationNumber}";
        }
    }
}
