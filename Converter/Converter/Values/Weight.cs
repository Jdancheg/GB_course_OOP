using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Weight : IValue
    {
        public Weight()
        {

        }
        public Weight(double value, string valueFrom, string valueTo)
        {

        }

        public List<string> GetMeasureList()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "Масса";
        }

        public double ToRequired()
        {
            throw new NotImplementedException();
        }

        public double ToSI()
        {
            throw new NotImplementedException();
        }
    }
}
