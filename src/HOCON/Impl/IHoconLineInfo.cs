﻿//-----------------------------------------------------------------------
// <copyright file="IHoconLineInfo.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

namespace Hocon
{
    internal interface IHoconLineInfo
    {
        int LineNumber { get; }
        int LinePosition { get; }
    }
}
