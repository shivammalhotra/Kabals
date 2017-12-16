using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kabals.Notifications
{
    public interface ISubject
    {
        void Notify();
        void Attach();
        void Detach();
    }
}