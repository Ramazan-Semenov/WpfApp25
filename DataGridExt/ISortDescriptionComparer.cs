using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExt
{
    /// <summary>
    /// Defines a comparer that uses a collection of sort descriptions.
    /// </summary>
    /// <seealso cref="System.Collections.IComparer" />
    public interface ISortDescriptionComparer : IComparer
    {
        /// <summary>
        /// Gets the sort descriptions.
        /// </summary>
        /// <value>
        /// The sort descriptions.
        /// </value>
        SortDescriptionCollection SortDescriptions { get; }
    }
}
