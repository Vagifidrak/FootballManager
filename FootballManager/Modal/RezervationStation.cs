//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballManager.modal
{
    using System;
    using System.Collections.Generic;
    
    public partial class RezervationStation
    {
        public int ID { get; set; }
        public int StationID { get; set; }
        public int WorkerID { get; set; }
        public int UserID { get; set; }
        public Nullable<System.DateTime> StartResDate { get; set; }
        public Nullable<System.DateTime> EndResDate { get; set; }
        public Nullable<int> RoomID { get; set; }
    
        public virtual Station Station { get; set; }
        public virtual User User { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ChangeRoom ChangeRoom { get; set; }
    }
}
