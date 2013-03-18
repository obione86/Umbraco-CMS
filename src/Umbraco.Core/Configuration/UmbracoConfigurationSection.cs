﻿using System.Configuration;

namespace Umbraco.Core.Configuration
{
    // note - still must work on how to support read-only and ResetSection for collections
    // note - still must work on how to spread config over files (aka DeepConfig in v5)

    /// <summary>
    /// Represents an Umbraco section within the configuration file.
    /// </summary>
    /// <remarks>
    /// <para>The requirement for these sections is to be read-only.</para>
    /// <para>However for unit tests purposes it is internally possible to override some values, and
    /// then calling <c>>ResetSection</c> should cancel these changes and bring the section back to
    /// what it was originally.</para>
    /// <para>The <c>UmbracoSettings.For{T}</c> method will return a section, either one that
    /// is in the configuration file, or a section that was created with default values.</para>
    /// </remarks>
    internal abstract class UmbracoConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// Gets a value indicating whether the section actually is in the configuration file.
        /// </summary>
        protected bool IsPresent { get { return ElementInformation.IsPresent; } }

        /// <summary>
        /// Resets settings that were set programmatically, to their initial values.
        /// </summary>
        /// <remarks>>To be used in unit tests.</remarks>
        internal protected virtual void ResetSection()
        { }
    }
}
