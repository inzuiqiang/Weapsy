﻿using System;
using System.Collections.Generic;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Pages.Events
{
    public class PageCreated : Event
    {
        public Guid SiteId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public PageStatus Status { get; set; }
        public ICollection<PageLocalisation> PageLocalisations { get; set; }
    }
}