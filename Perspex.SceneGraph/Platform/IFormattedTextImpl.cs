﻿// -----------------------------------------------------------------------
// <copyright file="IFormattedTextImpl.cs" company="Steven Kirk">
// Copyright 2014 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Platform
{
    using System;
    using Perspex.Media;

    public interface IFormattedTextImpl : IDisposable
    {
        Size Constraint { get; set; }

        TextHitTestResult HitTestPoint(Point point);

        Rect HitTestTextPosition(int index);

        Size Measure();
    }
}
