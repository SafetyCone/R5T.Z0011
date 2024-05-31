using System;


namespace R5T.Z0011
{
	public class RelativeFilePaths : IRelativeFilePaths
	{
		#region Infrastructure

	    public static IRelativeFilePaths Instance { get; } = new RelativeFilePaths();

	    private RelativeFilePaths()
	    {
        }

	    #endregion
	}
}