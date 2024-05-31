using System;


namespace R5T.Z0011
{
	public class ProjectDirectoryRelativeDirectoryPaths : IProjectDirectoryRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static IProjectDirectoryRelativeDirectoryPaths Instance { get; } = new ProjectDirectoryRelativeDirectoryPaths();

	    private ProjectDirectoryRelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}