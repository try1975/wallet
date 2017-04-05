using System;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.Configuration;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.WinForms.Data;
using EPM.Wallet.WinForms.Ninject;

namespace EPM.Wallet.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());
            var cfg = new MapperConfigurationExpression();
            AutoMapperConfig.RegisterMappings(cfg);
            Mapper.Initialize(cfg);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = CompositionRoot.Resolve<Form1>();
            var names = Enum.GetNames(typeof(ClientAppVariant));
            form.Text = names[(int)AppGlobal.ClientAppVariant];
            Application.Run(form);
        }
    }
}