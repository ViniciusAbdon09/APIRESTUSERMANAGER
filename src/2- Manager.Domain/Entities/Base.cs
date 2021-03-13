using System.Collections.Generic;

namespace Manager.Domain.Entities{
    public abstract class Base{
        public long Id { get; set; }

        internal List<string> _errors; // propriedade interna

        public IReadOnlyCollection<string> Errors => _errors; //somente leitura do metodo interno
        
        public abstract bool Validate(); // metodo de validação


    }
}
