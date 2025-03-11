using System.Runtime.Versioning;

using Imagin.Common.Text;

namespace Imagin.Common.Linq
{
	/// <summary>
	/// 
	/// </summary>
	public static class EncodingExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="encoding"></param>
		/// <returns></returns>
		#if NETCOREAPP
		[SupportedOSPlatform("windows")]
		#endif
		public static System.Text.Encoding GetEncoding(this Encoding encoding)
		{
#pragma warning disable SYSLIB0001 // Type or member is obsolete
			return encoding switch
			{
				Encoding.ASCII => System.Text.Encoding.ASCII,
				Encoding.Unicode => System.Text.Encoding.Unicode,
				Encoding.UTF32 => System.Text.Encoding.UTF32,
				Encoding.UTF7 => System.Text.Encoding.UTF7,
				Encoding.UTF8 => System.Text.Encoding.UTF8,

				_ => System.Text.Encoding.Default
			};
#pragma warning restore SYSLIB0001 // Type or member is obsolete
		}
	}
}
