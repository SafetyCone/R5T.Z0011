using System;


namespace R5T.Z0011
{
	public class RelativeDirectoryPaths : IRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static RelativeDirectoryPaths Instance { get; } = new();

	    private RelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}