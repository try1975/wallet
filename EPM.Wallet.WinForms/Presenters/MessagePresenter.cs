using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class MessagePresenter
    {
        private readonly IDataMаnager _dataMаnager;
        private readonly IMessageView _view;
        private PresenterMode _presenterMode;

        public MessagePresenter(IMessageView view, IDataMаnager dataMаnager)
        {
            _view = view;
            _dataMаnager = dataMаnager;
            SetItems();
            LoadLists();
        }

        public async void SetItems()
        {
            _view.Items = (await _dataMаnager.GetMessages()).ToList();
            _view.RefreshItems();
        }

        public async void LoadLists()
        {
            var clientDtos = await _dataMаnager.GetClients();
            if (clientDtos != null)
            {
                var currencies = clientDtos.ToList();
                _view.ClientList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                _view.ClientList = new List<KeyValuePair<string, string>>();
            }
        }

        public void AddNew()
        {
            _view.EnterAddNewMode();
            _presenterMode = PresenterMode.AddNew;
        }

        public void Edit()
        {
            _view.EnterEditMode();
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
            _view.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }

        public async void Delete()
        {
            var item = Mapper.Map<MessageDto>(_view);
            if (item.Id != Guid.Empty)
            {
                var success = await _dataMаnager.DeleteMessage(item.Id);
                if (success)
                {
                    _view.ItemRemoved(item.Id);
                }
                else
                {
                    MessageBox.Show(@"Error: You can't delete this item.", @"Error");
                }
            }
            _view.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }

        private async void Update()
        {
            var item = Mapper.Map<MessageDto>(_view);
            item = await _dataMаnager.PutMessage(item);
            Mapper.Map(item, _view);
            _view.ItemUpdated(item);
            _view.EnterReadMode();
            _presenterMode = PresenterMode.Read;
        }

        private async void Create()
        {
            var item = Mapper.Map<MessageDto>(_view);
            item = await _dataMаnager.PostMessage(item);
            Mapper.Map(item, _view);
            _view.EnterReadMode();
            _view.ItemAdded(item);
            _presenterMode = PresenterMode.Read;
        }
    }
}