using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Abstract;
using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Concrete;
using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Provider
{
    public static class TokenStorageProvider
    {
        public static ITokenStorage GetTokenStorage(ETokenStorage tokenStorage)
        {
            switch (tokenStorage)
            {
                case ETokenStorage.DBTokenStorage:
                    return new DBTokenStorage();
                case ETokenStorage.InMemorytokenStorage:
                    return new InMemoryTokenStorage();
                case ETokenStorage.Cloudtokenstorage:
                    return new CloudTokenStorage();
                default:
                    throw new NotImplementedException("Token Storage Not Supported.");
            }
        }
    }
}
