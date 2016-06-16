// Copyright (c) Imazen LLC.
// No part of this project, including this file, may be copied, modified,
// propagated, or distributed except as permitted in COPYRIGHT.txt.
// Licensed under the Apache License, Version 2.0.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizer.Plugins
{
    public interface IFileSignatureProvider
    {

        IEnumerable<FileSignature> GetSignatures();
    }
}
