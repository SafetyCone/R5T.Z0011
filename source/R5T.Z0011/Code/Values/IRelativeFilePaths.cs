using System;

using R5T.T0131;


namespace R5T.Z0011
{
	[ValuesMarker]
	public partial interface IRelativeFilePaths : IValuesMarker
	{
		public string FolderPublishProfileFile => @"Files/FolderProfile.pubxml";
	}
}