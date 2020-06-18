using System;

namespace IArkanoid
{
    public class OtherKeyException : Exception
    {
        public OtherKeyException(string message) : base(message){
        }
    }
}