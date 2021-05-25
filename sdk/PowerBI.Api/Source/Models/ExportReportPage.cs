// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A single page configuration for the export request
    /// </summary>
    public partial class ExportReportPage
    {
        /// <summary>
        /// Initializes a new instance of the ExportReportPage class.
        /// </summary>
        public ExportReportPage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportReportPage class.
        /// </summary>
        /// <param name="pageName">The page name</param>
        /// <param name="visualName">Visual name to be exported. Should be
        /// provided in case only a single visual from this page is
        /// exported</param>
        /// <param name="bookmark">The bookmark to be applied on the
        /// page</param>
        public ExportReportPage(string pageName, string visualName = default(string), PageBookmark bookmark = default(PageBookmark))
        {
            PageName = pageName;
            VisualName = visualName;
            Bookmark = bookmark;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the page name
        /// </summary>
        [JsonProperty(PropertyName = "pageName")]
        public string PageName { get; set; }

        /// <summary>
        /// Gets or sets visual name to be exported. Should be provided in case
        /// only a single visual from this page is exported
        /// </summary>
        [JsonProperty(PropertyName = "visualName")]
        public string VisualName { get; set; }

        /// <summary>
        /// Gets or sets the bookmark to be applied on the page
        /// </summary>
        [JsonProperty(PropertyName = "bookmark")]
        public PageBookmark Bookmark { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PageName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PageName");
            }
        }
    }
}
