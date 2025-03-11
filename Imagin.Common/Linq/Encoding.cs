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
		/// <param name="ToConvert"></param>
		/// <returns></returns>
		public static System.Text.Encoding ToComplement(this Encoding ToConvert)
		{
#pragma warning disable SYSLIB0001 // Type or member is obsolete
			return ToConvert switch
			{
				Encoding.ASCII => System.Text.Encoding.ASCII,
				Encoding.Unicode => System.Text.Encoding.Unicode,
				Encoding.UTF32 => System.Text.Encoding.UTF32,
				Encoding.UTF7 => System.Text.Encoding.UTF7,
				Encoding.UTF8 => System.Text.Encoding.UTF8,

				_ => default
			};
#pragma warning restore SYSLIB0001 // Type or member is obsolete
		}
	}
}
