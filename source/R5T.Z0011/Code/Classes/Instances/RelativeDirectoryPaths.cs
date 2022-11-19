using System;


namespace R5T.Z0011
{
	public class RelativeDirectoryPaths : IRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static IRelativeDirectoryPaths Instance { get; } = new RelativeDirectoryPaths();

	    private RelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}