using ExpressionEngine.Enums;

namespace ExpressionEngine
{
    public class Token
    {
        public TokenType Type { get; set; }

        /// <summary>
        /// optional
        /// Use if TokenType is Variable
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// optional
        /// Use if TokenType is Variable or Number
        /// </summary>
        public string Value { get; set; }
    }
}
