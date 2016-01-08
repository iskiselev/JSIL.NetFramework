using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("System")]

namespace System.Configuration
{
    using System.Collections;

    public sealed class Configuration
    {
    }

    public class ConfigurationProperty
    {
        internal static readonly string DefaultCollectionPropertyName = "";

        public ConfigurationProperty(String name, Type type)
        {
            throw new NotImplementedException();
        }

        public ConfigurationProperty(String name, Type type, Object defaultValue)
            : this(name, type, defaultValue, ConfigurationPropertyOptions.None)
        {
            throw new NotImplementedException();
        }

        public ConfigurationProperty(String name, Type type, Object defaultValue, ConfigurationPropertyOptions options)
        {
            throw new NotImplementedException();
        }


        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class ConfigurationElement
    {
        protected internal Object this[ConfigurationProperty prop]
        {
            get { throw new NotImplementedException(); }
        }

        protected virtual ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }

        protected virtual void InitializeDefault()
        {
            throw new NotImplementedException();
        }

        protected virtual void PostDeserialize()
        {
            throw new NotImplementedException();
        }

        protected ContextInformation EvaluationContext
        {
            get { throw new NotImplementedException(); }
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ConfigurationPropertyAttribute : Attribute
    {
        public ConfigurationPropertyAttribute(String name)
        {
            throw new NotImplementedException();
        }

        public object DefaultValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ConfigurationPropertyOptions Options
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsDefaultCollection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsRequired
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class ConfigurationCollectionAttribute : Attribute
    {

        public ConfigurationCollectionAttribute(Type itemType)
        {
            throw new NotImplementedException();
        }

        public string AddItemName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string RemoveItemName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string ClearItemsName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ConfigurationElementCollectionType CollectionType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }

    public abstract class ConfigurationElementCollection : ConfigurationElement, ICollection
    {
        protected internal void BaseRemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        protected internal ConfigurationElement BaseGet(int index)
        {
            throw new NotImplementedException();
        }

        protected internal void BaseRemove(Object key)
        {
            throw new NotImplementedException();
        }

        protected virtual void BaseAdd(ConfigurationElement element)
        {
            throw new NotImplementedException();
        }

        protected virtual void BaseAdd(int index, ConfigurationElement element)
        {
            throw new NotImplementedException();
        }

        protected internal void BaseClear()
        {
        }

        protected internal ConfigurationElement BaseGet(Object key)
        {
            throw new NotImplementedException();
        }

        protected int BaseIndexOf(ConfigurationElement element)
        {
            throw new NotImplementedException();
        }

        protected abstract ConfigurationElement CreateNewElement();
        protected abstract Object GetElementKey(ConfigurationElement element);

        protected virtual bool ThrowOnDuplicate
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    }

    public enum ConfigurationElementCollectionType
    {
        BasicMap,
        AddRemoveClearMap,
        BasicMapAlternate,
        AddRemoveClearMapAlternate,
    }

    public abstract class ConfigurationSection : ConfigurationElement
    {
    }

    public sealed class ContextInformation
    {
        public bool IsMachineLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class ConfigurationErrorsException : ConfigurationException
    {
        public ConfigurationErrorsException(string message, Exception inner)
        {
            throw new NotImplementedException();
        }
    }
}