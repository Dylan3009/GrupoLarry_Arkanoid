using System;

namespace IArkanoid
{
    public class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException(string message) : base(message){
        }
    }
}