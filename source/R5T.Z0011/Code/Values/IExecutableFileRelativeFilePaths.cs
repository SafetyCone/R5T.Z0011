using System;

using R5T.T0131;


namespace R5T.Z0011
{
	[ValuesMarker]
	public partial interface IExecutableFileRelativeFilePaths : IValuesMarker
	{
		public string FolderPublishProfileFilePath => IExecutableFileRelativeFilePaths.zFolderPublishProfileFilePath.Value;
		private static readonly Lazy<string> zFolderPublishProfileFilePath = new Lazy<string>(
			Instances.ExecutableFileRelativePathOperator.GetFilesDirectoryFilePath(
				Instances.FileNames.FolderPublishProfile));
	}
}