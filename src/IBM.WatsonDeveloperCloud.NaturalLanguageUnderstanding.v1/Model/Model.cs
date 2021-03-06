/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model
{
    /// <summary>
    /// Model.
    /// </summary>
    public class Model : BaseModel
    {
        /// <summary>
        /// Shows as available if the model is ready for use.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        /// <summary>
        /// Unique model ID.
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }
        /// <summary>
        /// ISO 639-1 code indicating the language of the model.
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        /// <summary>
        /// Model description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

}
