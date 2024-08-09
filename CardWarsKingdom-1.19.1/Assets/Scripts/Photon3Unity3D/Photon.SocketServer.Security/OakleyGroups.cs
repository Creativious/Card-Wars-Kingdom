namespace Photon.SocketServer.Security
{
	internal static class OakleyGroups
	{
		public static readonly int Generator = 22;

		public static readonly byte[] OakleyPrime768 = new byte[96]
		{
			255, 255, 255, 255, 255, 255, 255, 255, 201, 15,
			218, 162, 33, 104, 194, 52, 196, 198, 98, 139,
			128, 220, 28, 209, 41, 2, 78, 8, 138, 103,
			204, 116, 2, 11, 190, 166, 59, 19, 155, 34,
			81, 74, 8, 121, 142, 52, 4, 221, 239, 149,
			25, 179, 205, 58, 67, 27, 48, 43, 10, 109,
			242, 95, 20, 55, 79, 225, 53, 109, 109, 81,
			194, 69, 228, 133, 181, 118, 98, 94, 126, 198,
			244, 76, 66, 233, 166, 58, 54, 32, 255, 255,
			255, 255, 255, 255, 255, 255
		};

		public static readonly byte[] OakleyPrime1024 = new byte[128]
		{
			255, 255, 255, 255, 255, 255, 255, 255, 201, 15,
			218, 162, 33, 104, 194, 52, 196, 198, 98, 139,
			128, 220, 28, 209, 41, 2, 78, 8, 138, 103,
			204, 116, 2, 11, 190, 166, 59, 19, 155, 34,
			81, 74, 8, 121, 142, 52, 4, 221, 239, 149,
			25, 179, 205, 58, 67, 27, 48, 43, 10, 109,
			242, 95, 20, 55, 79, 225, 53, 109, 109, 81,
			194, 69, 228, 133, 181, 118, 98, 94, 126, 198,
			244, 76, 66, 233, 166, 55, 237, 107, 11, 255,
			92, 182, 244, 6, 183, 237, 238, 56, 107, 251,
			90, 137, 159, 165, 174, 159, 36, 17, 124, 75,
			31, 230, 73, 40, 102, 81, 236, 230, 83, 129,
			255, 255, 255, 255, 255, 255, 255, 255
		};

		public static readonly byte[] OakleyPrime1536 = new byte[192]
		{
			255, 255, 255, 255, 255, 255, 255, 255, 201, 15,
			218, 162, 33, 104, 194, 52, 196, 198, 98, 139,
			128, 220, 28, 209, 41, 2, 78, 8, 138, 103,
			204, 116, 2, 11, 190, 166, 59, 19, 155, 34,
			81, 74, 8, 121, 142, 52, 4, 221, 239, 149,
			25, 179, 205, 58, 67, 27, 48, 43, 10, 109,
			242, 95, 20, 55, 79, 225, 53, 109, 109, 81,
			194, 69, 228, 133, 181, 118, 98, 94, 126, 198,
			244, 76, 66, 233, 166, 55, 237, 107, 11, 255,
			92, 182, 244, 6, 183, 237, 238, 56, 107, 251,
			90, 137, 159, 165, 174, 159, 36, 17, 124, 75,
			31, 230, 73, 40, 102, 81, 236, 228, 91, 61,
			194, 0, 124, 184, 161, 99, 191, 5, 152, 218,
			72, 54, 28, 85, 211, 154, 105, 22, 63, 168,
			253, 36, 207, 95, 131, 101, 93, 35, 220, 163,
			173, 150, 28, 98, 243, 86, 32, 133, 82, 187,
			158, 213, 41, 7, 112, 150, 150, 109, 103, 12,
			53, 78, 74, 188, 152, 4, 241, 116, 108, 8,
			202, 35, 115, 39, 255, 255, 255, 255, 255, 255,
			255, 255
		};
	}
}
