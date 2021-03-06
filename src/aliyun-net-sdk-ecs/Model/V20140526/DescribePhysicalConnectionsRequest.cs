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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribePhysicalConnectionsRequest : RpcAcsRequest<DescribePhysicalConnectionsResponse>
    {
        public DescribePhysicalConnectionsRequest()
            : base("Ecs", "2014-05-26", "DescribePhysicalConnections")
        {
        }

		private List<Filter> _filters;

		private int? _pageNumber;

		private int? _pageSize;

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _ownerAccount;

		private string _userCidr;

		public List<Filter> Filters
		{
			get
			{
				return _filters;
			}

			set
			{
				_filters = value;
				for (int i = 0; i < _filters.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Key", _filters[i].Key);
					for (int j = 0; j < _filters[i].Values.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Value." +(j + 1), _filters[i].Values[j]);
					}
				}
			}
		}

		public int? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string UserCidr
		{
			get
			{
				return _userCidr;
			}
			set	
			{
				_userCidr = value;
				DictionaryUtil.Add(QueryParameters, "UserCidr", value);
			}
		}

		public class Filter
		{
		    public string Key { get; set; }

		    public List<string> Values { get; set; }
		}

        public override DescribePhysicalConnectionsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribePhysicalConnectionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}