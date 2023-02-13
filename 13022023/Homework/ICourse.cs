using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal interface ICourse
    {
        void AddGroup(Group group);
        Group[] GetGroupsByPointRange(byte min, byte max);
    }
}
