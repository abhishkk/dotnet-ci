// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
/*=============================================================================
**
**
**
** Purpose: Enums for the priorities of a Thread
**
**
=============================================================================*/

using System.Threading;

namespace System.Threading
{
    [Serializable]
    public enum ThreadPriority
    {
        /*=========================================================================
        ** Constants for thread priorities.
        =========================================================================*/
        Lowest = 0,
        BelowNormal = 1,
        Normal = 2,
        AboveNormal = 3,
        Highest = 4
    }
}