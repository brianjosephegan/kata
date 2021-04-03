using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    /// <summary>
    /// Class to alternate the case of strings.
    /// </summary>
    public sealed class CaseAlternater
    {
        /// <summary>
        /// Switches the case on any letter in the specified input.
        /// </summary>
        /// <param name="input">String to switch case of letters.</param>
        /// <returns>Specified input with letters in alternate case.</returns>
        public string AlternateCase(string input) => new string(input.Select(c => char.IsLetter(c) ? ToAlternate(c) : c).ToArray());

        /// <summary>
        /// Switches the case on the specified character.
        /// </summary>
        /// <remarks>Assumes that specified character is a letter.</remarks>
        /// <param name="c">Character to switch case of.</param>
        /// <returns>Specified character with switched case.</returns>
        private char ToAlternate(char c) => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
    }
}
