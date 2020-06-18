using System;

namespace IArkanoid
{
    public class TooManyCharactersException : Exception
    {
        public TooManyCharactersException(string message) : base(message){
        }
    }
}