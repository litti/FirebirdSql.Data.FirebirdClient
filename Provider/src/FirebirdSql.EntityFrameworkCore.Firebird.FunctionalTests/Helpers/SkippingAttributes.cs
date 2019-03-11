﻿/*
 *    The contents of this file are subject to the Initial
 *    Developer's Public License Version 1.0 (the "License");
 *    you may not use this file except in compliance with the
 *    License. You may obtain a copy of the License at
 *    https://github.com/FirebirdSQL/NETProvider/blob/master/license.txt.
 *
 *    Software distributed under the License is distributed on
 *    an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either
 *    express or implied. See the License for the specific
 *    language governing rights and limitations under the License.
 *
 *    All Rights Reserved.
 */

//$Authors = Jiri Cincura (jiri@cincura.net)

using Xunit;

namespace FirebirdSql.EntityFrameworkCore.Firebird.FunctionalTests.Helpers
{
	public class WaitingFor14811FixMergeAttribute : FactAttribute
	{
		public WaitingFor14811FixMergeAttribute()
		{
			Skip = "See #14811 on EntityFrameworkCore.";
		}
	}

	public class HasDataInTheSameTransactionAsDDLAttribute : FactAttribute
	{
		public HasDataInTheSameTransactionAsDDLAttribute()
		{
			Skip = "HasData is called in the same transaction as DDL commands.";
		}
	}

#warning Can I somehow handle it in SQL generation?
	public class GeneratedNameTooLongAttribute : FactAttribute
	{
		public GeneratedNameTooLongAttribute()
		{
			Skip = "Generated name in the query is too long.";
		}
	}
	public class GeneratedNameTooLongTheoryAttribute : TheoryAttribute
	{
		public GeneratedNameTooLongTheoryAttribute()
		{
			Skip = "Generated name in the query is too long.";
		}
	}

	public class NotSupportedAttribute : FactAttribute
	{
		public NotSupportedAttribute()
		{
			Skip = "Not supported on Firebird.";
		}
	}
}
