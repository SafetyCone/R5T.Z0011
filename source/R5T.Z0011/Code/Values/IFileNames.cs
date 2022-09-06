using System;

using R5T.T0131;


namespace R5T.Z0011
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string FolderPublishProfile => @"FolderProfile.pubxml";
	}
}