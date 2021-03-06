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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = context.HttpResponse;
			describeAccountsResponse.RequestId = context.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount>();
			for (int i = 0; i < context.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount dBInstanceAccount = new DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount();
				dBInstanceAccount.DBInstanceId = context.StringValue("DescribeAccounts.Accounts["+ i +"].DBInstanceId");
				dBInstanceAccount.AccountName = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				dBInstanceAccount.AccountStatus = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				dBInstanceAccount.AccountType = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountType");
				dBInstanceAccount.AccountDescription = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");

				List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege> dBInstanceAccount_databasePrivileges = new List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege>();
				for (int j = 0; j < context.Length("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges.Length"); j++) {
					DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege databasePrivilege = new DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege();
					databasePrivilege.DBName = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].DBName");
					databasePrivilege.AccountPrivilege = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilege");

					dBInstanceAccount_databasePrivileges.Add(databasePrivilege);
				}
				dBInstanceAccount.DatabasePrivileges = dBInstanceAccount_databasePrivileges;

				describeAccountsResponse_accounts.Add(dBInstanceAccount);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}