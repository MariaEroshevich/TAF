using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Epam.TestAutomation.Core.Browser;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Elements
{
    public class ElementsList<T>
    {
        private readonly List<T> _elements = new List<T>();
        private readonly By _locator;
        private readonly IWebElement _element;

        public ElementsList(By locator)
        {
            this._locator = locator; 
        }

        public ElementsList(IWebElement element)
        {
            this._element = element;

        }

        public List<T> GetElements()
        {
            UpdateElements();
            return _elements.ToList();
        }

        public List<TResult> Select<TResult>(Func<T, TResult> func)
        {
            UpdateElements();
            return _elements.Select(func).ToList();
        }

        private void UpdateElements()
        {
            if (_elements.ToList().Count != 0) return;
            var findedElements = FindElements(_locator);
            foreach (var findedElement in findedElements)
            {
                var elementInstance = (T)Activator.CreateInstance(typeof(T), findedElement);
                _elements.Add(elementInstance);
            }
        }

        public IWebElement FindElement(By by)
        {
            if (_element != null)
            {
                return _element.FindElement(by);
            }
            else
            {
                return BrowserFactory.Browser.FindElement(by);
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            if (_element != null)
            {
                return _element.FindElements(by);
            }
            else
            {
                return BrowserFactory.Browser.FindElements(by);
            }
        }
    }
}
