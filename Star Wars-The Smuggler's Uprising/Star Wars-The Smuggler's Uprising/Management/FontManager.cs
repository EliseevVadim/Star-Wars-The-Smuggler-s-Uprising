using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Drawing;

namespace TheGame
{
    class FontManager
    {
        private Font _font;
        private byte[] _fontData;
        private PrivateFontCollection _fonts;
        private float size_;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public FontManager(byte[] font_data, PrivateFontCollection fonts, float size)
        {
            _fontData = font_data;
            _fonts = fonts;
            size_ = size;
        }
        public Font GetFont()
        {
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(_fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(_fontData, 0, fontPtr, _fontData.Length);
            uint dummy = 0;
            _fonts.AddMemoryFont(fontPtr, _fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)_fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            _font = new Font(_fonts.Families[0], size_);
            return _font;
        }
    }
}
