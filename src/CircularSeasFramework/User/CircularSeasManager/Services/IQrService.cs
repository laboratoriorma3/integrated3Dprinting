﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CircularSeasManager.Services
{
    public interface IQrService
    {
        Task<string> ScanAsync();
    }
}
