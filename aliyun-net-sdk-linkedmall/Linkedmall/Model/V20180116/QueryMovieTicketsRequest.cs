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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class QueryMovieTicketsRequest : RpcAcsRequest<QueryMovieTicketsResponse>
    {
        public QueryMovieTicketsRequest()
            : base("linkedmall", "2018-01-16", "QueryMovieTickets", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string orderId;

		private string bizUid;

		private string extJson;

		private string bizId;

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value);
			}
		}

		public string BizUid
		{
			get
			{
				return bizUid;
			}
			set	
			{
				bizUid = value;
				DictionaryUtil.Add(QueryParameters, "BizUid", value);
			}
		}

		public string ExtJson
		{
			get
			{
				return extJson;
			}
			set	
			{
				extJson = value;
				DictionaryUtil.Add(QueryParameters, "ExtJson", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

        public override QueryMovieTicketsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryMovieTicketsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
