using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using System.Windows.Threading;
using System.Xaml;

namespace SpeechForms.ViewModels.Base
{
    public abstract class ViewModel : MarkupExtension, INotifyPropertyChanged, IDisposable, INotifyDataErrorInfo
    {
        private bool _Disposed;
        private WeakReference _RootRef;
        private WeakReference _TargetRef;

        private readonly Dictionary<string, List<string>> errors = new();

        public object TargetObject => _TargetRef?.Target;

        public object RootObject => _RootRef?.Target;

        //~ViewModel()
        //{
        //    Dispose(false);
        //}

        public void Dispose()
        {
            Dispose(true);
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || !errors.ContainsKey(propertyName)) return null;

            return errors[propertyName];
        }

        public bool HasErrors => errors.Count > 0;

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChangedEventHandler? handlers = PropertyChanged;
            if (handlers is null) return;

            Delegate[] invocation_list = handlers.GetInvocationList();

            PropertyChangedEventArgs arg = new PropertyChangedEventArgs(PropertyName);
            foreach (Delegate action in invocation_list)
                if (action.Target is DispatcherObject disp_object)
                    disp_object.Dispatcher.Invoke(action, this, arg);
                else
                    action.DynamicInvoke(this, arg);
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }

        public override object ProvideValue(IServiceProvider sp)
        {
            IProvideValueTarget? value_target_service = sp.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            IRootObjectProvider? root_object_service = sp.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;

            OnInitialized(
                value_target_service?.TargetObject,
                value_target_service?.TargetProperty,
                root_object_service?.RootObject);

            return this;
        }


        protected virtual void OnInitialized(object Target, object Property, object Root)
        {
            _TargetRef = new WeakReference(Target);
            _RootRef = new WeakReference(Root);
        }

        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
            // Освобождение управляемых ресурсов
        }

        private void OnDataErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null) ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected virtual void AddError(string propertyName, string errorMessage)
        {
            if (!errors.ContainsKey(propertyName)) errors.Add(propertyName, new List<string>());

            if (!errors[propertyName].Contains(errorMessage))
            {
                errors[propertyName].Add(errorMessage);
                OnDataErrorsChanged(propertyName);
            }
        }

        protected virtual void RemoveError(string propertyName, string errorMessage)
        {
            if (errors.ContainsKey(propertyName))
                if (errors[propertyName].Contains(errorMessage))
                {
                    errors[propertyName].Remove(errorMessage);
                    if (errors[propertyName].Count == 0) errors.Remove(propertyName);

                    OnDataErrorsChanged(propertyName);
                }
        }
    }
}