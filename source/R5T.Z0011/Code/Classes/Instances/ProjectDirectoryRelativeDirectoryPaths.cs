using System;


namespace R5T.Z0011
{
	public class ProjectDirectoryRelativeDirectoryPaths : IProjectDirectoryRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static ProjectDirectoryRelativeDirectoryPaths Instance { get; } = new();

	    private ProjectDirectoryRelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}