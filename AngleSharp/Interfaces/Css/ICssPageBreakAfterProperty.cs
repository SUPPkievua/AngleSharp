﻿namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// Represents the CSS page-break-after property.
    /// </summary>
    public interface ICssPageBreakAfterProperty : ICssProperty
    {
        /// <summary>
        /// Gets the selected break mode.
        /// </summary>
        BreakMode Mode { get; }
    }
}
