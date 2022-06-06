using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        Dictionary<string, int> converter = new Dictionary<string, int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            converter.Add("zero", 0);
            converter.Add("one", 1);
            converter.Add("two", 2);
            converter.Add("three", 3);
            converter.Add("four", 4);
            converter.Add("five", 5);
            converter.Add("six", 6);
            converter.Add("seven", 7);
            converter.Add("eight", 8);
            converter.Add("nine", 9);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            word = word.ToLower();
            if (converter.ContainsKey(word))
            {
                return converter[word];
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
