﻿using System.ComponentModel.DataAnnotations;

namespace FBT.ShareModels;

public class ArrivalInstructionDetail
{
    [Key] public int Id { get; set; }

    public int? ScheduledArrivalNumber { get; set; }

    public string ProductCode { get; set; }

    public string ProductName { get; set; }

    public int? Quantity { get; set; }

    public string CreateOperatorId { get; set; }

    public DateTime? CreateAt { get; set; }

    public string UpdateOperatorId { get; set; }

    public DateTime? UpdateAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string Status { get; set; }

    public string Remarks { get; set; }
}