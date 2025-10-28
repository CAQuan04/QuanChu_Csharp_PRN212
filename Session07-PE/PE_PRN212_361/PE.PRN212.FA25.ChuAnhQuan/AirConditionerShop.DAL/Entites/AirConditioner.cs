using System;
using System.Collections.Generic;

namespace AirConditionerShop.DAL.Entites;

public partial class AirConditioner
{
    public int AirConditionerId { get; set; }

    public string AirConditionerName { get; set; } = null!;

    public string? Warranty { get; set; }

    public string? SoundPressureLevel { get; set; }

    public string? FeatureFunction { get; set; }

    public int? Quantity { get; set; }

    public double? DollarPrice { get; set; }

    public string? SupplierId { get; set; }//FK, trỏ đến mã nhà cung cấp, nhà sản xuất

    public virtual SupplierCompany? Supplier { get; set; }
    //                              JOIN TO TABLE SupplierCompany
}
