using System;

namespace IArkanoid
{
    public class HasNotPlayedGameException : Exception
    {
        public HasNotPlayedGameException(string message) : base(message){
        }
    }
}