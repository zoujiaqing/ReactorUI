﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReactorUI.Contracts
{
    public interface IComponentHost : IContentControl
    {
        void Invalidate();
    }
}
