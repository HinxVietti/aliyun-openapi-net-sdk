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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class GetPipelineStepLogRequest : RpcAcsRequest<GetPipelineStepLogResponse>
    {
        public GetPipelineStepLogRequest()
            : base("devops-rdc", "2020-03-03", "GetPipelineStepLog")
        {
			Method = MethodType.POST;
        }

		private long? offset;

		private string userPk;

		private string orgId;

		private long? pipelineId;

		private long? jobId;

		private string stepIndex;

		private long? limit;

		public long? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(BodyParameters, "Offset", value.ToString());
			}
		}

		public string UserPk
		{
			get
			{
				return userPk;
			}
			set	
			{
				userPk = value;
				DictionaryUtil.Add(BodyParameters, "UserPk", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public long? PipelineId
		{
			get
			{
				return pipelineId;
			}
			set	
			{
				pipelineId = value;
				DictionaryUtil.Add(BodyParameters, "PipelineId", value.ToString());
			}
		}

		public long? JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(BodyParameters, "JobId", value.ToString());
			}
		}

		public string StepIndex
		{
			get
			{
				return stepIndex;
			}
			set	
			{
				stepIndex = value;
				DictionaryUtil.Add(BodyParameters, "StepIndex", value);
			}
		}

		public long? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(BodyParameters, "Limit", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPipelineStepLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPipelineStepLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
