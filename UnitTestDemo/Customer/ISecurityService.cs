﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestDemo
{
    public interface ISecurityService
    {
        bool HasAccess(long userId);
    }
}
