using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP.CSharpTricks
{
    public interface IListGenericInterface<T>
    {
        List<string> GetListProperties();
    }

    public class listGeneric<T> : IListGenericInterface<T>
    {
        T _class;
        public listGeneric(T cls)
        {
            _class = cls;
        }
        public List<string> GetListProperties()
        {
            return _class.GetType().GetProperties().Select(p => p.Name).ToList();
        }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
