using Bindery;
using MaterialSkin.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.ViewModels;
using WinForms.ViewModels.ProductTabViewModel;
using WinForms.Views.Tabs;

namespace WinForms.Views
{
    public partial class ProductView : UserControl, IView<ProductViewModel>
    {
        public ProductView()
        {
            InitializeComponent();

            cmbBx_DisGroupCustomer.DisplayMember = nameof(CustomerGroupModel);
            cmbBx_DisGroupCustomer.ValueMember = nameof(CustomerGroupModel.ID);

            cmbBx_SpecGroupCustomer.DisplayMember = nameof(SpecialOfferModel);
            cmbBx_SpecGroupCustomer.ValueMember = nameof(SpecialOfferModel.ID);

            cmbBx_lengthClass.DisplayMember = nameof(LengthModel);
            cmbBx_lengthClass.ValueMember = nameof(LengthModel.ID);

            cmbBx_manufacturer.DisplayMember = nameof(ManufacturerModel);
            cmbBx_manufacturer.ValueMember = nameof(ManufacturerModel.ID);

            cmbBx_stockStatus.DisplayMember = nameof(StatusStockModel);
            cmbBx_stockStatus.ValueMember = nameof(StatusStockModel.ID);

            cmbBx_taxclass.DisplayMember = nameof(TaxModel);
            cmbBx_taxclass.ValueMember = nameof(TaxModel.ID);

            cmbBx_weightClass.DisplayMember = nameof(WeightModel);
            cmbBx_weightClass.ValueMember = nameof(WeightModel.ID);
        }

        private ProductViewModel viewModel;

        public ProductViewModel ViewModel
        {
            get => viewModel;
            set
            {
                viewModel = value;
                Create.Binder(value)
                    .Control(this)
                        .OnEvent("Load")
                        .Execute(value.LoadCommand)
                    .Control(btBackTo)
                        .OnClick(value.BackCommand, this)
                    .Control(btSave)
                        .OnClick(value.SaveCommand)
                    .Control(picLoading)
                        .Property(pic => pic.Visible)
                        .Get(vm => vm.Loading)
                    .Control(lbl_msg)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Message)
                    // General Tab
                    .OnPropertyChanged(vm => vm.Languages)
                        .Subscribe(langs => OnLanguagesChanged(langs, value.Descriptions))
                    // Data Tab
                    .Control(txtBx_mpn)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.MPN)
                    .Control(txtBx_sku)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.SKU)
                    .Control(txtBx_upc)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.UPC)
                    .Control(txtBx_ean)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.EAN)
                    .Control(txtBx_jan)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.JAN)
                    .Control(txtBx_isbn)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.ISBN)
                    .Control(txtBx_model)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Model)
                    .Control(txtBx_location)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Location)
                    .Control(txtBx_price)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Price)
                    .Control(chkBx_status)
                        .Property(chk => chk.Checked)
                        .Bind(vm => vm.DataVM.Status)
                    .Control(cmbBx_taxclass)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.DataVM.Taxes)
                    .Control(cmbBx_taxclass)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.DataVM.TaxClass)
                    .Control(txtBxQuantity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Quantity)
                    .Control(txtBxMinQuantity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.MinimumQuantity)
                    .Control(chkBx_subtractStock)
                        .Property(chk => chk.Checked)
                        .Bind(vm => vm.DataVM.SubtractStock)
                    .Control(cmbBx_stockStatus)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.DataVM.StockStatuses)
                    .Control(cmbBx_stockStatus)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.DataVM.StockStatus)
                    .Control(txtBx_weight)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Weight)
                    .Control(cmbBx_weightClass)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.DataVM.Weights)
                    .Control(cmbBx_weightClass)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.DataVM.WeightClass)
                    .Control(txtBxLength)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Length)
                    .Control(txtBxWidth)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.DataVM.Width)
                    .Control(cmbBx_lengthClass)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.DataVM.Lengths)
                    .Control(cmbBx_lengthClass)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.DataVM.LengthClass)
                    .Control(chkBxShippingRequired)
                        .Property(chk => chk.Checked)
                        .Bind(vm => vm.DataVM.RequireShipping)
                    // Links Tab
                    .OnPropertyChanged(vm => vm.Stores)
                        .Subscribe(stores => OnCollectionChanged(stores, value.LinksVM.RelatedStores, flwLytPnl_stores))
                    .OnPropertyChanged(vm => vm.Categories)
                        .Subscribe(categories => OnCollectionChanged(categories, value.LinksVM.RelatedCategories, flowLayoutPanel_categories))
                    .OnPropertyChanged(vm => vm.Products)
                        .Subscribe(products => OnCollectionChanged(products, value.LinksVM.RelatedProducts, flowLayoutPanel_relatedProducts))
                    .Control(cmbBx_manufacturer)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.Manufacturers)
                    .Control(cmbBx_manufacturer)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.LinksVM.Manufacturer)
                    // Discount & Special Offer Tab
                    .Control(cmbBx_DisGroupCustomer)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.CustomerGroups)
                    .Control(cmbBx_SpecGroupCustomer)
                        .Property(cmb => cmb.DataSource)
                        .Get(vm => vm.CustomerGroups)
                    .Target(removeToolStrip)
                        .OnEvent("Click")
                        .Transform(o => o.Where(ctx =>
                                ((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl is PictureBox ||
                                (((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl is MaterialListView))
                            .Select(ctx =>
                                ((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl is PictureBox
                                ? ((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl?.Tag
                                : ((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl is MaterialListView
                                    ? ((((ctx.Sender as ToolStripMenuItem)?.Owner as MaterialContextMenuStrip)?.SourceControl as MaterialListView).SelectedItems.Count > 0)
                                        ? (((ctx.Sender as ToolStripMenuItem).Owner as MaterialContextMenuStrip).SourceControl as MaterialListView).SelectedItems[0].Tag
                                        : null
                                    : null))
                        .Execute(value.RemoveCommand);

                // Images Tab
                Create.Binder(value.ImagesVM)
                    .Control(lbl_ImgMsg)
                        .Property(lbl => lbl.Text)
                        .Get(vm => vm.Notification)
                    /// Image
                    .Control(picBxImage)
                        .Property(pic => pic.ImageLocation)
                        .Get(vm => vm.Image)
                        .OnClick(value.ImagesVM.ChangeCommand, new { fileImage, ParentForm })
                    /// Images
                    .Control(imagePanel)
                        .Property(panel => panel.DataSource)
                        .Get(vm => vm.Images)
                    .Control(btn_addImages)
                        .OnClick(value.ImagesVM.AddCommand, new { fileImage, ParentForm })
                    .Control(btn_delImg)
                        .OnClick(value.ImagesVM.RemoveCommand);

                // Data Tab
                Create.Binder(value.DataVM)
                    .Control(dateRelease)
                        .Property(date => date.Value)
                        .Bind(vm => vm.ReleaseDate);

                // Discount Tab
                Create.Binder(value.DiscountsVM)
                    .OnPropertyChanged(vm => vm.Discounts)
                        .Subscribe(list => OnListChanged(list, lstVwDiscounts, m => $"{m.CustomerGroup} {m.Quantity} {m.Priority} {m.Price:$#.##} {m.DateStart:d} {m.DateStart:d}".Split()))
                    .Control(cmbBx_DisGroupCustomer)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.CustomerGroup)
                    .Control(txtBx_discountQuantity)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Quantity)
                    .Control(txtBx_discountPriority)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Priority)
                    .Control(txtBx_discountPrice)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Price)
                    .Control(dateTimePicker_discountDateStart)
                        .Property(date => date.Value)
                        .Bind(vm => vm.Start)
                    .Control(dateTimePicker_discountDateEnd)
                        .Property(date => date.Value)
                        .Bind(vm => vm.Deadline)
                    .Control(btAddDiscount)
                        .OnClick(value.DiscountsVM.AddCommand);

                // Special Offer Tab
                Create.Binder(value.OffersVM)
                    .OnPropertyChanged(vm => vm.SpecialOffers)
                        .Subscribe(list => OnListChanged(list, lstVwOffers, m => $"{m.CustomerGroup} {m.Priority} {m.Price:$#.##} {m.DateStart:d} {m.DateEnd:d}".Split()))
                    .Control(cmbBx_SpecGroupCustomer)
                        .Property(cmb => cmb.SelectedValue)
                        .Bind(vm => vm.CustomerGroup)
                    .Control(txtBxSpecialPriority)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Priority)
                    .Control(txtBxSpecialPrice)
                        .Property(txt => txt.Text)
                        .Bind(vm => vm.Price)
                    .Control(dateTimePicker_SpecDateStart)
                        .Property(date => date.Value)
                        .Bind(vm => vm.Start)
                    .Control(dateTimePicker_SpecDateEnd)
                        .Property(date => date.Value)
                        .Bind(vm => vm.Deadline)
                    .Control(btAddOffer)
                        .OnClick(value.OffersVM.AddCommand);

                OnLoad(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Creates General Tabs to be used for each language.
        /// </summary>
        /// <param name="languages">Languages to be presented.</param>
        /// <param name="descriptions">Descriptions to be mapped in each language.</param>
        private void OnLanguagesChanged(IEnumerable<IDictionary<string, LanguageModel>> languages, IDictionary<int, DescriptionModel> descriptions)
        {
            int i = 0;
            Control[] views = new Control[languages.Count()];
            foreach (var langs in languages)
            {
                foreach (var lang in langs)
                {
                    if (!descriptions.ContainsKey(lang.Value.ID))
                        descriptions.Add(new KeyValuePair<int, DescriptionModel>(lang.Value.ID, new DescriptionModel()));

                    DescriptionModel description = descriptions[lang.Value.ID];
                    views[i++] = new ProductGeneralView()
                    {
                        Name = lang.Key,
                        Tag = lang.Value.ID,
                        Text = lang.Value.Name,
                        Dock = DockStyle.Fill,
                        ViewModel = new GeneralViewModel(description)
                    };
                }
            }

            foreach (Control view in views)
            {
                tabControl_langs.TabPages.Add(view.Name, view.Text);
                tabControl_langs.TabPages[view.Name].Controls.Add(view);
            }
        }

        /// <summary>
        /// Clears and populates a ListView whenever the model list changes.
        /// </summary>
        /// <typeparam name="TModel">Type of model.</typeparam>
        /// <param name="models">Collecction of models.</param>
        /// <param name="listView">Control ListView to be populated.</param>
        /// <param name="toArrayString">Function used for formatting the output in each row in the ListView.</param>
        private async void OnListChanged<TModel>(IEnumerable<TModel> models, MaterialListView listView, Func<TModel, string[]> toArrayString)
        {
            listView.Items.Clear();
            var _items = await Task.Run(() => 
            {
                int i = 0;
                ListViewItem[] items = new ListViewItem[models.Count()];
                
                foreach (TModel model in models)
                {
                    string[] row = toArrayString(model);
                    items[i++] = new ListViewItem(row)
                    {
                        Tag = model
                    };
                }

                return items;
            });
            listView.Items.AddRange(_items);
        }

        /// <summary>
        /// Creates a list of <see cref="MaterialCheckBox"/> in the given 
        /// <paramref name="panel"/> from each <paramref name="models"/> of type <typeparamref name="TModel"/>
        /// and marks as checked every <see cref="MaterialCheckBox"/> if the model is in <paramref name="relations"/>
        /// </summary>
        /// <typeparam name="TModel">Type of model</typeparam>
        /// <param name="models">Collection of models of type <typeparamref name="TModel"/>.</param>
        /// <param name="relations">Relations to be used for checking each <see cref="MaterialCheckBox"/>.</param>
        /// <param name="panel">Panel to be filled.</param>
        private async void OnCollectionChanged<TModel>(IEnumerable<TModel> models, ICollection<int> relations, Panel panel) 
        {
            panel.Controls.Clear();

            var checkboxes = await Task.Run(() =>
            {
                int i = 0;
                CheckBox[] chks = new CheckBox[models.Count()];

                foreach (TModel model in models)
                {
                    int id = 0;
                    switch (model)
                    {
                        case StoreModel store:
                            id = store.ID;
                            break;
                        case CategoryModel c:
                            id = c.ID;
                            break;
                        case ProductModel p:
                            id = p.ID;
                            break;
                    }

                    CheckBox chk = new CheckBox
                    {
                        Tag = id,
                        AutoSize = true,
                        Text = model.ToString(),
                        Checked = relations.Contains(id)
                    };

                    chk.CheckedChanged += (s, a) =>
                    {// Adds/Removes related stuff to the current product.
                        int _id = (int)(s as CheckBox).Tag;
                        if (relations.Contains(_id))
                            relations.Remove(_id);
                        else
                            relations.Add(_id);
                    };

                    chks[i++] = chk;
                }

                return chks;
            });

            panel.Controls.AddRange(checkboxes);
        }
    }
}
