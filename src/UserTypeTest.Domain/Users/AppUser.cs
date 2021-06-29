using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace UserTypeTest.Users
{
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }

        //以下为新增的自定义属性
        public virtual UserType Type { get; set; }

        private AppUser()
        {

        }
    }
}
