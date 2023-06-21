using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDynamicJsComponent.Shared
{
    public enum HtmlElement
    {
        form, button, checkbox, radio
    }

    public enum HtmlElementEvent
    {
        onClick, onDblClick, onMouseDown, onMouseUp, onChange, onKeyDown, onKeyUp, onMouseOver, onChecked, onUnchecked
    }

    public class HtmlComponent
    {
        public HtmlElement Element { get; set; }
        public string Content { get; set; }
        public Dictionary<HtmlElementEvent, string> Events { get; set; }
    }
}
