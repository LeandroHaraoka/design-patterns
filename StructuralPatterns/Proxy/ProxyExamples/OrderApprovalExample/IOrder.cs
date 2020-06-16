using System;
using System.Collections.Generic;
using System.Text;

namespace OrderApprovalExample
{
    public interface IOrder
    {
        void Approve(Member approver);
    }
}
