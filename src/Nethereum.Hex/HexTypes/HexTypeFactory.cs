using System;
using System.Numerics;

namespace Nethereum.Hex.HexTypes
{
    public class HexTypeFactory
    {
        public static object CreateFromHex<T>(string hex)
        {
            if (typeof (BigInteger) == typeof(T))
            {
                return new HexBigInteger(hex);
            }

            if (typeof(String) == typeof(T))
            {
                return HexUTF8String.CreateFromHex(hex);
            }
            throw new NotImplementedException();
        }
    }
}