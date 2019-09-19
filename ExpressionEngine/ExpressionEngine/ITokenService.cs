using ExpressionEngine.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEngine
{
    public interface ITokenService
    {
        List<Token> GetAll();
        Token Get();
    }
}
