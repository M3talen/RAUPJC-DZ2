using System;

namespace Zad1
{
    public class DuplicateTodoItemException : Exception
    {
        public DuplicateTodoItemException() : base("Item with same ID already in base.")
        {
        }
    }
}