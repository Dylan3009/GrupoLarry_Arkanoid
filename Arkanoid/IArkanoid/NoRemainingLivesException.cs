using System;

namespace IArkanoid
{
    public class NoRemainingLivesException : Exception
    {
        public NoRemainingLivesException(string message) : base(message){
        }
    }
}