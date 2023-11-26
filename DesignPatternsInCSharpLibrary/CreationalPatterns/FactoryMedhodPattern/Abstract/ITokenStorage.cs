using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Abstract
{
    public interface ITokenStorage
    {
        public bool AddTokenToStorage(string storageKey);
        public string GetTokenStringFromStorage(string storageKey);
    }
}
