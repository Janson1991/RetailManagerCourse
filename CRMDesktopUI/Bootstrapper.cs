#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：CRMDesktopUI
* 类 名 称 ：Bootstrapper
* 类 描 述 ：
* 命名空间 ：CRMDesktopUI
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Janson1991@outlook.com
* 创建时间 ：2019-08-02 00:00:21
* 更新时间 ：2019-08-02 00:00:21
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @coderzi.com 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using Caliburn.Micro;
using CRMDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CRMDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container.Instance(_container);
            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            GetType().Assembly.GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType =>
                _container.RegisterPerRequest(viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
