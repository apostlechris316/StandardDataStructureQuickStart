/********************************************************************************
 * Standard Data Structure QuickStart Library 
 * 
 * LICENSE: Free to use provided details on fixes and/or extensions emailed to 
 *          chris.williams@readwatchcreate.com
 ********************************************************************************/

namespace StandardDataStructureQuickStart.Data
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Data Transfer Object for a custom field
    /// </summary>
    [DataContract]
    public class CustomField : ICustomField
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomField()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldValue"></param>
        public CustomField(string fieldName, string fieldValue) { FieldName = fieldName; FieldValue = fieldValue; }

        /// <summary>
        /// Name of the field
        /// </summary>
        [DataMember]
        public string FieldName { get; set; }
        /// <summary>
        /// Value of the field
        /// </summary>
        [DataMember]
        public string FieldValue { get; set; }

        public override string ToString()
        {
            return string.Format("<CustomField><FieldName>{0}</FieldName><FieldValue>{1}</FieldValue></CustomField>", FieldName, FieldValue);
        }
    }
}
