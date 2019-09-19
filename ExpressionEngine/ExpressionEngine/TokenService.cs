using ExpressionEngine.Enums;
using System.Collections.Generic;

namespace ExpressionEngine
{
    public class TokenService: ITokenService
    {
        private readonly Tokenizer _tokenizer;

        private Token token;
        private string expression;

        public TokenService(Tokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        public void SetExpression(string expression)
            => this.expression = expression;

        public List<Token> GetAll()
        {
            var tokens = new List<Token>();

            while(token.Type != TokenType.End)
            {
                token = _tokenizer.GetNextToken();

                tokens.Add(token);
            }
            
            return tokens;
        }

        public Token Get()
        {
            token = _tokenizer.GetNextToken();

            return token;
        }
    }
}
