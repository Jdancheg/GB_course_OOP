using System.Collections.Generic;

namespace Converter
{
    public interface IValue
    {        
        string GetName();          // название физической величины
        List<string> GetMeasureList();  // список единиц измерения
        double ToSI();                  // функция перевода в СИ
        double ToRequired();            // функция перевода в требуемую единицу
    }
}
