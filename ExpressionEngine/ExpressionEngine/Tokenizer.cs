using ExpressionEngine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEngine
{
    public class Tokenizer
    {
        private string _expression;

        int currentSymbolPosition;
        char currentSymbol;

        public Tokenizer(string expression)
        {
            _expression = expression;
        }

        public Token GetNextToken()
        {
            if (currentSymbol == _expression.Length - 1) return null;

            if (char.IsWhiteSpace(currentSymbol))
            {
                nextSymbol();
            }

            switch(currentSymbol) 
            {
                case '+':
                    return new Token { Type = TokenType.Addition };
                case '-':
                    return new Token { Type = TokenType.Subtraction };
                case '*':
                    return new Token { Type = TokenType.Multiplication };
                case '/':
                    return new Token { Type = TokenType.Division };
                case '(':
                    return new Token { Type = TokenType.OpenBracket };
                case ')':
                    return new Token { Type = TokenType.CloseBracket };
                case '=':
                    return new Token { Type = TokenType.Equal };
            }

            if (char.IsDigit(currentSymbol) || currentSymbol == '.')
            {
                var sbNumber = new StringBuilder();
                var havePoint = false;

                while (char.IsDigit(currentSymbol) || 
                      (!havePoint && currentSymbol == '.'))
                {
                    sbNumber.Append(currentSymbol);
                    nextSymbol();
                }

                return new Token
                {
                    Type = TokenType.Constant,
                    Value = sbNumber.ToString()
                };
            }

            if (char.IsLetter(currentSymbol))
            {
                var sbVariable = new StringBuilder();

                while (char.IsLetter(currentSymbol))
                {
                    sbVariable.Append(currentSymbol);
                    nextSymbol();
                }

                return new Token
                {
                    Type = TokenType.Variable,
                    Value = sbVariable.ToString()
                };
            }

            throw new FormatException($"Invalid data format. Unexpected data: {currentSymbol}");
        }

        private void nextSymbol() => 
            currentSymbol = _expression[currentSymbolPosition++];
    }
}
