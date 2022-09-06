using System;

using R5T.F0026;


namespace R5T.Z0011
{
    public static class Instances
    {
        public static IExecutableFileRelativeFilePaths ExecutableFileRelativeFilePaths { get; } = Z0011.ExecutableFileRelativeFilePaths.Instance;
        public static IExecutableFileRelativePathOperator ExecutableFileRelativePathOperator { get; } = F0026.ExecutableFileRelativePathOperator.Instance;
        public static IFileNames FileNames { get; } = Z0011.FileNames.Instance;
    }
}