using System;
using System.Runtime.Serialization;

namespace testlib{
    public class StringException : Exception
    {
        public StringException() { }
        public StringException(string message) : base(message) { }
        public StringException(string message, Exception innerException) : base(message, innerException) { }

        public override string Message {
            get {
                return "your string contains the following non-alphabetical characters";
            }
        }      
    }
}