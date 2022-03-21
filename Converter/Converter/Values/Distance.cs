using System.Collections.Generic;

namespace Converter
{
    class Distance : IValue
    {
        public Distance() { }
        public Distance(double value, string valueFrom, string valueTo)
        {
            _valueFrom = valueFrom;
            _valueTo = valueTo;
            _value = value;
        }
        private double _value;
        private string _valueFrom;
        private string _valueTo;
        private static string _valueName = "Длина";
        private List<string> _measureList = new List<string>()
        {
            "Микрометр",
            "Миллиметр",
            "Сантиметр",
            "Дециметр",
            "Метр",
            "Километр"
        };        
        public string GetName()
        {
            return _valueName;
        }
        public List<string> GetMeasureList()
        {
            return _measureList;
        }
        public double ToSI()
        {
            switch(_valueFrom)
            {
                case "Микрометр": return _value / 1000000;                    
                case "Миллиметр": return _value / 1000;
                case "Сантиметр": return _value / 100;
                case "Дециметр": return _value / 10;
                case "Метр": return _value;
                case "Километр": return _value * 1000;
                default: return 0;
            }
        }
        public double ToRequired()
        {
            double valueInSI = ToSI();
            switch (_valueTo)
            {
                case "Микрометр": return valueInSI * 1000000;
                case "Миллиметр": return valueInSI * 1000;
                case "Сантиметр": return valueInSI * 100;
                case "Дециметр": return valueInSI * 10;
                case "Метр": return valueInSI;
                case "Километр": return valueInSI / 1000;
                default: return 0;
            }
        }
    }
}
