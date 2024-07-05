// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextCellDefinition.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// <summary>
//   Defines a cell that contains a string property.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataGridExt
{
    /// <summary>
    /// Defines a cell that contains a string property.
    /// </summary>
    /// <seealso cref="DataGridExt.CellDefinition" />
    public class TextCellDefinition : CellDefinition
    {
        /// <summary>
        /// Gets or sets the maximum length.
        /// </summary>
        /// <value>
        /// The maximum length.
        /// </value>
        public int MaxLength { get; set; }
    }
}