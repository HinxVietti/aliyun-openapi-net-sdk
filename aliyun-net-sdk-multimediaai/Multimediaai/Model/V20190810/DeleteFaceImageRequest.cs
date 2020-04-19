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
using Aliyun.Acs.multimediaai;
using Aliyun.Acs.multimediaai.Transform;
using Aliyun.Acs.multimediaai.Transform.V20190810;

namespace Aliyun.Acs.multimediaai.Model.V20190810
{
    public class DeleteFaceImageRequest : RpcAcsRequest<DeleteFaceImageResponse>
    {
        public DeleteFaceImageRequest()
            : base("multimediaai", "2019-08-10", "DeleteFaceImage")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? faceGroupId;

		private long? facePersonId;

		private long? faceImageId;

		public long? FaceGroupId
		{
			get
			{
				return faceGroupId;
			}
			set	
			{
				faceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "FaceGroupId", value.ToString());
			}
		}

		public long? FacePersonId
		{
			get
			{
				return facePersonId;
			}
			set	
			{
				facePersonId = value;
				DictionaryUtil.Add(QueryParameters, "FacePersonId", value.ToString());
			}
		}

		public long? FaceImageId
		{
			get
			{
				return faceImageId;
			}
			set	
			{
				faceImageId = value;
				DictionaryUtil.Add(QueryParameters, "FaceImageId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteFaceImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteFaceImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
