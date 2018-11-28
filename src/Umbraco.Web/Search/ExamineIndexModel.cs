﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Examine;

namespace Umbraco.Web.Search
{
    [DataContract(Name = "indexer", Namespace = "")]
    public class ExamineIndexModel 
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "healthStatus")]
        public string HealthStatus { get; set; }

        [DataMember(Name = "providerProperties")]
        public IReadOnlyDictionary<string, object> ProviderProperties { get; set; }

    }
}