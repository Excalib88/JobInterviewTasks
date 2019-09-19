using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEngine.Enums
{
    public enum TokenType
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        OpenBracket = 5,
        CloseBracket = 6,
        Constant = 7,
        Variable = 8,
        Equal = 9,
        End = 10
    }
}
