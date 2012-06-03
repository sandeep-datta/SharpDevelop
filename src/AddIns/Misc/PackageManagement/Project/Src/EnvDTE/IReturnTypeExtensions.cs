﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.SharpDevelop.Dom;

namespace ICSharpCode.PackageManagement.EnvDTE
{
	internal static class IReturnTypeExtensions
	{
		public static string GetFullName(this IReturnType returnType)
		{
			return returnType
				.DotNetName
				.Replace('{', '<')
				.Replace('}', '>');
		}
	}
}