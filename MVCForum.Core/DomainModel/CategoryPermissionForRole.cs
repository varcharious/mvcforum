﻿using System;

namespace MVCForum.Domain.DomainModel
{
    public class CategoryPermissionForRole : Entity
    {
        public Guid Id { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual MembershipRole MembershipRole { get; set; }
        public virtual Category Category { get; set; }
        public bool IsTicked { get; set; }
    }
}