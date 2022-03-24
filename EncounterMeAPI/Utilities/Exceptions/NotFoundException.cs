namespace EncounterMeAPI.Utilities.Exceptions
{
    using System;

    public class NotFoundException : Exception
    {
        public NotFoundException() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, System.Exception inner) : base(message, inner) { }
    }
}
