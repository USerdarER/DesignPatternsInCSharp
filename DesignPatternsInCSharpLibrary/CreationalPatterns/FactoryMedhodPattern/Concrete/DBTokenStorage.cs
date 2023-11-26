using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Concrete
{
    public class DBTokenStorage : ITokenStorage
    {
        public bool AddTokenToStorage(string storageKey)
        {
            Console.WriteLine(string.Format("Adding token to DB storage with key: {0}", storageKey));
            return true;
        }

        public string GetTokenStringFromStorage(string storageKey)
        {

            Console.WriteLine(string.Format("Token retrived from DB storage for key: {0}", storageKey));
            return "Needs Implementation.";
        }
       
    }
}
