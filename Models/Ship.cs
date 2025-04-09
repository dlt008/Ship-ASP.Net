using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShipDB.Models;

public partial class Ship
{
    [Key]
    [Column("ShipID")]
    public int ShipId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShipName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipType { get; set; }

    public int? YearBuilt { get; set; }

    public int? Capacity { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Owner { get; set; }

    public bool? IsInService { get; set; }
}
