using System;
using System.Collections.Generic;
using System.Reflection;

namespace Converter
{
    class Converter
    {
        /// <summary>
        /// Метод, куда добавляются физические величины по мере реализации соответствующего класса величины
        /// </summary>
        private List<IValue> _valuesList = new List<IValue>()
        {
            new Distance(),
            new Time(),
            new Weight()
        };
        
        /// <summary>
        /// Метод получения списка физических величин, для которых реализована конвертация
        /// </summary>
        /// <returns></returns>
        public List<string> GetValuesList()
        {
            List<string> valuesList = new List<string>();
            foreach (IValue value in _valuesList)
            {
                valuesList.Add(value.GetName());
            }
            return valuesList;
        }

        /// <summary>
        /// Метод получения списка единиц измерения для выбранной физической величины
        /// </summary>
        /// <param name="valueName">Имя физической величины</param>
        /// <returns></returns>
        public List<string> GetMeasureList(string valueName)
        {
            List<string> measureList = new List<string>();
            foreach (IValue value in _valuesList)
            {
                if(value.GetName() == valueName)
                {
                    measureList = value.GetMeasureList();
                }
            }
            return measureList;
        }

        public double GetConvertedValue(string valueName, string from, string to, double currentValue)
        {
            double result = 0;

            // это нужно улучшить! - чтобы автоматически добавлялось 

            List<IValue> valuesList = new List<IValue>()
            {
                new Distance(currentValue, from, to),
                new Time(currentValue, from, to),
                new Weight(currentValue, from, to)
            };
            foreach (IValue value in valuesList)
            {
                if (value.GetName() == valueName)
                    result = value.ToRequired();
            }
            return result;
        }
    }
}
