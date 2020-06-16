using System;

namespace OrderApprovalExample
{
    public class Member
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public Member(Guid id, string name, Role role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
    }

    public enum Role { Reader, Writer, ReaderWriter }
}
