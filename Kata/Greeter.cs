using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    /// <summary>
    /// Class to provide a 'greeting' in various languages.
    /// </summary>
    public sealed class Greeter
    {
        /// <summary>
        /// Default to English.
        /// </summary>
        private readonly string defaultLanguage = "english";

        /// <summary>
        /// Map between a language and 'welcome' in that language.
        /// </summary>
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

        /// <summary>
        /// For the specified language, return the appropriate gretting.
        /// Defaults to English greeting, if the specified language is not supported.
        /// </summary>
        /// <param name="language">Language of the greeting.</param>
        /// <returns>Greeting in the specified language.</returns>
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
