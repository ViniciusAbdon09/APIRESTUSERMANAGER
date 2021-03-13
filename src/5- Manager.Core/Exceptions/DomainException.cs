using System;
using System.Collections.Generic;

namespace Manager.Core.Exceptions{
    public class DomainException : Exception{
        internal List<string> _error; // lista interna de erros

        public IReadOnlyCollection<string> Erros => _error;    // acesso aos erros da lista interna

        public DomainException(){}

        public DomainException(string message, List<string> errors) : base(message){
            _error = errors;
        }

        public DomainException(string message) : base(message){}

        public DomainException(string message, Exception innerException) : base(message, innerException){}
    }
}