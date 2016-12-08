using System;

namespace SwaggerWcf.Attributes
{
    /// <summary>
    ///     Attribute to describe a class as a definition on swagger
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SwaggerWcfDefinitionAttribute : Attribute
    {
        /// <summary>
        ///     Configures a description with more information
        /// </summary>
        /// <param name="externalDocsDescription">Description external docs description</param>
        /// <param name="externalDocsUrl">Description external docs URL</param>
        public SwaggerWcfDefinitionAttribute(string externalDocsDescription = null,
                                             string externalDocsUrl = null,
                                             string name = null)
        {
            ExternalDocsDescription = externalDocsDescription;
            ExternalDocsUrl = externalDocsUrl;
            Name = name;
        }

        /// <summary>
        ///     Name of the definition
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///     Description of the external documentation
        /// </summary>
        public string ExternalDocsDescription { get; set; }

        /// <summary>
        ///     URL of the external documentation
        /// </summary>
        public string ExternalDocsUrl { get; set; }
    }
}
