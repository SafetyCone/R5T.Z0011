using System;


namespace R5T.Z0011
{
	public class ExecutableFileRelativeFilePaths : IExecutableFileRelativeFilePaths
	{
		#region Infrastructure

	    public static IExecutableFileRelativeFilePaths Instance { get; } = new ExecutableFileRelativeFilePaths();

	    private ExecutableFileRelativeFilePaths()
	    {
        }

	    #endregion
	}
}