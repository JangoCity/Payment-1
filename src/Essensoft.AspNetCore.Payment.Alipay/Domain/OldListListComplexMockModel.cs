using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OldListListComplexMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class OldListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂模型list
        /// </summary>
        [JsonProperty("cm_list")]
        [XmlArray("cm_list")]
        [XmlArrayItem("old_complext_mock_model")]
        public List<OldComplextMockModel> CmList { get; set; }
    }
}
