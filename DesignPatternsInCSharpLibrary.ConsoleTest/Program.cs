// See https://aka.ms/new-console-template for more information


using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Enum;
using DesignPatternsInCSharpLibrary.CreationalPatterns.FactoryMedhodPattern.Provider;


// Factory Method Pattern
var storageKey = "1234";

var storage = TokenStorageProvider.GetTokenStorage(ETokenStorage.DBTokenStorage);
storage.AddTokenToStorage(storageKey);
storage.GetTokenStringFromStorage(storageKey);

Console.WriteLine("Program Ended...");