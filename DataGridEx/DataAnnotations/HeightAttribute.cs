﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HeightAttribute.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// <summary>
//   Specifies the heights of the property control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataGridEx.DataAnnotations
{
    using System;

    /// <summary>
    /// Specifies the heights of the property control.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class HeightAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeightAttribute" /> class.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="minHeight">Height of the min.</param>
        /// <param name="maxHeight">Height of the max.</param>
        public HeightAttribute(double height, double minHeight = double.NaN, double maxHeight = double.NaN)
        {
            this.Height = height;
            this.MinimumHeight = minHeight;
            this.MaximumHeight = maxHeight;
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        /// <value>The maximum height.</value>
        public double MaximumHeight { get; set; }

        /// <summary>
        /// Gets or sets the minimum height.
        /// </summary>
        /// <value>The minimum height.</value>
        public double MinimumHeight { get; set; }
    }
}