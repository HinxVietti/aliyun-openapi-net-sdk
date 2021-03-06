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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class ListCertificatesResponse : AcsResponse
	{

		private string requestId;

		private int? totalSize;

		private int? pageNumber;

		private int? pageSize;

		private List<ListCertificates_CertificateSummary> certificateSummaryList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalSize
		{
			get
			{
				return totalSize;
			}
			set	
			{
				totalSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListCertificates_CertificateSummary> CertificateSummaryList
		{
			get
			{
				return certificateSummaryList;
			}
			set	
			{
				certificateSummaryList = value;
			}
		}

		public class ListCertificates_CertificateSummary
		{

			private string certificateId;

			private string subject;

			private string issuer;

			private string keySpec;

			private string protectionLevel;

			private string notBefore;

			private string notAfter;

			private string status;

			public string CertificateId
			{
				get
				{
					return certificateId;
				}
				set	
				{
					certificateId = value;
				}
			}

			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}

			public string Issuer
			{
				get
				{
					return issuer;
				}
				set	
				{
					issuer = value;
				}
			}

			public string KeySpec
			{
				get
				{
					return keySpec;
				}
				set	
				{
					keySpec = value;
				}
			}

			public string ProtectionLevel
			{
				get
				{
					return protectionLevel;
				}
				set	
				{
					protectionLevel = value;
				}
			}

			public string NotBefore
			{
				get
				{
					return notBefore;
				}
				set	
				{
					notBefore = value;
				}
			}

			public string NotAfter
			{
				get
				{
					return notAfter;
				}
				set	
				{
					notAfter = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
