﻿namespace IP_Web.Models;

public class CareBandDbSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string LimitParamCollectionName { get; set; } = null!;
    public string TestCollectionName { get; set; } = null!;
}