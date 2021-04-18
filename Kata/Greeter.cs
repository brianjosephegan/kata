using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public sealed class Greeter
    {
        private readonly string defaultLanguage = "english";

        private readonly Dictionary<string, string> languageToGreetingMaps = new Dictionary<string, string>()
        {
            { "english", "Welcome" },
            { "czech", "Vitejte" },
            { "danish", "Velkomst" },
            { "dutch", "Welkom" },
            { "estonian", "Tere tulemast" },
            { "finnish", "Tervetuloa" },
            { "flemish", "Welgekomen" },
            { "french", "Bienvenue" },
            { "german", "Willkommen" },
            { "irish", "Failte" },
            { "italian", "Benvenuto" },
            { "latvian", "Gaidits" },
            { "lithuanian", "Laukiamas" },
            { "polish", "Witamy" },
            { "spanish", "Bienvenido" },
            { "swedish", "Valkommen" },
            { "welsh", "Croeso" }
        };

        public string Greet(string language)
        {
            if (languageToGreetingMaps.ContainsKey(language))
            {
                return languageToGreetingMaps[language];
            }
            else
            {
                return languageToGreetingMaps[defaultLanguage];
            }
        }
    }
}
