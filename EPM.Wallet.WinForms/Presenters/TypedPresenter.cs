using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using EPM.Wallet.Common.Interfaces;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public abstract class TypedPresenter<T, TK> : IPresenter where T : class, IDto<TK> 
    {
        protected readonly ITypedView<T, TK> View;
        protected readonly IDataMànager DataMànager;
        private readonly ITypedDataMànager<T, TK> _typedDataMànager;
        private PresenterMode _presenterMode;
        private BindingList<T> _bindingList;

        public BindingSource BindingSource { get; set; }

        protected TypedPresenter(ITypedView<T, TK> view, ITypedDataMànager<T, TK> typedDataMànager, IDataMànager dataMànager)
        {
            View = view;
            _typedDataMànager = typedDataMànager;
            DataMànager = dataMànager;

            SetItems();
        }
        
        public async void SetItems()
        {
            View.Items = (await _typedDataMànager.GetItems()).ToList();
            _bindingList = new BindingList<T>(View.Items);
            BindingSource = new BindingSource(_bindingList, null);

            View.RefreshItems();
        }

        public virtual void LoadLists()
        {
        }

        public void SetDetailData()
        {
            var item = BindingSource.Current;
            Mapper.Map(item, View);
            View.EnterDetailsMode();
        }

        public void AddNew()
        {
            View.EnterAddNewMode();
            _presenterMode = PresenterMode.AddNew;
        }

        public void Edit()
        {
            View.EnterEditMode();
            _presenterMode = PresenterMode.Edit;
        }

        public void Save()
        {
            switch (_presenterMode)
            {
                case PresenterMode.AddNew:
                    Create();
                    break;
                case PresenterMode.Edit:
                    Update();
                    break;
                default:
                    MessageBox.Show(@"Error: You can't use 'Save' button in this mode.", @"Error");
                    break;
            }
        }

        public void Cancel()
        {
            View.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }

        public async void Create()
        {
            var item = Mapper.Map<T>(View);
            item = await _typedDataMànager.PostItem(item);
            Mapper.Map(item, View);
            View.EnterReadMode();
            View.ItemAdded(item);
            _presenterMode = PresenterMode.Read;
        }

        public async void Update()
        {
            var item = Mapper.Map<T>(View);
            item = await _typedDataMànager.PutItem(item);
            Mapper.Map(item, View);
            View.ItemUpdated(item);
            View.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }

        public async void Delete()
        {
            var item = Mapper.Map<T>(View);

            var success = await _typedDataMànager.DeleteItem(item.Id);
            if (success)
            {
                View.ItemRemoved(item.Id);
            }
            else
            {
                MessageBox.Show(@"Error: You can't delete this item.", @"Error");
            }

            View.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }
    }
}