﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Mojio
{
    public abstract partial class BaseEntity
    {
        [JsonProperty(PropertyName = "_rev")]
        public string Revision { get; set; }

        [JsonProperty(PropertyName = "_deleted")]
        public bool Delete { get; set; }

        [JsonIgnore]
        public abstract string IdToString { get; }
    }

    public abstract class Entity<TId> : BaseEntity
    {
        [JsonProperty(PropertyName = "_id")]
        public virtual TId Id { get; set; }

        [JsonIgnore]
        public override string IdToString
        {
            get { return Id.ToString(); }
        }
    }

    public abstract class GuidEntity : Entity<Guid>
    {
        public void EnsureId()
        {
            if (Id == Guid.Empty)
                Id = Guid.NewGuid();
        }
    }

    public abstract class StringEntity : Entity<string>
    {

    }
}
