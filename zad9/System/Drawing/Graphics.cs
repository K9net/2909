namespace System.Drawing
{
    internal class Graphics
    {
        public float DpiX { get; internal set; }
        public float DpiY { get; internal set; }

        internal static Graphics FromHwnd(IntPtr windowHandle)
        {
            throw new NotImplementedException();
        }
    }
}