using Models;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms.Controls
{
    public partial class ImageFlowPanel : FlowLayoutPanel
    {
        private IBindingList source;

        public ImageFlowPanel() => InitializeComponent();

        public IBindingList DataSource
        {
            get => source;
            set
            {
                if (source != value)
                {
                    if (source != null)
                        source.ListChanged -= OnListChanged;

                    source = value;
                    source.ListChanged += OnListChanged;
                    Controls.Clear();

                    foreach(ProductImageModel img in source)
                    {
                        PictureBox pic = new PictureBox()
                        {
                            Tag = img,
                            Size = new Size(120, 100),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            ContextMenuStrip = ContextMenuStrip,
                            Image = Properties.Resources.OpenCart_32px,
                            ErrorImage = Properties.Resources.OpenCart_32px,
                            InitialImage = Properties.Resources.OpenCart_32px
                        };

                        pic.LoadAsync($"{Properties.Settings.Default.api_url}/image/{img.Image}");
                        Controls.Add(pic);
                    }
                }
            }
        }

        private void OnListChanged(object sender, ListChangedEventArgs args)
        {
            ListChangedType type = args.ListChangedType;

            if (type == ListChangedType.ItemDeleted)
            {
                Controls.RemoveAt(args.NewIndex);
            }
            else if (type == ListChangedType.ItemAdded)
            {
                var image = DataSource[args.NewIndex] as ProductImageModel;

                PictureBox pic = new PictureBox()
                {
                    Tag = image,
                    Size = new Size(120, 100),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ContextMenuStrip = ContextMenuStrip,
                    Image = Properties.Resources.OpenCart_32px,
                    ErrorImage = Properties.Resources.OpenCart_32px,
                    InitialImage = Properties.Resources.OpenCart_32px
                };

                pic.LoadAsync($"{Properties.Settings.Default.api_url}/image/{image.Image}");
                Controls.Add(pic);
            }
        }
    }
}
