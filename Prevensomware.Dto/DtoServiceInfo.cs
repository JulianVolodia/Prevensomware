﻿using System;

namespace Prevensomware.Dto
{
    public class DtoServiceInfo : DtoBase
    {
        public virtual string Name { get; set; }
        public virtual string SearchPath { get; set; }
        public virtual int Interval { get; set; }
        public virtual DateTime NextServiceRunDateTime { get; set; }
        public virtual DtoUserSettings UserSettings { get; set; }

    }
}

