using HTMLWYSIWYG;

namespace WinForms.Controls
{
    public partial class HTMLWYSIWYG : htmlwysiwyg
    {
        public HTMLWYSIWYG() => InitializeComponent();

        public string HTML
        {
            get => getHTML();
            set => setHTML(value);
        }
    }
}
