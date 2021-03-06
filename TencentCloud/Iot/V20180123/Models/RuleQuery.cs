/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iot.V20180123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleQuery : AbstractModel
    {
        
        /// <summary>
        /// 字段
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 过滤规则
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
        }
    }
}

