using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_EnigmaMachinePart1_Plugboard
{
    public class Plugboard
    {
        readonly char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        bool[] alphabetFlags = new bool[26]; //an array of booleans that corresponds with the alphabet. 0 -> A, 1 -> B, 2 -> C, etc.
        char[] key;

        public Plugboard(String wires = "")
        {
            this.key = wires.ToCharArray();
            ValidateKey();
        }

        //make sure each letter only occurs once.
        private void ValidateKey()
        {
            ResetAlphabetFlags();

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (key[i] == alphabet[j] && alphabetFlags[j] != true)
                    {
                        Console.WriteLine("Found: " + alphabet[j]);
                        alphabetFlags[j] = true;
                    }
                    else if (key[i] == alphabet[j] && alphabetFlags[j] == true)
                    {
                        Console.WriteLine("Letter " + alphabet[j] + " has already been found.");
                        throw new ArgumentException("Duplicate letter " + alphabet[j] + " has already been found. The key can only contain one occurrence of each letter.");
                    }
                }
            }
        }

        private void ResetAlphabetFlags()
        {
            for (int i = 0; i < alphabetFlags.Length; i++)
            {
                alphabetFlags[i] = false;
            }
        }

        //If the key is shorter than 26 letters then whatever letters are missing need to be added in alphabetical order
        private void FillOutKey(string wires)
        {
            throw new NotImplementedException();

            //get the length.
            //find out which letters are missing
            //add them to the end of the key in alphabetical order
            //return the new key
        }

        //Find the missing letters in the key
        private void FindMissingLetters(string wires)
        {
            
        }

        public char process(char c)
        {
            

            return c;
        }
    }
}

//Take a list of wire pairs at construction in the form of a string, with a default behaviour of no wires configured. E.g. "ABCD" would wire A <-> B and C <-> D.
//Validate that the wire pairings are legitimate. Raise an exception if not.
//Implement the process method to translate a single character input into an output.
//Haskell remarks

//Since Haskell doesn't have classes, plugboard is a function that either returns a Char -&gt; Char function for processing, or an error message.

//Examples

//var plugboard = new Plugboard("ABCDEFGHIJKLMNOPQRST");
//Console.WriteLine(plugboard.process('A'));
//Console.WriteLine(plugboard.process('B'));
//Console.WriteLine(plugboard.process('X'));
//Console.WriteLine(plugboard.process('.'));

//Expected output:
//B
//A
//X
//.