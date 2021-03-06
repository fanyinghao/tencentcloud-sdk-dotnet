/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanSetInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务状态: 1-已完成,2-处理中,3-处理出错,4-处理超时
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// app信息
        /// </summary>
        [JsonProperty("AppDetailInfo")]
        public AppDetailInfo AppDetailInfo{ get; set; }

        /// <summary>
        /// 病毒信息
        /// </summary>
        [JsonProperty("VirusInfo")]
        public VirusInfo VirusInfo{ get; set; }

        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonProperty("VulInfo")]
        public VulInfo VulInfo{ get; set; }

        /// <summary>
        /// 广告插件信息
        /// </summary>
        [JsonProperty("AdInfo")]
        public AdInfo AdInfo{ get; set; }

        /// <summary>
        /// 提交扫描的时间
        /// </summary>
        [JsonProperty("TaskTime")]
        public ulong? TaskTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamObj(map, prefix + "AppDetailInfo.", this.AppDetailInfo);
            this.SetParamObj(map, prefix + "VirusInfo.", this.VirusInfo);
            this.SetParamObj(map, prefix + "VulInfo.", this.VulInfo);
            this.SetParamObj(map, prefix + "AdInfo.", this.AdInfo);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
        }
    }
}

