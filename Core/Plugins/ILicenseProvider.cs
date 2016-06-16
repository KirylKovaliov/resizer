// Copyright (c) Imazen LLC.
// No part of this project, including this file, may be copied, modified,
// propagated, or distributed except as permitted in COPYRIGHT.txt.
// Licensed under the Apache License, Version 2.0.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizer.Plugins {
    /// <summary>
    /// Provides a place to cache/store licenses. Only responsible for licenses used by plugins attached to the current Config instance.
    /// </summary>
    public interface ILicenseProvider:IPlugin {
        /// <summary>
        /// Returns a collection containing all licenses for the plugin's Config instance, in their native form
        /// </summary>
        /// <returns></returns>
        ICollection<string> GetLicenses();
    }
}
