﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace CS403_SK.Module.BusinessObjects.ORMDataModel1
{
    [DefaultClassOptions]
    public partial class KhuyenMai
    {
        public KhuyenMai(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
