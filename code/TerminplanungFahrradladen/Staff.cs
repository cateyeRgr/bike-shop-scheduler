//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TerminplanungFahrradladen
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int StaffID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Wage { get; set; }
        public decimal Hours { get; set; }
        public Nullable<int> Supervisor { get; set; }
    }
}