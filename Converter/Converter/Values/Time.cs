using System.Collections.Generic;

namespace Converter
{
    class Time : IValue
    {
        public Time()
        {

        }
        public Time(double value, string valueFrom, string valueTo)
        {

        }
        public List<string> GetMeasureList()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "Время";
        }

        public double ToRequired()
        {
            throw new System.NotImplementedException();
        }

        public double ToSI()
        {
            throw new System.NotImplementedException();
        }
    }
}
