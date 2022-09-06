using System;

using R5T.T0131;


namespace R5T.Z0011
{
	[ValuesMarker]
	public partial interface IProjectDirectoryRelativeDirectoryPaths : IValuesMarker
	{
		public string PublishDirectory => @"bin\Release\net5.0\publish\";
	}
}