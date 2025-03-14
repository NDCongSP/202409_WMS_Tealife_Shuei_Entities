﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.WMS;

[Table("WarehouseParameters")]
public class WarehouseParameter
{
    [Key] public Guid Id { get; set; }

    public string CompanyName { get; set; }

    public string CompanyAddress { get; set; }

    public string CompanyPhone { get; set; }

    public string CompanyEmail { get; set; }

    public string CompanyFax { get; set; }

    public string CompanyWebsite { get; set; }

    public string InvoiceAddress { get; set; }

    public string CreateOperatorId { get; set; }

    public DateTime? CreateAt { get; set; }

    public string UpdateOperatorId { get; set; }

    public DateTime? UpdateAt { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Status { get; set; }
    public string ReceivingLocation { get; set; }
    public string PutawayLocation { get; set; }
    public string ShipmentLocation { get; set; }
}