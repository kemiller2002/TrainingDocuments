using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{

    public interface IGetName
    {
        string FirstName { get; }
        string LastName { get; }
        string SortLettersNames(string firstName, string lastName);
        
    }

    public class PrintNames
    {

        IGetName _getName;

        public PrintNames(IGetName getName)
        {
            _getName = getName;
        }

        public string GetFirstName()
        {
            return _getName.FirstName;
        }

    }
    public class IOC
    {
        public PrintNames ReturnPrintNames()
        {
            throw new NotImplementedException();
        }
    }
}
