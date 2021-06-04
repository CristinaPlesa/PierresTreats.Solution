using System.Collections.Generic;
using System.IO;
using System;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public virtual ApplicationUser User { get; set; }
    public int TreatId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get; }    
  }
}