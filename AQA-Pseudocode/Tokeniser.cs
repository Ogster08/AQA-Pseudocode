using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQA_Pseudocode
{
    internal class Tokeniser
    {
        private string _Text;
        private int _Pointer;
        public string Text { get{ return _Text; } }

        public Tokeniser(string text)
        {
            _Text = text;
        }  
        
        public List<Token> GetTokens()
        {
            List<Token> tokens = new List<Token>();

            return tokens;
        }

        private Token NextToken()
        {
            if (_Pointer >= _Text.Length)
            {
                return new Token(Tokens.END, null);
            }
            else if (_Pointer + 1 != Text.Length && _Text.Substring(_Pointer, 2) == "<-")
            {
                _Pointer += 2;
                return new Token(Tokens.ASSIGNMENT, null);
            }
            else if (_Text[_Pointer] == '"')
            {
                StringBuilder stringLiteral = new StringBuilder();
                while (_Text[++_Pointer] != '"')
                {
                    stringLiteral.Append(_Text[_Pointer]);
                }
                return new Token(Tokens.STRINGLITERAL, stringLiteral.ToString());
            }
            else if (_Text[_Pointer] == ' ')
            {
                _Pointer++;
                return new Token(Tokens.WHITESPACE, null);
            }
        }
    }
}
