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
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class CreateAppRequest : RpcAcsRequest<CreateAppResponse>
    {
        public CreateAppRequest()
            : base("Push", "2016-08-01", "CreateApp")
        {
        }

		private string _appName;

		private int? _industryId;

		private string _description;

		public string AppName
		{
			get
			{
				return _appName;
			}
			set	
			{
				_appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public int? IndustryId
		{
			get
			{
				return _industryId;
			}
			set	
			{
				_industryId = value;
				DictionaryUtil.Add(QueryParameters, "IndustryId", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

        public override CreateAppResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}