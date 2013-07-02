﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mojio
{
    public class Token : GuidEntity
    {
        public override string Type
        {
            get { return "AT"; }
        }

        public Guid AppId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}