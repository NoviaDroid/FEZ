﻿// Type: SharpDX.Win32.CommitFlags
// Assembly: SharpDX, Version=2.4.2.0, Culture=neutral, PublicKeyToken=627a3d6d1956f55a
// MVID: 578390A1-1524-4146-8C27-2E9750400D7A
// Assembly location: F:\Program Files (x86)\FEZ\SharpDX.dll

using System;

namespace SharpDX.Win32
{
  [Flags]
  public enum CommitFlags
  {
    Default = 0,
    Overwrite = 1,
    OnlyCurrent = 2,
    DangerouslyCommitMerelyToDiskCache = 4,
    Consolidate = 8,
  }
}
