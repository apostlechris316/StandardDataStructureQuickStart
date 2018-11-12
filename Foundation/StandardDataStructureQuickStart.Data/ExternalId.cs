/********************************************************************************
 * Standard Data Structure QuickStart Library 
 * 
 * LICENSE: Free to use provided details on fixes and/or extensions emailed to 
 *          chris.williams@readwatchcreate.com
 ********************************************************************************/

namespace StandardDataStructureQuickStart.Data
{
    /// <summary>
    /// Data Transfer Object for an external id
    /// </summary>
    public class ExternalId : IExternalId
    {
        /// <summary>
        /// Unique Name Object Type from External Source
        /// </summary>
        public string SourceObjectType { get; set; }

        /// <summary>
        /// Unique Id Representing the object in the external source
        /// </summary>
        public string Id { get; set; }
    }
}
