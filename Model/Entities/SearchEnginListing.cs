using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class SearchEnginListing : EntityBase
{
    public string? PageTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? Urlhandle { get; set; }
}
