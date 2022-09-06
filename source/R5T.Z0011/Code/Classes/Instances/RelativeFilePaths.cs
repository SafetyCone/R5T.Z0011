using System;


namespace R5T.Z0011
{
	public class RelativeFilePaths : IRelativeFilePaths
	{
		#region Infrastructure

	    public static RelativeFilePaths Instance { get; } = new();

	    private RelativeFilePaths()
	    {
        }

	    #endregion
	}
}