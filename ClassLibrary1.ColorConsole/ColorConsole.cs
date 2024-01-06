using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibrary1.ColorConsole
{
    public class ColorConsole : TextWriter
    {
        private readonly Encoding _encoding;

        public override Encoding Encoding => _encoding ?? Encoding.UTF8;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="encoding">If null will be use UTF8.</param>
        public ColorConsole(Encoding encoding)
        {
            _encoding = encoding;
        }

        public ColorConsole(IFormatProvider formatProvider) : base(formatProvider)
        {

        }


        public override void WriteLine(string value)
        {
            //Regex

            base.WriteLine(value);
        }
    }
}